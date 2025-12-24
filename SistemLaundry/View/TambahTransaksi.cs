using System;
using System.Data;
using System.Windows.Forms;
using SistemLaundry.Controller;

namespace SistemLaundry.View
{
    public partial class TambahTransaksi : Form
    {
        LaundryController laundryController;
        ValidationController validation;
        DataTable dtDetail;

        // Variabel statis untuk diakses Form Pembayaran
        public static string IdTransaksiAktif;
        public static string NamaPelangganAktif;
        public static int TotalTransaksi;
        public static bool SudahBayar = false;
        public static int UangBayarAktif; // Tambahkan ini
        public static int KembalianAktif; // Tambahkan ini

        public TambahTransaksi()
        {
            InitializeComponent();

            cbx_jenis_layanan.SelectedIndexChanged += cbx_jenis_layanan_SelectedIndexChanged;
            cbx_nama_layanan.SelectedIndexChanged += cbx_nama_layanan_SelectedIndexChanged;

            cbx_nama_layanan.DataSource = null;

            laundryController = new LaundryController();
            validation = new ValidationController();

            InitDetailTable();
            LoadPelanggan();
            LoadJenisLayanan();

            txt_status_laundry.Text = "Proses";
            txt_status_pembayaran.Text = "Menunggu Pembayaran";
            txt_status_laundry.ReadOnly = true;
            txt_status_pembayaran.ReadOnly = true;
            btn_detail_transaksi.Enabled = false;


            txt_total.Text = "0";
            txt_total.ReadOnly = true;
        }

        // ================= INIT DETAIL TABLE =================
        void InitDetailTable()
        {
            dtDetail = new DataTable();
            dtDetail.Columns.Add("id_layanan");
            dtDetail.Columns.Add("nama_layanan");
            dtDetail.Columns.Add("harga", typeof(int));
            dtDetail.Columns.Add("jumlah", typeof(double));
            dtDetail.Columns.Add("subtotal", typeof(int));

            dgv_detail_transaksi.DataSource = dtDetail;
        }

        // ================= LOAD DATA =================
        void LoadPelanggan()
        {
            cbx_nama_pelanggan.DataSource = laundryController.GetPelanggan();
            cbx_nama_pelanggan.DisplayMember = "nama_pelanggan";
            cbx_nama_pelanggan.ValueMember = "id_pelanggan";
        }

        void LoadJenisLayanan()
        {
            cbx_jenis_layanan.DataSource = laundryController.GetJenisLayanan();
            cbx_jenis_layanan.DisplayMember = "jenis_layanan";
            cbx_jenis_layanan.ValueMember = "jenis_layanan";
            cbx_jenis_layanan.SelectedIndex = -1;
        }

        // ================= EVENT =================
        private void cbx_jenis_layanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_jenis_layanan.SelectedIndex == -1) return;

            string jenis = cbx_jenis_layanan.SelectedValue.ToString();
            cbx_nama_layanan.DataSource = laundryController.GetLayananByJenis(jenis);
            cbx_nama_layanan.DisplayMember = "nama_layanan";
            cbx_nama_layanan.ValueMember = "id_layanan";
            cbx_nama_layanan.SelectedIndex = -1;

            txt_harga.Clear();
            txt_jumlah.Clear();
        }

        private void cbx_nama_layanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_nama_layanan.SelectedItem is DataRowView row)
            {
                txt_harga.Text = row["harga"].ToString();
                int estimasi = Convert.ToInt32(row["estimasi_selesai"]);
                dtp_tanggal_selesai.Value = dtp_tanggal_masuk.Value.AddDays(estimasi);
            }
        }

        void HitungTotal()
        {
            int total = 0;
            foreach (DataRow row in dtDetail.Rows)
                total += Convert.ToInt32(row["subtotal"]);

            txt_total.Text = total.ToString();
        }

        void ResetInputLayanan()
        {
            cbx_jenis_layanan.SelectedIndex = -1;
            cbx_nama_layanan.DataSource = null;
            txt_harga.Clear();
            txt_jumlah.Clear();
        }

        private void btn_tambah_layanan_Click(object sender, EventArgs e)
        {
            if (cbx_nama_layanan.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih layanan terlebih dahulu");
                return;
            }
            if (cbx_nama_pelanggan.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih pelanggan terlebih dahulu");
                return;
            }
            string jenis = cbx_jenis_layanan.Text;
            if (!validation.ValidasiJumlahLayanan(txt_jumlah.Text, jenis)) return;

            int harga = Convert.ToInt32(txt_harga.Text);
            double jumlah = Convert.ToDouble(txt_jumlah.Text);
            int subtotal = (int)(harga * jumlah);

            dtDetail.Rows.Add(
                cbx_nama_layanan.SelectedValue.ToString(),
                cbx_nama_layanan.Text,
                harga,
                jumlah,
                subtotal
            );

            HitungTotal();
            ResetInputLayanan();
        }

        // ================= SIMPAN TRANSAKSI =================
        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (!SudahBayar)
            {
                MessageBox.Show("Silakan lakukan pembayaran terlebih dahulu melalui tombol 'Bayar'");
                return;
            }

            if (dtDetail.Rows.Count == 0)
            {
                MessageBox.Show("Detail transaksi kosong");
                return;
            }

            laundryController.SimpanTransaksi(
                 IdTransaksiAktif,
                 cbx_nama_pelanggan.SelectedValue.ToString(),
                 dtp_tanggal_masuk.Value,
                 dtp_tanggal_selesai.Value,
                 Convert.ToInt32(txt_total.Text),
                 UangBayarAktif, // Kirim Uang Bayar
                 KembalianAktif, // Kirim Kembalian
                 dtDetail
             );

            MessageBox.Show("Transaksi berhasil disimpan.\nSilakan lihat Detail Transaksi.");
            btn_detail_transaksi.Enabled = true;
            btn_detail_transaksi.Focus();

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            // Pastikan form Transaksi yang sudah ada ditampilkan kembali
            MenuKasir menuKasir = new MenuKasir();
            menuKasir.Show();
            this.Close();
        }

        private void btn_bayar_Click(object sender, EventArgs e)
        {
            if (dtDetail.Rows.Count == 0)
            {
                MessageBox.Show("Tambahkan layanan terlebih dahulu");
                return;
            }

            
            IdTransaksiAktif = txt_id_transaksi.Text;

            TotalTransaksi = Convert.ToInt32(txt_total.Text);
            NamaPelangganAktif = cbx_nama_pelanggan.Text;

            using (Pembayaran frmBayar = new Pembayaran())
            {
                frmBayar.ShowDialog();
            }

            if (SudahBayar)
            {
                txt_status_pembayaran.Text = "Pembayaran Berhasil";
                btn_bayar.Enabled = false;
                btn_simpan.Focus();
            }
        }

        private void btn_detail_transaksi_Click(object sender, EventArgs e)
        {
            DetailTransaksi frmDetail = new DetailTransaksi(
            IdTransaksiAktif,
            LaundryController.ModeDetailTransaksi.Kasir
        );
            frmDetail.ShowDialog();
            // ===== RESET FORM SETELAH DETAIL DITUTUP =====
            dtDetail.Clear();
            txt_total.Text = "0";
            txt_status_pembayaran.Text = "Menunggu Pembayaran";

            txt_id_transaksi.Clear();
            cbx_nama_pelanggan.SelectedIndex = -1;

            SudahBayar = false;
            btn_bayar.Enabled = true;

            MessageBox.Show("Siap untuk transaksi baru ✅");
        }
    }
}