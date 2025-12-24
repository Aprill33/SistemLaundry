namespace SistemLaundry.View
{
    partial class DaftarKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaftarKasir));
            this.panel_kanan = new System.Windows.Forms.Panel();
            this.pictureBox_logo_laundry = new System.Windows.Forms.PictureBox();
            this.panel_masuk = new System.Windows.Forms.Panel();
            this.checkBox_show_pass = new System.Windows.Forms.CheckBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_daftar_akun = new System.Windows.Forms.Label();
            this.lbl_perintah_input_user_pass = new System.Windows.Forms.Label();
            this.lbl_sbg_kasir = new System.Windows.Forms.Label();
            this.btn_simpan = new Guna.UI2.WinForms.Guna2Button();
            this.panel_kanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo_laundry)).BeginInit();
            this.panel_masuk.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_kanan
            // 
            this.panel_kanan.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_kanan.Controls.Add(this.btn_simpan);
            this.panel_kanan.Controls.Add(this.pictureBox_logo_laundry);
            this.panel_kanan.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_kanan.Location = new System.Drawing.Point(793, 0);
            this.panel_kanan.Name = "panel_kanan";
            this.panel_kanan.Size = new System.Drawing.Size(455, 670);
            this.panel_kanan.TabIndex = 0;
            // 
            // pictureBox_logo_laundry
            // 
            this.pictureBox_logo_laundry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_logo_laundry.BackColor = System.Drawing.Color.White;
            this.pictureBox_logo_laundry.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo_laundry.Image")));
            this.pictureBox_logo_laundry.Location = new System.Drawing.Point(23, 12);
            this.pictureBox_logo_laundry.Name = "pictureBox_logo_laundry";
            this.pictureBox_logo_laundry.Size = new System.Drawing.Size(410, 412);
            this.pictureBox_logo_laundry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo_laundry.TabIndex = 2;
            this.pictureBox_logo_laundry.TabStop = false;
            // 
            // panel_masuk
            // 
            this.panel_masuk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_masuk.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_masuk.Controls.Add(this.checkBox_show_pass);
            this.panel_masuk.Controls.Add(this.txt_password);
            this.panel_masuk.Controls.Add(this.txt_username);
            this.panel_masuk.Controls.Add(this.lbl_password);
            this.panel_masuk.Controls.Add(this.lbl_username);
            this.panel_masuk.Location = new System.Drawing.Point(91, 252);
            this.panel_masuk.Name = "panel_masuk";
            this.panel_masuk.Size = new System.Drawing.Size(610, 315);
            this.panel_masuk.TabIndex = 7;
            // 
            // checkBox_show_pass
            // 
            this.checkBox_show_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_show_pass.AutoSize = true;
            this.checkBox_show_pass.Font = new System.Drawing.Font("Goudy Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_show_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.checkBox_show_pass.Location = new System.Drawing.Point(195, 214);
            this.checkBox_show_pass.Name = "checkBox_show_pass";
            this.checkBox_show_pass.Size = new System.Drawing.Size(171, 25);
            this.checkBox_show_pass.TabIndex = 5;
            this.checkBox_show_pass.Text = "Tampilkan Password";
            this.checkBox_show_pass.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.txt_password.BorderRadius = 10;
            this.txt_password.BorderThickness = 3;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.DeepPink;
            this.txt_password.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_password.Location = new System.Drawing.Point(195, 145);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_password.PlaceholderText = "Masukkan 6 angka";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(309, 45);
            this.txt_password.TabIndex = 3;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.txt_username.BorderRadius = 10;
            this.txt_username.BorderThickness = 3;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.DeepPink;
            this.txt_username.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_username.Location = new System.Drawing.Point(195, 50);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_username.PlaceholderText = "Masukkan 6 huruf/angka";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(309, 45);
            this.txt_username.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Geometr415 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_password.Location = new System.Drawing.Point(36, 162);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(119, 29);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password ";
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Geometr415 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_username.Location = new System.Drawing.Point(35, 66);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(120, 29);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username\r\n";
            // 
            // lbl_daftar_akun
            // 
            this.lbl_daftar_akun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_daftar_akun.AutoSize = true;
            this.lbl_daftar_akun.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_daftar_akun.ForeColor = System.Drawing.Color.White;
            this.lbl_daftar_akun.Location = new System.Drawing.Point(238, 48);
            this.lbl_daftar_akun.Name = "lbl_daftar_akun";
            this.lbl_daftar_akun.Size = new System.Drawing.Size(297, 57);
            this.lbl_daftar_akun.TabIndex = 12;
            this.lbl_daftar_akun.Text = "Daftar Akun";
            // 
            // lbl_perintah_input_user_pass
            // 
            this.lbl_perintah_input_user_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_perintah_input_user_pass.AutoSize = true;
            this.lbl_perintah_input_user_pass.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perintah_input_user_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_perintah_input_user_pass.Location = new System.Drawing.Point(156, 193);
            this.lbl_perintah_input_user_pass.Name = "lbl_perintah_input_user_pass";
            this.lbl_perintah_input_user_pass.Size = new System.Drawing.Size(444, 27);
            this.lbl_perintah_input_user_pass.TabIndex = 11;
            this.lbl_perintah_input_user_pass.Text = "Masukkan Username dan Password untuk daftar";
            // 
            // lbl_sbg_kasir
            // 
            this.lbl_sbg_kasir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sbg_kasir.AutoSize = true;
            this.lbl_sbg_kasir.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sbg_kasir.ForeColor = System.Drawing.Color.White;
            this.lbl_sbg_kasir.Location = new System.Drawing.Point(289, 105);
            this.lbl_sbg_kasir.Name = "lbl_sbg_kasir";
            this.lbl_sbg_kasir.Size = new System.Drawing.Size(165, 28);
            this.lbl_sbg_kasir.TabIndex = 10;
            this.lbl_sbg_kasir.Text = "Sebagai Kasir";
            // 
            // btn_simpan
            // 
            this.btn_simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_simpan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_simpan.BorderRadius = 10;
            this.btn_simpan.BorderThickness = 5;
            this.btn_simpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simpan.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_simpan.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btn_simpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_simpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_simpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_simpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_simpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_simpan.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.Location = new System.Drawing.Point(121, 507);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Padding = new System.Windows.Forms.Padding(5);
            this.btn_simpan.PressedColor = System.Drawing.Color.Pink;
            this.btn_simpan.Size = new System.Drawing.Size(214, 60);
            this.btn_simpan.TabIndex = 7;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // DaftarKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1248, 670);
            this.Controls.Add(this.lbl_daftar_akun);
            this.Controls.Add(this.lbl_perintah_input_user_pass);
            this.Controls.Add(this.lbl_sbg_kasir);
            this.Controls.Add(this.panel_masuk);
            this.Controls.Add(this.panel_kanan);
            this.Name = "DaftarKasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DaftarKasir";
            this.panel_kanan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo_laundry)).EndInit();
            this.panel_masuk.ResumeLayout(false);
            this.panel_masuk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_kanan;
        private System.Windows.Forms.PictureBox pictureBox_logo_laundry;
        private System.Windows.Forms.Panel panel_masuk;
        private System.Windows.Forms.CheckBox checkBox_show_pass;
        public Guna.UI2.WinForms.Guna2TextBox txt_password;
        public Guna.UI2.WinForms.Guna2TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_daftar_akun;
        private System.Windows.Forms.Label lbl_perintah_input_user_pass;
        private System.Windows.Forms.Label lbl_sbg_kasir;
        private Guna.UI2.WinForms.Guna2Button btn_simpan;
    }
}