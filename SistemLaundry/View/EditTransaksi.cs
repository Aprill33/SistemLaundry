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
    public partial class EditTransaksi : Form
    {
        LaundryController laundryController;
        ValidationController validation;
        public EditTransaksi(DataRow row)
        {
            InitializeComponent();
            laundryController = new LaundryController();
            validation = new ValidationController();

            txt_id_transaksi.Text = row["id_transaksi"].ToString();
            txt_id_pelanggan.Text = row["id_pelanggan"].ToString();
            dtp_tanggal_masuk.Value = Convert.ToDateTime(row["tanggal_masuk"]);
            dtp_tgl_selesai.Value = Convert.ToDateTime(row["tanggal_selesai"]);
            txt_status_bayar.Text = row["status_pembayaran"].ToString();
            txt_status_laundry.Text = row["status_laundry"].ToString();
            txt_total.Text = row["total"].ToString();
            txt_jumlah_uang.Text = row["uang_bayar"].ToString();
            txt_kembalian.Text = row["kembalian"].ToString();

            // Proteksi: Hanya status laundry yang bisa diedit
            txt_id_transaksi.ReadOnly = true;
            txt_id_pelanggan.ReadOnly = true;
            txt_status_bayar.ReadOnly = true;
            txt_total.ReadOnly = true;
            txt_jumlah_uang.ReadOnly = true;
            txt_kembalian.ReadOnly = true;
            dtp_tanggal_masuk.Enabled = false;
            dtp_tgl_selesai.Enabled = false;

            // Pastikan txt_status_laundry aktif
            txt_status_laundry.ReadOnly = false;
        }
        

        private void EditTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            Transaksi t = new Transaksi();
            t.Show();
            this.Close(); // Menutup form edit
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            string id = txt_id_transaksi.Text;
            string status = txt_status_laundry.Text;

            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Status tidak boleh kosong!");
                return;
            }

            if (laundryController.UpdateStatusLaundry(id, status))
            {
                MessageBox.Show("Data Berhasil Disimpan!");
                btn_kembali_Click(sender, e); // Otomatis kembali ke form transaksi
            }
        }
    }
}
