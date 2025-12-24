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
            masukAdmin.Show();
            this.Hide();
        }

        private void btn_kasir_Click(object sender, EventArgs e)
        {
            MasukKasir masukKasir = new MasukKasir();
            masukKasir.Show();
            this.Hide();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
