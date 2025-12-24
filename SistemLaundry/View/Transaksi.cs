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
    public partial class Transaksi : Form
    {
        LaundryController laundryController;
        public Transaksi()
        {
            InitializeComponent();
            laundryController = new LaundryController();
        }
        private void Transaksi_Load(object sender, EventArgs e)
        {
            LoadTransaksi();
        }

        void LoadTransaksi()
        {
            DataTable dt = laundryController.TampilkanTransaksi();
            dgv_transaksi.DataSource = dt;
            dgv_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btn_tambah_transaksi_Click(object sender, EventArgs e)
        {
            TambahTransaksi tambahTransaksi = new TambahTransaksi();
            tambahTransaksi.Show();
            this.Hide();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            MenuUtama menuUtama = new MenuUtama();
            menuUtama.Show();
            this.Hide();

        }

        private void btn_edit_status_Click(object sender, EventArgs e)
        {
            if (dgv_transaksi.CurrentRow != null)
            {
                DataRowView rowView =
                    (DataRowView)dgv_transaksi.CurrentRow.DataBoundItem;

                DataRow selectedRow = rowView.Row;

               
                string statusLaundry = selectedRow["status_laundry"].ToString();

                
                if (statusLaundry != "Proses")
                {
                    MessageBox.Show(
                        "Status laundry hanya bisa diedit saat masih PROSES!",
                        "Akses Ditolak",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                
                EditTransaksi editTransaksi = new EditTransaksi(selectedRow);
                editTransaksi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Silahkan pilih data transaksi terlebih dahulu!");
            }
            
        }

        private void txt_pencarian_TextChanged(object sender, EventArgs e)
        {
            dgv_transaksi.DataSource = laundryController.SearchTransaksi(txt_pencarian.Text);
        }

        private void btn_detail_transaksi_Click(object sender, EventArgs e)
        {
            if (dgv_transaksi.CurrentRow != null)
            {
                DataRowView rowView =
                    (DataRowView)dgv_transaksi.CurrentRow.DataBoundItem;

                string idTransaksi = rowView["id_transaksi"].ToString();

                DetailTransaksi detail = new DetailTransaksi(
                    idTransaksi,
                    LaundryController.ModeDetailTransaksi.Admin
                );
                detail.Show();
                
            }
            else
            {
                MessageBox.Show("Silahkan pilih data transaksi di tabel terlebih dahulu!");
            }
        }

        private void dgv_transaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_transaksi.CurrentRow != null)
            {
                DataRowView rowView =
                    (DataRowView)dgv_transaksi.CurrentRow.DataBoundItem;

                string status = rowView["status_laundry"].ToString();

                btn_edit_status.Enabled = (status == "Proses");
            }
        }
    }
}
