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
                mk.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal mendaftar akun kasir");
            }
        }
    }
}
