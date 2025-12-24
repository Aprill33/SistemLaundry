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
    public partial class MenuKasir : Form
    {
        public MenuKasir()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_tambah_pelanggan_Click(object sender, EventArgs e)
        {
            TambahPelanggan tambahPelanggan = new TambahPelanggan();
            tambahPelanggan.Show();
            this.Hide();
        }

        private void btn_tambah_transaksi_Click(object sender, EventArgs e)
        {
            TambahTransaksi tambahTransaksi = new TambahTransaksi();
            tambahTransaksi.Show();
            this.Hide();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Apakah Anda yakin ingin keluar dari akun?",
               "Konfirmasi Logout",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                LaundryController.KasirAktif = null;
                LaundryController.RoleAktif = null;

                MasukKasir login = new MasukKasir();
                login.Show();
                this.Hide();
            }
        }
    }
}
