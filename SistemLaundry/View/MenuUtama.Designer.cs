namespace SistemLaundry.View
{
    partial class MenuUtama
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
            this.panel_kiri = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_button = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_gambar = new System.Windows.Forms.Panel();
            this.lbl_si_laundry = new System.Windows.Forms.Label();
            this.panel_atas = new System.Windows.Forms.Panel();
            this.btn_keluar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_beranda = new Guna.UI2.WinForms.Guna2Button();
            this.btn_data_pelanggan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_data_layanan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_transaksi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_manajemen_admin = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBox_logo_laundry = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_kiri.SuspendLayout();
            this.flowLayoutPanel_button.SuspendLayout();
            this.panel_gambar.SuspendLayout();
            this.panel_atas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logo_laundry)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_kiri
            // 
            this.panel_kiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(192)))));
            this.panel_kiri.Controls.Add(this.flowLayoutPanel_button);
            this.panel_kiri.Controls.Add(this.panel_gambar);
            this.panel_kiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_kiri.Location = new System.Drawing.Point(0, 0);
            this.panel_kiri.Name = "panel_kiri";
            this.panel_kiri.Size = new System.Drawing.Size(309, 670);
            this.panel_kiri.TabIndex = 3;
            // 
            // flowLayoutPanel_button
            // 
            this.flowLayoutPanel_button.AutoScroll = true;
            this.flowLayoutPanel_button.Controls.Add(this.btn_beranda);
            this.flowLayoutPanel_button.Controls.Add(this.btn_data_pelanggan);
            this.flowLayoutPanel_button.Controls.Add(this.btn_data_layanan);
            this.flowLayoutPanel_button.Controls.Add(this.btn_transaksi);
            this.flowLayoutPanel_button.Controls.Add(this.btn_manajemen_admin);
            this.flowLayoutPanel_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_button.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_button.Location = new System.Drawing.Point(0, 244);
            this.flowLayoutPanel_button.Name = "flowLayoutPanel_button";
            this.flowLayoutPanel_button.Padding = new System.Windows.Forms.Padding(20, 10, 5, 5);
            this.flowLayoutPanel_button.Size = new System.Drawing.Size(309, 426);
            this.flowLayoutPanel_button.TabIndex = 1;
            this.flowLayoutPanel_button.WrapContents = false;
            // 
            // panel_gambar
            // 
            this.panel_gambar.BackColor = System.Drawing.Color.Transparent;
            this.panel_gambar.Controls.Add(this.PictureBox_logo_laundry);
            this.panel_gambar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_gambar.Location = new System.Drawing.Point(0, 0);
            this.panel_gambar.Name = "panel_gambar";
            this.panel_gambar.Size = new System.Drawing.Size(309, 244);
            this.panel_gambar.TabIndex = 0;
            // 
            // lbl_si_laundry
            // 
            this.lbl_si_laundry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_si_laundry.AutoSize = true;
            this.lbl_si_laundry.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_si_laundry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_si_laundry.Location = new System.Drawing.Point(226, 9);
            this.lbl_si_laundry.Name = "lbl_si_laundry";
            this.lbl_si_laundry.Size = new System.Drawing.Size(414, 28);
            this.lbl_si_laundry.TabIndex = 1;
            this.lbl_si_laundry.Text = "Sistem Laundry | Apriluxe Laundry";
            // 
            // panel_atas
            // 
            this.panel_atas.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_atas.Controls.Add(this.lbl_si_laundry);
            this.panel_atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_atas.Location = new System.Drawing.Point(309, 0);
            this.panel_atas.Name = "panel_atas";
            this.panel_atas.Size = new System.Drawing.Size(939, 49);
            this.panel_atas.TabIndex = 4;
            // 
            // btn_keluar
            // 
            this.btn_keluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_keluar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_keluar.BorderRadius = 10;
            this.btn_keluar.BorderThickness = 2;
            this.btn_keluar.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 8);
            this.btn_keluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_keluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_keluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_keluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_keluar.FillColor = System.Drawing.Color.LavenderBlush;
            this.btn_keluar.FocusedColor = System.Drawing.Color.White;
            this.btn_keluar.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_keluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_keluar.Image = global::SistemLaundry.Properties.Resources.logout_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            this.btn_keluar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_keluar.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_keluar.Location = new System.Drawing.Point(1045, 602);
            this.btn_keluar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_keluar.PressedDepth = 20;
            this.btn_keluar.Size = new System.Drawing.Size(189, 54);
            this.btn_keluar.TabIndex = 5;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // btn_beranda
            // 
            this.btn_beranda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_beranda.BorderRadius = 10;
            this.btn_beranda.BorderThickness = 2;
            this.btn_beranda.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 8);
            this.btn_beranda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_beranda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_beranda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_beranda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_beranda.FillColor = System.Drawing.Color.LavenderBlush;
            this.btn_beranda.FocusedColor = System.Drawing.Color.White;
            this.btn_beranda.Font = new System.Drawing.Font("Imprint MT Shadow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beranda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_beranda.Image = global::SistemLaundry.Properties.Resources.admin;
            this.btn_beranda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_beranda.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_beranda.Location = new System.Drawing.Point(25, 15);
            this.btn_beranda.Margin = new System.Windows.Forms.Padding(5);
            this.btn_beranda.Name = "btn_beranda";
            this.btn_beranda.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_beranda.PressedDepth = 20;
            this.btn_beranda.Size = new System.Drawing.Size(247, 67);
            this.btn_beranda.TabIndex = 2;
            this.btn_beranda.Text = "   Beranda";
            this.btn_beranda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_data_pelanggan
            // 
            this.btn_data_pelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_data_pelanggan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_data_pelanggan.BorderRadius = 10;
            this.btn_data_pelanggan.BorderThickness = 2;
            this.btn_data_pelanggan.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 8);
            this.btn_data_pelanggan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_data_pelanggan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_data_pelanggan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_data_pelanggan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_data_pelanggan.FillColor = System.Drawing.Color.LavenderBlush;
            this.btn_data_pelanggan.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data_pelanggan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_data_pelanggan.Image = global::SistemLaundry.Properties.Resources.personal_information;
            this.btn_data_pelanggan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_data_pelanggan.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_data_pelanggan.Location = new System.Drawing.Point(25, 92);
            this.btn_data_pelanggan.Margin = new System.Windows.Forms.Padding(5);
            this.btn_data_pelanggan.Name = "btn_data_pelanggan";
            this.btn_data_pelanggan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_data_pelanggan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_data_pelanggan.PressedDepth = 20;
            this.btn_data_pelanggan.Size = new System.Drawing.Size(247, 67);
            this.btn_data_pelanggan.TabIndex = 3;
            this.btn_data_pelanggan.Text = " Data Pelanggan";
            this.btn_data_pelanggan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_data_pelanggan.Click += new System.EventHandler(this.btn_data_pelanggan_Click);
            // 
            // btn_data_layanan
            // 
            this.btn_data_layanan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_data_layanan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_data_layanan.BorderRadius = 10;
            this.btn_data_layanan.BorderThickness = 2;
            this.btn_data_layanan.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 8);
            this.btn_data_layanan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_data_layanan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_data_layanan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_data_layanan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_data_layanan.FillColor = System.Drawing.Color.LavenderBlush;
            this.btn_data_layanan.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data_layanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_data_layanan.Image = global::SistemLaundry.Properties.Resources.laundry;
            this.btn_data_layanan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_data_layanan.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_data_layanan.Location = new System.Drawing.Point(25, 169);
            this.btn_data_layanan.Margin = new System.Windows.Forms.Padding(5);
            this.btn_data_layanan.Name = "btn_data_layanan";
            this.btn_data_layanan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_data_layanan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_data_layanan.PressedDepth = 20;
            this.btn_data_layanan.Size = new System.Drawing.Size(247, 67);
            this.btn_data_layanan.TabIndex = 4;
            this.btn_data_layanan.Text = " Data Layanan";
            this.btn_data_layanan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_data_layanan.Click += new System.EventHandler(this.btn_data_layanan_Click);
            // 
            // btn_transaksi
            // 
            this.btn_transaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_transaksi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_transaksi.BorderRadius = 10;
            this.btn_transaksi.BorderThickness = 2;
            this.btn_transaksi.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 8);
            this.btn_transaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_transaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_transaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_transaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_transaksi.FillColor = System.Drawing.Color.LavenderBlush;
            this.btn_transaksi.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_transaksi.Image = global::SistemLaundry.Properties.Resources.transaction_history;
            this.btn_transaksi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_transaksi.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_transaksi.Location = new System.Drawing.Point(25, 246);
            this.btn_transaksi.Margin = new System.Windows.Forms.Padding(5);
            this.btn_transaksi.Name = "btn_transaksi";
            this.btn_transaksi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_transaksi.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_transaksi.PressedDepth = 20;
            this.btn_transaksi.Size = new System.Drawing.Size(247, 67);
            this.btn_transaksi.TabIndex = 6;
            this.btn_transaksi.Text = " Transaksi";
            this.btn_transaksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_transaksi.Click += new System.EventHandler(this.btn_transaksi_Click);
            // 
            // btn_manajemen_admin
            // 
            this.btn_manajemen_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_manajemen_admin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_manajemen_admin.BorderRadius = 10;
            this.btn_manajemen_admin.BorderThickness = 2;
            this.btn_manajemen_admin.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 8);
            this.btn_manajemen_admin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_manajemen_admin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_manajemen_admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_manajemen_admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_manajemen_admin.FillColor = System.Drawing.Color.LavenderBlush;
            this.btn_manajemen_admin.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manajemen_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_manajemen_admin.Image = global::SistemLaundry.Properties.Resources.team;
            this.btn_manajemen_admin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_manajemen_admin.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_manajemen_admin.Location = new System.Drawing.Point(25, 323);
            this.btn_manajemen_admin.Margin = new System.Windows.Forms.Padding(5);
            this.btn_manajemen_admin.Name = "btn_manajemen_admin";
            this.btn_manajemen_admin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_manajemen_admin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_manajemen_admin.PressedDepth = 20;
            this.btn_manajemen_admin.Size = new System.Drawing.Size(247, 67);
            this.btn_manajemen_admin.TabIndex = 5;
            this.btn_manajemen_admin.Text = "Data Admin";
            this.btn_manajemen_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_manajemen_admin.Click += new System.EventHandler(this.btn_manajemen_admin_Click);
            // 
            // PictureBox_logo_laundry
            // 
            this.PictureBox_logo_laundry.Image = global::SistemLaundry.Properties.Resources.logo_laundry;
            this.PictureBox_logo_laundry.ImageRotate = 0F;
            this.PictureBox_logo_laundry.Location = new System.Drawing.Point(3, 3);
            this.PictureBox_logo_laundry.Name = "PictureBox_logo_laundry";
            this.PictureBox_logo_laundry.Size = new System.Drawing.Size(300, 234);
            this.PictureBox_logo_laundry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_logo_laundry.TabIndex = 4;
            this.PictureBox_logo_laundry.TabStop = false;
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 670);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.panel_atas);
            this.Controls.Add(this.panel_kiri);
            this.Name = "MenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuUtama";
            this.Load += new System.EventHandler(this.MenuUtama_Load);
            this.panel_kiri.ResumeLayout(false);
            this.flowLayoutPanel_button.ResumeLayout(false);
            this.panel_gambar.ResumeLayout(false);
            this.panel_atas.ResumeLayout(false);
            this.panel_atas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logo_laundry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_beranda;
        private System.Windows.Forms.Panel panel_kiri;
        private Guna.UI2.WinForms.Guna2Button btn_data_pelanggan;
        private System.Windows.Forms.Label lbl_si_laundry;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_logo_laundry;
        private System.Windows.Forms.Panel panel_atas;
        private System.Windows.Forms.Panel panel_gambar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_button;
        private Guna.UI2.WinForms.Guna2Button btn_data_layanan;
        private Guna.UI2.WinForms.Guna2Button btn_manajemen_admin;
        private Guna.UI2.WinForms.Guna2Button btn_transaksi;
        private Guna.UI2.WinForms.Guna2Button btn_keluar;
    }
}