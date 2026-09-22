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
    public partial class DetailTransaksi : Form
    {
        LaundryController laundryController;
        LaundryController.ModeDetailTransaksi mode;

        public DetailTransaksi(
            string idTransaksi,
            LaundryController.ModeDetailTransaksi modeDetail
        )
        {
            InitializeComponent();
            laundryController = new LaundryController();
            mode = modeDetail;

            AturReadOnly();
            TampilkanData(idTransaksi);
        }

        private void TampilkanData(string idTransaksi)
        {
            DataTable dtLengkap =
                laundryController.AmbilDataTransaksiLengkap(idTransaksi);

            if (dtLengkap.Rows.Count == 0)
            {
                MessageBox.Show("Data transaksi tidak ditemukan");
                this.Close();
                return;
            }

            DataRow row = dtLengkap.Rows[0];

            txt_id_transaksi.Text = row["id_transaksi"].ToString();
            txt_nama_pelanggan.Text = row["nama_pelanggan"].ToString();
            dtp_tanggal_masuk.Value =
                Convert.ToDateTime(row["tanggal_masuk"]);
            dtp_estimasi_selesai.Value =
                Convert.ToDateTime(row["tanggal_selesai"]);
            txt_status_laundry.Text =
                row["status_laundry"].ToString();
            txt_status_pembayaran.Text =
                row["status_pembayaran"].ToString();
            txt_total.Text =
                row["total"].ToString();

            // Ditampilkan langsung agar nilai jumlah uang & kembalian selalu muncul
            txt_jumlah_uang.Text = row["uang_bayar"].ToString();
            txt_Kembalian.Text = row["kembalian"].ToString();

            dgv_detail_transaksi.DataSource =
                laundryController.GetDetailItemTransaksi(idTransaksi);
        }

        private void AturReadOnly()
        {
            txt_id_transaksi.ReadOnly = true;
            txt_nama_pelanggan.ReadOnly = true;
            txt_status_laundry.ReadOnly = true;
            txt_status_pembayaran.ReadOnly = true;
            txt_total.ReadOnly = true;
            txt_jumlah_uang.ReadOnly = true;
            txt_Kembalian.ReadOnly = true;

            dtp_tanggal_masuk.Enabled = false;
            dtp_estimasi_selesai.Enabled = false;

            dgv_detail_transaksi.ReadOnly = true;
            dgv_detail_transaksi.AllowUserToAddRows = false;
        }

        private void btn_Tutup_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailTransaksi_Load(object sender, EventArgs e)
        {
        }

        private void lbl_total_Click(object sender, EventArgs e)
        {
        }

        private void txt_jumlah_uang_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Kembalian_TextChanged(object sender, EventArgs e)
        {
        }
    }
}