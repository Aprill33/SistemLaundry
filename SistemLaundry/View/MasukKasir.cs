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
    public partial class MasukKasir : Form
    {
        LaundryController laundryController;
        ValidationController validationController;
        public MasukKasir()
        {
            InitializeComponent();
            laundryController = new LaundryController();
            validationController = new ValidationController();

            txt_password.UseSystemPasswordChar = true;
        }

        private void btn_masuk_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (!validationController.ValidasiUsername(username)) return;
            if (!validationController.ValidasiPassword(password)) return;

            int hasil = laundryController.LoginKasir(username, password);

            if (hasil == 1)
            {
                LaundryController.KasirAktif = username;
                LaundryController.RoleAktif = "kasir";

                MessageBox.Show("Login kasir berhasil");
                MenuKasir mk = new MenuKasir();

                // Menyesuaikan ukuran layar (Maximize atau Normal)
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
                this.Hide();
            }
            else if (hasil == 2)
            {
                MessageBox.Show("Akun belum diaktifkan admin!");
            }
            else
            {
                MessageBox.Show("Username atau password salah!\nSilahkan daftar terlebih dahulu jika tidak memiliki akun.");
            }
        }

        private void btn_daftar_Click(object sender, EventArgs e)
        {
            DaftarKasir daftarKasir = new DaftarKasir();

            // Menyesuaikan ukuran layar (Maximize atau Normal)
            if (this.WindowState == FormWindowState.Maximized)
            {
                daftarKasir.WindowState = FormWindowState.Maximized;
            }
            else
            {
                daftarKasir.StartPosition = FormStartPosition.Manual;
                daftarKasir.Size = this.Size;
                daftarKasir.Location = this.Location;
            }

            daftarKasir.Show();
            this.Hide();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            AwalProgram awalProgram = new AwalProgram();

            // Menyesuaikan ukuran layar (Maximize atau Normal)
            if (this.WindowState == FormWindowState.Maximized)
            {
                awalProgram.WindowState = FormWindowState.Maximized;
            }
            else
            {
                awalProgram.StartPosition = FormStartPosition.Manual;
                awalProgram.Size = this.Size;
                awalProgram.Location = this.Location;
            }

            awalProgram.Show();
            this.Hide();
        }

        private void cbx_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !cbx_show_pass.Checked;
        }

        private void MasukKasir_Load(object sender, EventArgs e)
        {

        }
    }
}