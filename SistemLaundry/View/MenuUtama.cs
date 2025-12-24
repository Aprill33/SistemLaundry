using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemLaundry.Controller;

namespace SistemLaundry.View
{
    public partial class MenuUtama : Form
    {
        LaundryController laundryController;
        public MenuUtama()
        {
            InitializeComponent();
            laundryController = new LaundryController();
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_data_pelanggan_Click(object sender, EventArgs e)
        {
            DataPelanggan dataPelanggan = new DataPelanggan();
            dataPelanggan.Show();
            this.Hide();
        }

        private void btn_data_layanan_Click(object sender, EventArgs e)
        {
            DataLayanan dataLayanan = new DataLayanan();
            dataLayanan.Show();
            this.Hide();
        }

        private void btn_transaksi_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi();
            transaksi.Show();
            this.Hide();
        }

        private void btn_manajemen_admin_Click(object sender, EventArgs e)
        {
            DataAdmin dataAdmin = new DataAdmin();
            dataAdmin.Show();
            this.Hide();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Apakah Anda yakin ingin keluar dari akun admin?",
            "Konfirmasi Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

            if (result == DialogResult.Yes)
            {
                // reset session
                LaundryController.KasirAktif = null;
                LaundryController.RoleAktif = null;

                // kembali ke form login admin
                Masuk loginAdmin = new Masuk();
                loginAdmin.Show();

                this.Close(); // tutup MenuUtama
            }
        }
    }
}
