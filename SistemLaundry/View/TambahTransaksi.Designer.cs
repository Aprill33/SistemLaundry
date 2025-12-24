namespace SistemLaundry.View
{
    partial class TambahTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_atas_transaksi = new System.Windows.Forms.Panel();
            this.btn_keluar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_tambah_transaksi = new System.Windows.Forms.Label();
            this.ShadowPanel_input_data_transaksi = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txt_jumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtp_tanggal_selesai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_tgl_selesai = new System.Windows.Forms.Label();
            this.lbl_harga = new System.Windows.Forms.Label();
            this.lbl_jumlah = new System.Windows.Forms.Label();
            this.txt_total = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_harga = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtp_tanggal_masuk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbx_nama_layanan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbx_jenis_layanan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_status_pembayaran = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_status_laundry = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_id_transaksi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_status_pembayaran = new System.Windows.Forms.Label();
            this.lbl_status_laundry = new System.Windows.Forms.Label();
            this.lbl_jenis_layanan = new System.Windows.Forms.Label();
            this.lbl_tgl_masuk = new System.Windows.Forms.Label();
            this.lbl_layanan = new System.Windows.Forms.Label();
            this.lbl_nama_pelanggan = new System.Windows.Forms.Label();
            this.lbl_id_transaksi = new System.Windows.Forms.Label();
            this.panel_bawah = new System.Windows.Forms.Panel();
            this.panel_dgv_detail_transaksi = new System.Windows.Forms.Panel();
            this.dgv_detail_transaksi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_button = new System.Windows.Forms.Panel();
            this.btn_kembali = new Guna.UI2.WinForms.Guna2Button();
            this.btn_simpan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tambah_layanan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_bayar = new Guna.UI2.WinForms.Guna2Button();
            this.cbx_nama_pelanggan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_detail_transaksi = new Guna.UI2.WinForms.Guna2Button();
            this.panel_atas_transaksi.SuspendLayout();
            this.ShadowPanel_input_data_transaksi.SuspendLayout();
            this.panel_bawah.SuspendLayout();
            this.panel_dgv_detail_transaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail_transaksi)).BeginInit();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_atas_transaksi
            // 
            this.panel_atas_transaksi.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_atas_transaksi.Controls.Add(this.btn_keluar);
            this.panel_atas_transaksi.Controls.Add(this.lbl_tambah_transaksi);
            this.panel_atas_transaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_atas_transaksi.Location = new System.Drawing.Point(0, 0);
            this.panel_atas_transaksi.Name = "panel_atas_transaksi";
            this.panel_atas_transaksi.Size = new System.Drawing.Size(1248, 64);
            this.panel_atas_transaksi.TabIndex = 0;
            // 
            // btn_keluar
            // 
            this.btn_keluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_keluar.BackColor = System.Drawing.Color.Transparent;
            this.btn_keluar.BorderColor = System.Drawing.Color.Maroon;
            this.btn_keluar.BorderRadius = 5;
            this.btn_keluar.BorderThickness = 2;
            this.btn_keluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_keluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_keluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_keluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_keluar.FillColor = System.Drawing.Color.White;
            this.btn_keluar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_keluar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_keluar.Location = new System.Drawing.Point(1194, 8);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(44, 43);
            this.btn_keluar.TabIndex = 11;
            this.btn_keluar.Text = "X";
            // 
            // lbl_tambah_transaksi
            // 
            this.lbl_tambah_transaksi.AutoSize = true;
            this.lbl_tambah_transaksi.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tambah_transaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_tambah_transaksi.Location = new System.Drawing.Point(28, 18);
            this.lbl_tambah_transaksi.Name = "lbl_tambah_transaksi";
            this.lbl_tambah_transaksi.Size = new System.Drawing.Size(258, 33);
            this.lbl_tambah_transaksi.TabIndex = 5;
            this.lbl_tambah_transaksi.Text = "Tambah Transaksi";
            // 
            // ShadowPanel_input_data_transaksi
            // 
            this.ShadowPanel_input_data_transaksi.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.txt_jumlah);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.dtp_tanggal_selesai);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.lbl_tgl_selesai);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.lbl_harga);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.lbl_jumlah);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.txt_total);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.txt_harga);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.dtp_tanggal_masuk);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.cbx_nama_layanan);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.cbx_jenis_layanan);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.txt_status_pembayaran);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.txt_status_laundry);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.cbx_nama_pelanggan);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.txt_id_transaksi);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.lbl_total);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.lbl_status_pembayaran);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.lbl_status_laundry);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.lbl_jenis_layanan);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.lbl_tgl_masuk);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.lbl_layanan);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.lbl_nama_pelanggan);
            this.ShadowPanel_input_data_transaksi.Controls.Add(this.lbl_id_transaksi);
            this.ShadowPanel_input_data_transaksi.FillColor = System.Drawing.Color.White;
            this.ShadowPanel_input_data_transaksi.Location = new System.Drawing.Point(48, 70);
            this.ShadowPanel_input_data_transaksi.Name = "ShadowPanel_input_data_transaksi";
            this.ShadowPanel_input_data_transaksi.ShadowColor = System.Drawing.Color.Black;
            this.ShadowPanel_input_data_transaksi.Size = new System.Drawing.Size(1148, 390);
            this.ShadowPanel_input_data_transaksi.TabIndex = 1;
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.BorderRadius = 5;
            this.txt_jumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_jumlah.DefaultText = "";
            this.txt_jumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_jumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_jumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jumlah.FillColor = System.Drawing.Color.Pink;
            this.txt_jumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jumlah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_jumlah.ForeColor = System.Drawing.Color.DimGray;
            this.txt_jumlah.HoverState.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txt_jumlah.Location = new System.Drawing.Point(832, 219);
            this.txt_jumlah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.PlaceholderText = "";
            this.txt_jumlah.SelectedText = "";
            this.txt_jumlah.Size = new System.Drawing.Size(283, 36);
            this.txt_jumlah.TabIndex = 22;
            // 
            // dtp_tanggal_selesai
            // 
            this.dtp_tanggal_selesai.Checked = true;
            this.dtp_tanggal_selesai.FillColor = System.Drawing.Color.Pink;
            this.dtp_tanggal_selesai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_tanggal_selesai.ForeColor = System.Drawing.Color.White;
            this.dtp_tanggal_selesai.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_tanggal_selesai.Location = new System.Drawing.Point(261, 205);
            this.dtp_tanggal_selesai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_tanggal_selesai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_tanggal_selesai.Name = "dtp_tanggal_selesai";
            this.dtp_tanggal_selesai.Size = new System.Drawing.Size(283, 36);
            this.dtp_tanggal_selesai.TabIndex = 21;
            this.dtp_tanggal_selesai.Value = new System.DateTime(2025, 12, 19, 21, 46, 33, 679);
            // 
            // lbl_tgl_selesai
            // 
            this.lbl_tgl_selesai.AutoSize = true;
            this.lbl_tgl_selesai.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tgl_selesai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_tgl_selesai.Location = new System.Drawing.Point(35, 220);
            this.lbl_tgl_selesai.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_tgl_selesai.Name = "lbl_tgl_selesai";
            this.lbl_tgl_selesai.Size = new System.Drawing.Size(197, 21);
            this.lbl_tgl_selesai.TabIndex = 20;
            this.lbl_tgl_selesai.Text = "Estimasi Selesai       :";
            // 
            // lbl_harga
            // 
            this.lbl_harga.AutoSize = true;
            this.lbl_harga.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_harga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_harga.Location = new System.Drawing.Point(639, 181);
            this.lbl_harga.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_harga.Name = "lbl_harga";
            this.lbl_harga.Size = new System.Drawing.Size(187, 21);
            this.lbl_harga.TabIndex = 19;
            this.lbl_harga.Text = "Harga                    :";
            // 
            // lbl_jumlah
            // 
            this.lbl_jumlah.AutoSize = true;
            this.lbl_jumlah.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jumlah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_jumlah.Location = new System.Drawing.Point(639, 234);
            this.lbl_jumlah.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_jumlah.Name = "lbl_jumlah";
            this.lbl_jumlah.Size = new System.Drawing.Size(186, 21);
            this.lbl_jumlah.TabIndex = 5;
            this.lbl_jumlah.Text = "Jumlah                  :";
            // 
            // txt_total
            // 
            this.txt_total.BorderRadius = 5;
            this.txt_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_total.DefaultText = "";
            this.txt_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_total.FillColor = System.Drawing.Color.Pink;
            this.txt_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_total.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_total.ForeColor = System.Drawing.Color.DimGray;
            this.txt_total.HoverState.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txt_total.Location = new System.Drawing.Point(828, 326);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_total.Name = "txt_total";
            this.txt_total.PlaceholderText = "";
            this.txt_total.SelectedText = "";
            this.txt_total.Size = new System.Drawing.Size(283, 36);
            this.txt_total.TabIndex = 18;
            // 
            // txt_harga
            // 
            this.txt_harga.BorderRadius = 5;
            this.txt_harga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_harga.DefaultText = "";
            this.txt_harga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_harga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_harga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_harga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_harga.FillColor = System.Drawing.Color.Pink;
            this.txt_harga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_harga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_harga.ForeColor = System.Drawing.Color.DimGray;
            this.txt_harga.HoverState.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txt_harga.Location = new System.Drawing.Point(832, 166);
            this.txt_harga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.PlaceholderText = "";
            this.txt_harga.ReadOnly = true;
            this.txt_harga.SelectedText = "";
            this.txt_harga.Size = new System.Drawing.Size(283, 36);
            this.txt_harga.TabIndex = 17;
            // 
            // dtp_tanggal_masuk
            // 
            this.dtp_tanggal_masuk.Checked = true;
            this.dtp_tanggal_masuk.FillColor = System.Drawing.Color.Pink;
            this.dtp_tanggal_masuk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_tanggal_masuk.ForeColor = System.Drawing.Color.White;
            this.dtp_tanggal_masuk.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_tanggal_masuk.Location = new System.Drawing.Point(261, 151);
            this.dtp_tanggal_masuk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_tanggal_masuk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_tanggal_masuk.Name = "dtp_tanggal_masuk";
            this.dtp_tanggal_masuk.Size = new System.Drawing.Size(283, 36);
            this.dtp_tanggal_masuk.TabIndex = 16;
            this.dtp_tanggal_masuk.Value = new System.DateTime(2025, 12, 19, 21, 46, 33, 679);
            // 
            // cbx_nama_layanan
            // 
            this.cbx_nama_layanan.BackColor = System.Drawing.Color.Transparent;
            this.cbx_nama_layanan.BorderRadius = 2;
            this.cbx_nama_layanan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_nama_layanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_nama_layanan.FillColor = System.Drawing.Color.Pink;
            this.cbx_nama_layanan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_nama_layanan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_nama_layanan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_nama_layanan.ForeColor = System.Drawing.Color.DimGray;
            this.cbx_nama_layanan.ItemHeight = 30;
            this.cbx_nama_layanan.Location = new System.Drawing.Point(828, 95);
            this.cbx_nama_layanan.Name = "cbx_nama_layanan";
            this.cbx_nama_layanan.Size = new System.Drawing.Size(283, 36);
            this.cbx_nama_layanan.TabIndex = 15;
            // 
            // cbx_jenis_layanan
            // 
            this.cbx_jenis_layanan.BackColor = System.Drawing.Color.Transparent;
            this.cbx_jenis_layanan.BorderRadius = 2;
            this.cbx_jenis_layanan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_jenis_layanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_jenis_layanan.FillColor = System.Drawing.Color.Pink;
            this.cbx_jenis_layanan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_jenis_layanan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_jenis_layanan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_jenis_layanan.ForeColor = System.Drawing.Color.DimGray;
            this.cbx_jenis_layanan.ItemHeight = 30;
            this.cbx_jenis_layanan.Location = new System.Drawing.Point(828, 25);
            this.cbx_jenis_layanan.Name = "cbx_jenis_layanan";
            this.cbx_jenis_layanan.Size = new System.Drawing.Size(283, 36);
            this.cbx_jenis_layanan.TabIndex = 14;
            // 
            // txt_status_pembayaran
            // 
            this.txt_status_pembayaran.BorderRadius = 5;
            this.txt_status_pembayaran.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_status_pembayaran.DefaultText = "";
            this.txt_status_pembayaran.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_status_pembayaran.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_status_pembayaran.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_status_pembayaran.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_status_pembayaran.FillColor = System.Drawing.Color.Pink;
            this.txt_status_pembayaran.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_status_pembayaran.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_status_pembayaran.ForeColor = System.Drawing.Color.DimGray;
            this.txt_status_pembayaran.HoverState.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txt_status_pembayaran.Location = new System.Drawing.Point(261, 311);
            this.txt_status_pembayaran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_status_pembayaran.Name = "txt_status_pembayaran";
            this.txt_status_pembayaran.PlaceholderText = "";
            this.txt_status_pembayaran.SelectedText = "";
            this.txt_status_pembayaran.Size = new System.Drawing.Size(283, 36);
            this.txt_status_pembayaran.TabIndex = 13;
            // 
            // txt_status_laundry
            // 
            this.txt_status_laundry.BorderRadius = 5;
            this.txt_status_laundry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_status_laundry.DefaultText = "";
            this.txt_status_laundry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_status_laundry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_status_laundry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_status_laundry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_status_laundry.FillColor = System.Drawing.Color.Pink;
            this.txt_status_laundry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_status_laundry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_status_laundry.ForeColor = System.Drawing.Color.DimGray;
            this.txt_status_laundry.HoverState.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txt_status_laundry.Location = new System.Drawing.Point(261, 258);
            this.txt_status_laundry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_status_laundry.Name = "txt_status_laundry";
            this.txt_status_laundry.PlaceholderText = "";
            this.txt_status_laundry.SelectedText = "";
            this.txt_status_laundry.Size = new System.Drawing.Size(283, 36);
            this.txt_status_laundry.TabIndex = 12;
            // 
            // txt_id_transaksi
            // 
            this.txt_id_transaksi.BorderRadius = 5;
            this.txt_id_transaksi.BorderThickness = 2;
            this.txt_id_transaksi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_transaksi.DefaultText = "";
            this.txt_id_transaksi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id_transaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id_transaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id_transaksi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id_transaksi.FillColor = System.Drawing.Color.Pink;
            this.txt_id_transaksi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id_transaksi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id_transaksi.ForeColor = System.Drawing.Color.DimGray;
            this.txt_id_transaksi.HoverState.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txt_id_transaksi.Location = new System.Drawing.Point(261, 25);
            this.txt_id_transaksi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id_transaksi.Name = "txt_id_transaksi";
            this.txt_id_transaksi.PlaceholderText = "";
            this.txt_id_transaksi.SelectedText = "";
            this.txt_id_transaksi.Size = new System.Drawing.Size(166, 36);
            this.txt_id_transaksi.TabIndex = 10;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_total.Location = new System.Drawing.Point(644, 341);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(181, 21);
            this.lbl_total.TabIndex = 9;
            this.lbl_total.Text = "Total                    :";
            // 
            // lbl_status_pembayaran
            // 
            this.lbl_status_pembayaran.AutoSize = true;
            this.lbl_status_pembayaran.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_pembayaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_status_pembayaran.Location = new System.Drawing.Point(35, 326);
            this.lbl_status_pembayaran.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_status_pembayaran.Name = "lbl_status_pembayaran";
            this.lbl_status_pembayaran.Size = new System.Drawing.Size(199, 21);
            this.lbl_status_pembayaran.TabIndex = 8;
            this.lbl_status_pembayaran.Text = "Status Pembayaran   :";
            // 
            // lbl_status_laundry
            // 
            this.lbl_status_laundry.AutoSize = true;
            this.lbl_status_laundry.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_laundry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_status_laundry.Location = new System.Drawing.Point(35, 273);
            this.lbl_status_laundry.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_status_laundry.Name = "lbl_status_laundry";
            this.lbl_status_laundry.Size = new System.Drawing.Size(197, 21);
            this.lbl_status_laundry.TabIndex = 7;
            this.lbl_status_laundry.Text = "Status Laundry        :";
            // 
            // lbl_jenis_layanan
            // 
            this.lbl_jenis_layanan.AutoSize = true;
            this.lbl_jenis_layanan.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jenis_layanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_jenis_layanan.Location = new System.Drawing.Point(637, 40);
            this.lbl_jenis_layanan.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_jenis_layanan.Name = "lbl_jenis_layanan";
            this.lbl_jenis_layanan.Size = new System.Drawing.Size(185, 21);
            this.lbl_jenis_layanan.TabIndex = 6;
            this.lbl_jenis_layanan.Text = "Jenis Layanan        :";
            // 
            // lbl_tgl_masuk
            // 
            this.lbl_tgl_masuk.AutoSize = true;
            this.lbl_tgl_masuk.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tgl_masuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_tgl_masuk.Location = new System.Drawing.Point(32, 166);
            this.lbl_tgl_masuk.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_tgl_masuk.Name = "lbl_tgl_masuk";
            this.lbl_tgl_masuk.Size = new System.Drawing.Size(200, 21);
            this.lbl_tgl_masuk.TabIndex = 4;
            this.lbl_tgl_masuk.Text = "Tanggal Masuk         :";
            // 
            // lbl_layanan
            // 
            this.lbl_layanan.AutoSize = true;
            this.lbl_layanan.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_layanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_layanan.Location = new System.Drawing.Point(635, 110);
            this.lbl_layanan.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_layanan.Name = "lbl_layanan";
            this.lbl_layanan.Size = new System.Drawing.Size(190, 21);
            this.lbl_layanan.TabIndex = 3;
            this.lbl_layanan.Text = "Layanan                : ";
            // 
            // lbl_nama_pelanggan
            // 
            this.lbl_nama_pelanggan.AutoSize = true;
            this.lbl_nama_pelanggan.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama_pelanggan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_nama_pelanggan.Location = new System.Drawing.Point(37, 95);
            this.lbl_nama_pelanggan.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_nama_pelanggan.Name = "lbl_nama_pelanggan";
            this.lbl_nama_pelanggan.Size = new System.Drawing.Size(201, 21);
            this.lbl_nama_pelanggan.TabIndex = 2;
            this.lbl_nama_pelanggan.Text = "Nama Pelanggan       :";
            // 
            // lbl_id_transaksi
            // 
            this.lbl_id_transaksi.AutoSize = true;
            this.lbl_id_transaksi.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_transaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_id_transaksi.Location = new System.Drawing.Point(35, 40);
            this.lbl_id_transaksi.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_id_transaksi.Name = "lbl_id_transaksi";
            this.lbl_id_transaksi.Size = new System.Drawing.Size(201, 21);
            this.lbl_id_transaksi.TabIndex = 1;
            this.lbl_id_transaksi.Text = "Id Transaksi             :";
            // 
            // panel_bawah
            // 
            this.panel_bawah.Controls.Add(this.panel_dgv_detail_transaksi);
            this.panel_bawah.Controls.Add(this.panel_button);
            this.panel_bawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bawah.Location = new System.Drawing.Point(0, 466);
            this.panel_bawah.Name = "panel_bawah";
            this.panel_bawah.Size = new System.Drawing.Size(1248, 258);
            this.panel_bawah.TabIndex = 2;
            // 
            // panel_dgv_detail_transaksi
            // 
            this.panel_dgv_detail_transaksi.Controls.Add(this.dgv_detail_transaksi);
            this.panel_dgv_detail_transaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dgv_detail_transaksi.Location = new System.Drawing.Point(0, 63);
            this.panel_dgv_detail_transaksi.Name = "panel_dgv_detail_transaksi";
            this.panel_dgv_detail_transaksi.Size = new System.Drawing.Size(1248, 195);
            this.panel_dgv_detail_transaksi.TabIndex = 5;
            // 
            // dgv_detail_transaksi
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_detail_transaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detail_transaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_detail_transaksi.ColumnHeadersHeight = 40;
            this.dgv_detail_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detail_transaksi.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_detail_transaksi.GridColor = System.Drawing.Color.HotPink;
            this.dgv_detail_transaksi.Location = new System.Drawing.Point(67, 6);
            this.dgv_detail_transaksi.Name = "dgv_detail_transaksi";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detail_transaksi.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_detail_transaksi.RowHeadersVisible = false;
            this.dgv_detail_transaksi.RowHeadersWidth = 62;
            this.dgv_detail_transaksi.RowTemplate.Height = 28;
            this.dgv_detail_transaksi.Size = new System.Drawing.Size(1115, 177);
            this.dgv_detail_transaksi.TabIndex = 3;
            this.dgv_detail_transaksi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_detail_transaksi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_detail_transaksi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.HotPink;
            this.dgv_detail_transaksi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_detail_transaksi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_detail_transaksi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_detail_transaksi.ThemeStyle.GridColor = System.Drawing.Color.HotPink;
            this.dgv_detail_transaksi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.HotPink;
            this.dgv_detail_transaksi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_detail_transaksi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_detail_transaksi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_detail_transaksi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_detail_transaksi.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_detail_transaksi.ThemeStyle.ReadOnly = false;
            this.dgv_detail_transaksi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_detail_transaksi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_detail_transaksi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_detail_transaksi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_detail_transaksi.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_detail_transaksi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_detail_transaksi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.btn_detail_transaksi);
            this.panel_button.Controls.Add(this.btn_kembali);
            this.panel_button.Controls.Add(this.btn_simpan);
            this.panel_button.Controls.Add(this.btn_tambah_layanan);
            this.panel_button.Controls.Add(this.btn_bayar);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_button.Location = new System.Drawing.Point(0, 0);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(1248, 63);
            this.panel_button.TabIndex = 4;
            // 
            // btn_kembali
            // 
            this.btn_kembali.BorderColor = System.Drawing.Color.RosyBrown;
            this.btn_kembali.BorderRadius = 5;
            this.btn_kembali.BorderThickness = 2;
            this.btn_kembali.CustomBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_kembali.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.btn_kembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_kembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_kembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_kembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_kembali.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_kembali.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.ForeColor = System.Drawing.Color.White;
            this.btn_kembali.HoverState.FillColor = System.Drawing.Color.Pink;
            this.btn_kembali.Location = new System.Drawing.Point(23, 7);
            this.btn_kembali.Margin = new System.Windows.Forms.Padding(3, 5, 15, 5);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(137, 48);
            this.btn_kembali.TabIndex = 11;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.BorderColor = System.Drawing.Color.RosyBrown;
            this.btn_simpan.BorderRadius = 5;
            this.btn_simpan.BorderThickness = 2;
            this.btn_simpan.CustomBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_simpan.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.btn_simpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_simpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_simpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_simpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_simpan.FillColor = System.Drawing.Color.IndianRed;
            this.btn_simpan.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.HoverState.FillColor = System.Drawing.Color.Pink;
            this.btn_simpan.Location = new System.Drawing.Point(748, 5);
            this.btn_simpan.Margin = new System.Windows.Forms.Padding(3, 5, 15, 5);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(137, 48);
            this.btn_simpan.TabIndex = 9;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_tambah_layanan
            // 
            this.btn_tambah_layanan.BorderColor = System.Drawing.Color.RosyBrown;
            this.btn_tambah_layanan.BorderRadius = 5;
            this.btn_tambah_layanan.BorderThickness = 2;
            this.btn_tambah_layanan.CustomBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_tambah_layanan.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.btn_tambah_layanan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tambah_layanan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tambah_layanan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tambah_layanan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tambah_layanan.FillColor = System.Drawing.Color.PaleVioletRed;
            this.btn_tambah_layanan.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah_layanan.ForeColor = System.Drawing.Color.White;
            this.btn_tambah_layanan.HoverState.FillColor = System.Drawing.Color.Pink;
            this.btn_tambah_layanan.Location = new System.Drawing.Point(229, 7);
            this.btn_tambah_layanan.Margin = new System.Windows.Forms.Padding(3, 5, 15, 5);
            this.btn_tambah_layanan.Name = "btn_tambah_layanan";
            this.btn_tambah_layanan.Size = new System.Drawing.Size(219, 51);
            this.btn_tambah_layanan.TabIndex = 10;
            this.btn_tambah_layanan.Text = "Tambah Layanan";
            this.btn_tambah_layanan.Click += new System.EventHandler(this.btn_tambah_layanan_Click);
            // 
            // btn_bayar
            // 
            this.btn_bayar.BorderColor = System.Drawing.Color.RosyBrown;
            this.btn_bayar.BorderRadius = 5;
            this.btn_bayar.BorderThickness = 2;
            this.btn_bayar.CustomBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_bayar.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.btn_bayar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_bayar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_bayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_bayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_bayar.FillColor = System.Drawing.Color.RosyBrown;
            this.btn_bayar.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bayar.ForeColor = System.Drawing.Color.White;
            this.btn_bayar.HoverState.FillColor = System.Drawing.Color.Pink;
            this.btn_bayar.Location = new System.Drawing.Point(540, 7);
            this.btn_bayar.Margin = new System.Windows.Forms.Padding(3, 5, 15, 5);
            this.btn_bayar.Name = "btn_bayar";
            this.btn_bayar.Size = new System.Drawing.Size(137, 48);
            this.btn_bayar.TabIndex = 8;
            this.btn_bayar.Text = "Bayar";
            this.btn_bayar.Click += new System.EventHandler(this.btn_bayar_Click);
            // 
            // cbx_nama_pelanggan
            // 
            this.cbx_nama_pelanggan.BackColor = System.Drawing.Color.Transparent;
            this.cbx_nama_pelanggan.BorderRadius = 2;
            this.cbx_nama_pelanggan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_nama_pelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_nama_pelanggan.FillColor = System.Drawing.Color.Pink;
            this.cbx_nama_pelanggan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_nama_pelanggan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_nama_pelanggan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_nama_pelanggan.ForeColor = System.Drawing.Color.DimGray;
            this.cbx_nama_pelanggan.ItemHeight = 30;
            this.cbx_nama_pelanggan.Location = new System.Drawing.Point(261, 81);
            this.cbx_nama_pelanggan.Name = "cbx_nama_pelanggan";
            this.cbx_nama_pelanggan.Size = new System.Drawing.Size(283, 36);
            this.cbx_nama_pelanggan.TabIndex = 11;
            // 
            // btn_detail_transaksi
            // 
            this.btn_detail_transaksi.BorderColor = System.Drawing.Color.RosyBrown;
            this.btn_detail_transaksi.BorderRadius = 5;
            this.btn_detail_transaksi.BorderThickness = 2;
            this.btn_detail_transaksi.CustomBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_detail_transaksi.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.btn_detail_transaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_detail_transaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_detail_transaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_detail_transaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_detail_transaksi.FillColor = System.Drawing.Color.Brown;
            this.btn_detail_transaksi.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detail_transaksi.ForeColor = System.Drawing.Color.White;
            this.btn_detail_transaksi.HoverState.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_detail_transaksi.HoverState.FillColor = System.Drawing.Color.Firebrick;
            this.btn_detail_transaksi.Location = new System.Drawing.Point(949, 5);
            this.btn_detail_transaksi.Margin = new System.Windows.Forms.Padding(3, 5, 15, 5);
            this.btn_detail_transaksi.Name = "btn_detail_transaksi";
            this.btn_detail_transaksi.Size = new System.Drawing.Size(275, 48);
            this.btn_detail_transaksi.TabIndex = 12;
            this.btn_detail_transaksi.Text = "Detail Transaksi";
            this.btn_detail_transaksi.Click += new System.EventHandler(this.btn_detail_transaksi_Click);
            // 
            // TambahTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1248, 724);
            this.Controls.Add(this.panel_bawah);
            this.Controls.Add(this.ShadowPanel_input_data_transaksi);
            this.Controls.Add(this.panel_atas_transaksi);
            this.Name = "TambahTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TambahTransaksi";
            this.panel_atas_transaksi.ResumeLayout(false);
            this.panel_atas_transaksi.PerformLayout();
            this.ShadowPanel_input_data_transaksi.ResumeLayout(false);
            this.ShadowPanel_input_data_transaksi.PerformLayout();
            this.panel_bawah.ResumeLayout(false);
            this.panel_dgv_detail_transaksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail_transaksi)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_atas_transaksi;
        private System.Windows.Forms.Label lbl_tambah_transaksi;
        private Guna.UI2.WinForms.Guna2Button btn_keluar;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel_input_data_transaksi;
        private System.Windows.Forms.Label lbl_tgl_masuk;
        private System.Windows.Forms.Label lbl_layanan;
        private System.Windows.Forms.Label lbl_nama_pelanggan;
        private System.Windows.Forms.Label lbl_id_transaksi;
        private System.Windows.Forms.Label lbl_jumlah;
        private System.Windows.Forms.Label lbl_jenis_layanan;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_status_pembayaran;
        private System.Windows.Forms.Label lbl_status_laundry;
        public Guna.UI2.WinForms.Guna2TextBox txt_id_transaksi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_tanggal_masuk;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_nama_layanan;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_jenis_layanan;
        public Guna.UI2.WinForms.Guna2TextBox txt_status_pembayaran;
        public Guna.UI2.WinForms.Guna2TextBox txt_status_laundry;
        public Guna.UI2.WinForms.Guna2TextBox txt_total;
        public Guna.UI2.WinForms.Guna2TextBox txt_harga;
        private System.Windows.Forms.Panel panel_bawah;
        private System.Windows.Forms.Label lbl_tgl_selesai;
        private System.Windows.Forms.Label lbl_harga;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_tanggal_selesai;
        public Guna.UI2.WinForms.Guna2TextBox txt_jumlah;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_detail_transaksi;
        private System.Windows.Forms.Panel panel_dgv_detail_transaksi;
        private System.Windows.Forms.Panel panel_button;
        private Guna.UI2.WinForms.Guna2Button btn_tambah_layanan;
        private Guna.UI2.WinForms.Guna2Button btn_kembali;
        private Guna.UI2.WinForms.Guna2Button btn_simpan;
        private Guna.UI2.WinForms.Guna2Button btn_bayar;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_nama_pelanggan;
        private Guna.UI2.WinForms.Guna2Button btn_detail_transaksi;
    }
}