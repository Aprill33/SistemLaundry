using System;
using System.Data;
using System.Windows.Forms;
using SistemLaundry.Controller;

namespace SistemLaundry.View
{
    public partial class DataPelanggan : Form
    {
        LaundryController laundryController;
        ValidationController validationController;

        public DataPelanggan()
        {
            InitializeComponent();
            laundryController = new LaundryController();
            validationController = new ValidationController();
        }

        private void DataPelanggan_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        // =====================================================
        // TAMPIL DATA PELANGGAN
        // =====================================================
        void TampilData()
        {
            dgv_pelanggan.DataSource = laundryController.GetDataPelanggan();
            dgv_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_pelanggan.ReadOnly = true;
            dgv_pelanggan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // =====================================================
        // KLIK DATA GRID
        // =====================================================
        private void dgv_pelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgv_pelanggan.Rows[e.RowIndex];

            txt_id_pelanggan.Text = row.Cells["id_pelanggan"].Value.ToString();
            txt_nama_pelanggan.Text = row.Cells["nama_pelanggan"].Value.ToString();
            txt_no_hp.Text = row.Cells["no_hp"].Value.ToString();
            txt_alamat.Text = row.Cells["alamat"].Value.ToString();

            txt_id_pelanggan.Enabled = false; // ID tidak boleh diubah saat edit
        }

        // =====================================================
        // EDIT DATA PELANGGAN
        // =====================================================
        private void btn_edit_Click(object sender, EventArgs e)
        {
            string id = txt_id_pelanggan.Text;
            string nama = txt_nama_pelanggan.Text;
            string nohp = txt_no_hp.Text;
            string alamat = txt_alamat.Text;

            // VALIDASI EDIT (isEdit = true)
            if (!validationController.ValidasiPelanggan(id, nama, nohp, alamat, true))
                return;

            bool berhasil = laundryController.EditPelanggan(id, nama, nohp, alamat);

            if (berhasil)
            {
                MessageBox.Show("Data pelanggan berhasil diperbarui",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TampilData();
            }
        }

        // =====================================================
        // HAPUS DATA (DENGAN CEK TRANSAKSI)
        // =====================================================
        private void btn_hapus_Click(object sender, EventArgs e)
        {
            string id = txt_id_pelanggan.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Pilih data pelanggan terlebih dahulu");
                return;
            }

            // Cek relasi transaksi
            if (laundryController.CekPelangganPunyaTransaksi(id))
            {
                MessageBox.Show(
                    "Pelanggan tidak dapat dihapus karena sudah memiliki transaksi",
                    "Akses Ditolak",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah yakin ingin menghapus data pelanggan ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi == DialogResult.Yes)
            {
                if (laundryController.HapusPelanggan(id))
                {
                    MessageBox.Show("Data pelanggan berhasil dihapus",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TampilData();
                }
            }
        }

        // =====================================================
        // SEARCH DATA
        // =====================================================
        private void txt_pencarian_TextChanged(object sender, EventArgs e)
        {
            dgv_pelanggan.DataSource = laundryController.Search(txt_pencarian.Text);
        }

        // =====================================================
        // NAVIGASI
        // =====================================================
        private void btn_kembali_Click(object sender, EventArgs e)
        {
            MenuUtama menu = new MenuUtama();
            menu.Show();
            this.Close();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
