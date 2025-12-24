using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SistemLaundry.Controller;

namespace SistemLaundry.View
{
    public partial class DataLayanan : Form
    {
        LaundryController laundryController;
        ValidationController validationController;

        public DataLayanan()
        {
            InitializeComponent();
            laundryController = new LaundryController();
            validationController = new ValidationController();
        }

        // ================= IMAGE → BYTE[] =================
        byte[] ImageToByteArray(PictureBox pb)
        {
            if (pb.Image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (Bitmap bmp = new Bitmap(pb.Image))
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                return ms.ToArray();
            }
        }

        // ================= TAMPIL DATA + GAMBAR =================
        void TampilData()
        {
            DataTable dt = laundryController.TampilkanLayanan();

            // Tambah kolom image untuk tampilan
            if (!dt.Columns.Contains("foto_view"))
                dt.Columns.Add("foto_view", typeof(Image));

            foreach (DataRow row in dt.Rows)
            {
                if (row["gambar"] != DBNull.Value)
                {
                    using (MemoryStream ms = new MemoryStream((byte[])row["gambar"]))
                    {
                        row["foto_view"] = Image.FromStream(ms);
                    }
                }
            }

            // 1️⃣ SET DATASOURCE
            dgv_layanan.DataSource = dt;

            // 2️⃣ SEMBUNYIKAN KOLOM ASLI BYTE[]
            dgv_layanan.Columns["gambar"].Visible = false;

            // 3️⃣ HEADER TEXT ⬅️ INI JAWABAN "LETAK DIMANA"
            dgv_layanan.Columns["id_layanan"].HeaderText = "ID Layanan";
            dgv_layanan.Columns["nama_layanan"].HeaderText = "Nama Layanan";
            dgv_layanan.Columns["jenis_layanan"].HeaderText = "Jenis Layanan";
            dgv_layanan.Columns["harga"].HeaderText = "Harga";
            dgv_layanan.Columns["estimasi_selesai"].HeaderText = "Estimasi (Hari)";
            dgv_layanan.Columns["foto_view"].HeaderText = "Foto";

            // 4️⃣ ATUR TAMPILAN GAMBAR
            if (dgv_layanan.Columns["foto_view"] is DataGridViewImageColumn img)
            {
                img.ImageLayout = DataGridViewImageCellLayout.Zoom;
                img.Width = 100;
            }

            dgv_layanan.RowTemplate.Height = 90;
        }


        private void DataLayanan_Load(object sender, EventArgs e)
        {
            cbx_jenis_layanan.Items.AddRange(new string[]
            {
                "Kiloan/kg",
                "Satuan/pcs"
            });

            cbx_jenis_layanan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_jenis_layanan.SelectedIndex = 0;

            // ===== SETTING GRID SEKALI SAJA =====
            dgv_layanan.AutoGenerateColumns = true;
            dgv_layanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_layanan.RowTemplate.Height = 80;

            TampilData();

            // ===== SET IMAGE COLUMN =====
            if (dgv_layanan.Columns.Contains("foto_view"))
            {
                DataGridViewImageColumn imgCol =
                    dgv_layanan.Columns["foto_view"] as DataGridViewImageColumn;

                imgCol.HeaderText = "Foto";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            dgv_layanan.Columns["gambar"].Visible = false;
        }

        // ================= KLIK GRID =================
        private void dgv_layanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgv_layanan.Rows[e.RowIndex];

            txt_id_layanan.Text = row.Cells["id_layanan"].Value.ToString();
            txt_id_layanan.Enabled = false;

            txt_nama_layanan.Text = row.Cells["nama_layanan"].Value.ToString();
            cbx_jenis_layanan.Text = row.Cells["jenis_layanan"].Value.ToString();
            txt_harga.Text = row.Cells["harga"].Value.ToString();
            txt_estimasi_selesai.Text = row.Cells["estimasi_selesai"].Value.ToString();

            // Ambil gambar ASLI (byte[]) untuk edit
            if (row.Cells["gambar"].Value != DBNull.Value)
            {
                byte[] img = (byte[])row.Cells["gambar"].Value;
                using (MemoryStream ms = new MemoryStream(img))
                {
                    pictureBox_foto_layanan.Image = Image.FromStream(ms);
                    pictureBox_foto_layanan.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                pictureBox_foto_layanan.Image = null;
            }
            bool dipakai = laundryController.CekLayananDipakai(txt_id_layanan.Text);
            btn_hapus.Enabled = !dipakai;
        }

        // ================= CLEAR =================
        void ClearForm()
        {
            txt_id_layanan.Clear();
            txt_nama_layanan.Clear();
            txt_harga.Clear();
            txt_estimasi_selesai.Clear();
            cbx_jenis_layanan.SelectedIndex = 0;
            pictureBox_foto_layanan.Image = null;
            txt_id_layanan.Enabled = true;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    pictureBox_foto_layanan.Image = Image.FromStream(fs);
                }
                pictureBox_foto_layanan.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        // ================= TAMBAH =================
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (!validationController.ValidasiLayanan(
                txt_id_layanan.Text,
                txt_nama_layanan.Text,
                cbx_jenis_layanan.Text,
                txt_harga.Text,
                txt_estimasi_selesai.Text))
                return;

            if (laundryController.TambahLayanan(
                txt_id_layanan.Text,
                txt_nama_layanan.Text,
                cbx_jenis_layanan.Text,
                int.Parse(txt_harga.Text),
                int.Parse(txt_estimasi_selesai.Text),
                ImageToByteArray(pictureBox_foto_layanan)))
            {
                MessageBox.Show("Data berhasil ditambahkan");
                TampilData();
                ClearForm();
            }
        }

        // ================= EDIT =================
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_layanan.Text)) return;

            if (laundryController.EditLayanan(
                txt_id_layanan.Text,
                txt_nama_layanan.Text,
                cbx_jenis_layanan.Text,
                int.Parse(txt_harga.Text),
                int.Parse(txt_estimasi_selesai.Text),
                ImageToByteArray(pictureBox_foto_layanan)))
            {
                MessageBox.Show("Data berhasil diubah");
                TampilData();
                ClearForm();
            }
        }

        // ================= HAPUS =================
        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_layanan.Text)) return;

            // 🔒 CEK APAKAH LAYANAN SUDAH DIPAKAI
            if (laundryController.CekLayananDipakai(txt_id_layanan.Text))
            {
                MessageBox.Show(
                    "Layanan ini sudah pernah digunakan dalam transaksi.\n" +
                    "Data tidak boleh dihapus!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // KONFIRMASI HAPUS
            if (MessageBox.Show(
                "Yakin ingin menghapus layanan ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (laundryController.HapusLayanan(txt_id_layanan.Text))
                {
                    MessageBox.Show("Data layanan berhasil dihapus");
                    TampilData();
                    ClearForm();
                }
            }
        }
        private void btn_kembali_Click(object sender, EventArgs e)
        {
            MenuUtama menuUtama = new MenuUtama();
            menuUtama.Show();
            this.Close();
        }

        private void txt_pencarian_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = laundryController.SearchLayanan(txt_pencarian.Text);

            if (!dt.Columns.Contains("foto_view"))
                dt.Columns.Add("foto_view", typeof(Image));

            foreach (DataRow row in dt.Rows)
            {
                if (row["gambar"] != DBNull.Value)
                {
                    using (MemoryStream ms = new MemoryStream((byte[])row["gambar"]))
                    {
                        row["foto_view"] = Image.FromStream(ms);
                    }
                }
            }

            dgv_layanan.DataSource = dt;

            dgv_layanan.Columns["gambar"].Visible = false;
        }
    }
}
