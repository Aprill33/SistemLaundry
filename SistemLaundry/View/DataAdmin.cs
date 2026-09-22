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
    public partial class DataAdmin : Form
    {
        LaundryController laundryController;
        public DataAdmin()
        {
            InitializeComponent();
            laundryController = new LaundryController();
        }
        private void DataAdmin_Load(object sender, EventArgs e)
        {
            TampilkanData();
        }

        void TampilkanData()
        {
            dgv_data_admin.DataSource = laundryController.TampilkanAdmin();

            dgv_data_admin.Columns["id_admin"].HeaderText = "ID";
            dgv_data_admin.Columns["username"].HeaderText = "Username";
            dgv_data_admin.Columns["PASSWORD"].HeaderText = "Password";
            dgv_data_admin.Columns["ROLE"].HeaderText = "Role";
            dgv_data_admin.Columns["STATUS"].HeaderText = "Status";

            dgv_data_admin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_data_admin.ReadOnly = true;
            dgv_data_admin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_aktifkan_Click(object sender, EventArgs e)
        {
            if (dgv_data_admin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data admin terlebih dahulu!");
                return;
            }

            int idAdmin = Convert.ToInt32(dgv_data_admin.SelectedRows[0].Cells["id_admin"].Value);
            string status = dgv_data_admin.SelectedRows[0].Cells["STATUS"].Value.ToString();

            if (status == "aktif")
            {
                MessageBox.Show("Admin sudah aktif!");
                return;
            }

            if (laundryController.AktifkanAdmin(idAdmin))
            {
                MessageBox.Show("Admin berhasil diaktifkan");
                TampilkanData();
            }
            else
            {
                MessageBox.Show("Gagal mengaktifkan admin");
            }
        }

        private void btn_perbarui_Click(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            MenuUtama mu = new MenuUtama();

            // Menyesuaikan ukuran layar (Maximize atau Normal)
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
            this.Hide();
        }

        private void btn_nonaktif_Click(object sender, EventArgs e)
        {
            if (dgv_data_admin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data admin/kasir terlebih dahulu!");
                return;
            }

            int idAdmin = Convert.ToInt32(dgv_data_admin.SelectedRows[0].Cells["id_admin"].Value);
            string status = dgv_data_admin.SelectedRows[0].Cells["STATUS"].Value.ToString();

            if (status == "nonaktif")
            {
                MessageBox.Show("Akun ini sudah berstatus nonaktif!");
                return;
            }

            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin menonaktifkan akun ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                if (laundryController.NonaktifkanAdmin(idAdmin))
                {
                    MessageBox.Show("Akun berhasil dinonaktifkan!");
                    TampilkanData();
                }
                else
                {
                    MessageBox.Show("Gagal menonaktifkan akun.");
                }
            }
        }
    }
}