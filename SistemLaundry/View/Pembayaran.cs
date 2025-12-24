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
    public partial class Pembayaran : Form
    {
        LaundryController laundryController;
        ValidationController validation;

        public Pembayaran()
        {
            InitializeComponent();
            laundryController = new LaundryController();
            validation = new ValidationController();
        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {
            txt_id_transaksi.Text = TambahTransaksi.IdTransaksiAktif;
            txt_nama_pelanggan.Text = TambahTransaksi.NamaPelangganAktif;
            txt_total.Text = TambahTransaksi.TotalTransaksi.ToString();

            txt_id_transaksi.ReadOnly = true;
            txt_nama_pelanggan.ReadOnly = true;
            txt_total.ReadOnly = true;
            txt_kembalian.ReadOnly = true;

            btn_bayar.Enabled = false;

        }

        private void txt_input_uang_TextChanged(object sender, EventArgs e)
        {
            // Validasi input angka
            if (!int.TryParse(txt_input_uang.Text, out int uang))
            {
                txt_kembalian.Text = "0";
                btn_bayar.Enabled = false;
                return;
            }

            int total = TambahTransaksi.TotalTransaksi;
            int kembali = uang - total;

            if (kembali < 0)
            {
                // Jika uang kurang
                txt_kembalian.Text = "0";
                btn_bayar.Enabled = false;
            }
            else
            {
                // Jika uang cukup atau pas
                txt_kembalian.Text = kembali.ToString();
                btn_bayar.Enabled = true;
            }
        }

        private void btn_bayar_Click(object sender, EventArgs e)
        {
            TambahTransaksi.SudahBayar = true;
            // Simpan nilai ke variabel statis di TambahTransaksi
            TambahTransaksi.UangBayarAktif = int.Parse(txt_input_uang.Text);
            TambahTransaksi.KembalianAktif = int.Parse(txt_kembalian.Text);

            MessageBox.Show("Pembayaran berhasil!");
            this.Close();


        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_pembayaran_Click(object sender, EventArgs e)
        {

        }

        private void panel_input_uang_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}