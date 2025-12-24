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
using Guna.UI2.AnimatorNS;                                     // Library tambahan dari Guna UI (dipakai untuk animasi / UI modern)
using SistemLaundry.Controller;                                // Supaya Form bisa memanggil class Controller 

namespace SistemLaundry.View
{
    public partial class Masuk : Form
    {
        // Deklarasi objek controller (BELUM dibuat, baru disiapkan)
        LaundryController laundryController;                    // Dipakai untuk komunikasi ke database (login)
        ValidationController validationController;              // Dipakai untuk mengecek validasi username & password

        // Constructor akan dijalankan PERTAMA KALI saat Form Masuk dibuka
        public Masuk()
        {
            InitializeComponent();
            laundryController = new LaundryController();        // Membuat objek controller database
            validationController = new ValidationController();  // Membuat objek controller validasi
            txt_password.UseSystemPasswordChar = true;          // membuat password jadi tertutupi
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
                LaundryController.KasirAktif = username;  // username admin disimpan
                LaundryController.RoleAktif = "admin";     // role admin

                MessageBox.Show("Login admin berhasil");

                // Buka MenuUtama (admin)
                MenuUtama mu = new MenuUtama();
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
            awalProgram.Show();
            this.Hide();
        }
    }
}
