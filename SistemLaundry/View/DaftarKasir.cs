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
    public partial class DaftarKasir : Form
    {
        LaundryController laundryController;
        public DaftarKasir()
        {
            InitializeComponent();
            laundryController = new LaundryController();
            txt_password.UseSystemPasswordChar = true; // Menyembunyikan password secara default
        }

        private void DaftarKasir_Load(object sender, EventArgs e)
        {
            txt_username.MaxLength = 6;
            txt_password.MaxLength = 6;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            ValidationController val = new ValidationController();
            if (!val.ValidasiUsername(username)) return;
            if (!val.ValidasiPassword(password)) return;

            if (laundryController.DaftarKasir(username, password))
            {
                MessageBox.Show(
                    "Pendaftaran berhasil!\nSilahkan tunggu admin mengaktifkan akun Anda.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                MasukKasir mk = new MasukKasir();

                // Mempertahankan status ukuran layar (Maximize / Normal)
                if (this.WindowState == FormWindowState.Maximized)
                {
                    mk.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    mk.StartPosition = FormStartPosition.Manual;
                    mk.Size = this.Size;
                    mk.Location = this.Location;
                }

                mk.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal mendaftar akun kasir");
            }
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            MasukKasir masukKasir = new MasukKasir();

            // Mempertahankan status ukuran layar (Maximize / Normal)
            if (this.WindowState == FormWindowState.Maximized)
            {
                masukKasir.WindowState = FormWindowState.Maximized;
            }
            else
            {
                masukKasir.StartPosition = FormStartPosition.Manual;
                masukKasir.Size = this.Size;
                masukKasir.Location = this.Location;
            }

            masukKasir.Show();
            this.Close();
        }

        private void checkBox_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            // Logika untuk menampilkan atau menyembunyikan password
            txt_password.UseSystemPasswordChar = !checkBox_show_pass.Checked;
        }
    }
}