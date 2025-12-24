using System;
using System.Windows.Forms;
using SistemLaundry.Controller;

namespace SistemLaundry.View
{
    public partial class TambahPelanggan : Form
    {
        LaundryController laundryController;
        ValidationController validation;

        public TambahPelanggan()
        {
            InitializeComponent();
            laundryController = new LaundryController();
            validation = new ValidationController();
        }
        private void btn_kembali_Click(object sender, EventArgs e)
        {
            MenuKasir menuKasir = new MenuKasir();
            menuKasir.Show();
            this.Close();
        }

        private void btn_simpan_Click_1(object sender, EventArgs e)
        {
            string id = txt_id_pelanggan.Text.Trim();
            string nama = txt_nama_pelanggan.Text.Trim();
            string notelp = txt_no_hp.Text.Trim();
            string alamat = txt_alamat.Text.Trim();

            // ================= VALIDASI =================
            bool valid = validation.ValidasiPelanggan(
                id,
                nama,
                notelp,
                alamat,
                isEdit: false // FALSE karena TAMBAH DATA
            );

            if (!valid) return;

            // ================= SIMPAN =================
            bool berhasil = laundryController.TambahPelanggan(
                id, nama, notelp, alamat
            );

            if (berhasil)
            {
                MessageBox.Show("Data pelanggan berhasil ditambahkan",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_id_pelanggan.Clear();
                txt_nama_pelanggan.Clear();
                txt_no_hp.Clear();
                txt_alamat.Clear();
                txt_id_pelanggan.Focus();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan pelanggan",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
