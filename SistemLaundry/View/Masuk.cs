using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using SistemLaundry.Controller;

namespace SistemLaundry.View
{
    public partial class Masuk : Form
    {
        LaundryController laundryController;
        ValidationController validationController;

        public Masuk()
        {
            InitializeComponent();
            laundryController = new LaundryController();
            validationController = new ValidationController();
            txt_password.UseSystemPasswordChar = true;
        }

        private void Masuk_Load(object sender, EventArgs e)
        {
            txt_username.MaxLength = 6;
            txt_password.MaxLength = 6;
        }

        private void btn_masuk_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            // Validasi input
            if (!validationController.ValidasiUsername(username)) return;
            if (!validationController.ValidasiPassword(password)) return;

            // Login admin
            if (laundryController.LoginAdmin(username, password))
            {
                // Set session admin
                LaundryController.KasirAktif = username;
                LaundryController.RoleAktif = "admin";

                MessageBox.Show("Login admin berhasil");

                // Buka MenuUtama (admin)
                MenuUtama mu = new MenuUtama();

                // Menyesuaikan ukuran layar (Maximized atau Normal)
                if (this.WindowState == FormWindowState.Maximized)
                {
                    mu.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    mu.StartPosition = FormStartPosition.Manual;
                    mu.Size = this.Size;
                    mu.Location = this.Location;
                }

                mu.Show();

                // Tutup form login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password admin salah!");
            }
        }

        private void checkBox_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !checkBox_show_pass.Checked;
        }
        private void panel_masuk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            AwalProgram awalProgram = new AwalProgram();

            // Menyesuaikan ukuran layar (Maximized atau Normal)
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
    }
}