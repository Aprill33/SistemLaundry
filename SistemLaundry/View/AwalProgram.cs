using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemLaundry.View
{
    public partial class AwalProgram : Form
    {
        public AwalProgram()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Masuk masukAdmin = new Masuk();

            // Mengecek ukuran layar AwalProgram saat ini
            if (this.WindowState == FormWindowState.Maximized)
            {
                masukAdmin.WindowState = FormWindowState.Maximized;
            }
            else
            {
                masukAdmin.WindowState = FormWindowState.Normal;
            }

            masukAdmin.Show();
            this.Hide();
        }

        private void btn_kasir_Click(object sender, EventArgs e)
        {
            MasukKasir masukKasir = new MasukKasir();

            // Mengecek ukuran layar AwalProgram saat ini
            if (this.WindowState == FormWindowState.Maximized)
            {
                masukKasir.WindowState = FormWindowState.Maximized;
            }
            else
            {
                masukKasir.WindowState = FormWindowState.Normal;
            }

            masukKasir.Show();
            this.Hide();
        }
        private void btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AwalProgram_Load(object sender, EventArgs e)
        {

        }
    }
}
