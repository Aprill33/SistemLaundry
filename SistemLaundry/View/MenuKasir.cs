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

            // Menyesuaikan ukuran layar (Maximize atau Normal)
            if (this.WindowState == FormWindowState.Maximized)
            {
                tambahPelanggan.WindowState = FormWindowState.Maximized;
            }
            else
            {
                tambahPelanggan.StartPosition = FormStartPosition.Manual;
                tambahPelanggan.Size = this.Size;
                tambahPelanggan.Location = this.Location;
            }

            tambahPelanggan.Show();
            this.Hide();
        }

        private void btn_tambah_transaksi_Click(object sender, EventArgs e)
        {
            TambahTransaksi tambahTransaksi = new TambahTransaksi();

            // Menyesuaikan ukuran layar (Maximize atau Normal)
            if (this.WindowState == FormWindowState.Maximized)
            {
                tambahTransaksi.WindowState = FormWindowState.Maximized;
            }
            else
            {
                tambahTransaksi.StartPosition = FormStartPosition.Manual;
                tambahTransaksi.Size = this.Size;
                tambahTransaksi.Location = this.Location;
            }

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

                // Menyesuaikan ukuran layar (Maximize atau Normal)
                if (this.WindowState == FormWindowState.Maximized)
                {
                    login.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    login.StartPosition = FormStartPosition.Manual;
                    login.Size = this.Size;
                    login.Location = this.Location;
                }

                login.Show();
                this.Hide();
            }
        }
    }
}