namespace SistemLaundry.View
{
    partial class Masuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Masuk));
            this.panel_kiri = new System.Windows.Forms.Panel();
            this.panel_gambar = new System.Windows.Forms.Panel();
            this.lbl_hai_admin = new System.Windows.Forms.Label();
            this.lbl_perintah_input_user_pass = new System.Windows.Forms.Label();
            this.panel_masuk = new System.Windows.Forms.Panel();
            this.checkBox_show_pass = new System.Windows.Forms.CheckBox();
            this.btn_masuk = new Guna.UI2.WinForms.Guna2Button();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_masuk_akun = new System.Windows.Forms.Label();
            this.pictureBox_logo_laundry = new System.Windows.Forms.PictureBox();
            this.btn_kembali = new Guna.UI2.WinForms.Guna2Button();
            this.panel_kiri.SuspendLayout();
            this.panel_gambar.SuspendLayout();
            this.panel_masuk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo_laundry)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_kiri
            // 
            this.panel_kiri.BackColor = System.Drawing.Color.Pink;
            this.panel_kiri.Controls.Add(this.panel_gambar);
            this.panel_kiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_kiri.Location = new System.Drawing.Point(0, 0);
            this.panel_kiri.Name = "panel_kiri";
            this.panel_kiri.Size = new System.Drawing.Size(504, 670);
            this.panel_kiri.TabIndex = 2;
            // 
            // panel_gambar
            // 
            this.panel_gambar.Controls.Add(this.btn_kembali);
            this.panel_gambar.Controls.Add(this.pictureBox_logo_laundry);
            this.panel_gambar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_gambar.Location = new System.Drawing.Point(0, 0);
            this.panel_gambar.Name = "panel_gambar";
            this.panel_gambar.Size = new System.Drawing.Size(504, 670);
            this.panel_gambar.TabIndex = 9;
            // 
            // lbl_hai_admin
            // 
            this.lbl_hai_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hai_admin.AutoSize = true;
            this.lbl_hai_admin.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hai_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_hai_admin.Location = new System.Drawing.Point(773, 87);
            this.lbl_hai_admin.Name = "lbl_hai_admin";
            this.lbl_hai_admin.Size = new System.Drawing.Size(182, 28);
            this.lbl_hai_admin.TabIndex = 3;
            this.lbl_hai_admin.Text = "Sebagai Admin";
            // 
            // lbl_perintah_input_user_pass
            // 
            this.lbl_perintah_input_user_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_perintah_input_user_pass.AutoSize = true;
            this.lbl_perintah_input_user_pass.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perintah_input_user_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_perintah_input_user_pass.Location = new System.Drawing.Point(640, 149);
            this.lbl_perintah_input_user_pass.Name = "lbl_perintah_input_user_pass";
            this.lbl_perintah_input_user_pass.Size = new System.Drawing.Size(449, 27);
            this.lbl_perintah_input_user_pass.TabIndex = 4;
            this.lbl_perintah_input_user_pass.Text = "Masukkan Username dan Password untuk masuk";
            // 
            // panel_masuk
            // 
            this.panel_masuk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_masuk.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_masuk.Controls.Add(this.checkBox_show_pass);
            this.panel_masuk.Controls.Add(this.btn_masuk);
            this.panel_masuk.Controls.Add(this.txt_password);
            this.panel_masuk.Controls.Add(this.txt_username);
            this.panel_masuk.Controls.Add(this.lbl_password);
            this.panel_masuk.Controls.Add(this.lbl_username);
            this.panel_masuk.Location = new System.Drawing.Point(571, 194);
            this.panel_masuk.Name = "panel_masuk";
            this.panel_masuk.Size = new System.Drawing.Size(610, 405);
            this.panel_masuk.TabIndex = 5;
            // 
            // checkBox_show_pass
            // 
            this.checkBox_show_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_show_pass.AutoSize = true;
            this.checkBox_show_pass.Font = new System.Drawing.Font("Goudy Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_show_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.checkBox_show_pass.Location = new System.Drawing.Point(152, 263);
            this.checkBox_show_pass.Name = "checkBox_show_pass";
            this.checkBox_show_pass.Size = new System.Drawing.Size(171, 25);
            this.checkBox_show_pass.TabIndex = 5;
            this.checkBox_show_pass.Text = "Tampilkan Password";
            this.checkBox_show_pass.UseVisualStyleBackColor = true;
            this.checkBox_show_pass.CheckedChanged += new System.EventHandler(this.checkBox_show_pass_CheckedChanged);
            // 
            // btn_masuk
            // 
            this.btn_masuk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_masuk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_masuk.BorderRadius = 10;
            this.btn_masuk.BorderThickness = 5;
            this.btn_masuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_masuk.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_masuk.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btn_masuk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_masuk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_masuk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_masuk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_masuk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_masuk.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_masuk.ForeColor = System.Drawing.Color.White;
            this.btn_masuk.Location = new System.Drawing.Point(385, 312);
            this.btn_masuk.Name = "btn_masuk";
            this.btn_masuk.Padding = new System.Windows.Forms.Padding(5);
            this.btn_masuk.PressedColor = System.Drawing.Color.Pink;
            this.btn_masuk.Size = new System.Drawing.Size(201, 60);
            this.btn_masuk.TabIndex = 4;
            this.btn_masuk.Text = "Masuk";
            this.btn_masuk.Click += new System.EventHandler(this.btn_masuk_Click);
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
            this.txt_password.Location = new System.Drawing.Point(142, 195);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_password.PlaceholderText = "Masukkan 6 angka";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(309, 46);
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
            this.txt_username.Location = new System.Drawing.Point(142, 78);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_username.PlaceholderText = "Masukkan 6 huruf/angka";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(309, 46);
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
            this.lbl_password.Location = new System.Drawing.Point(235, 150);
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
            this.lbl_username.Location = new System.Drawing.Point(234, 33);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(120, 29);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username\r\n";
            // 
            // lbl_masuk_akun
            // 
            this.lbl_masuk_akun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_masuk_akun.AutoSize = true;
            this.lbl_masuk_akun.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masuk_akun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_masuk_akun.Location = new System.Drawing.Point(722, 30);
            this.lbl_masuk_akun.Name = "lbl_masuk_akun";
            this.lbl_masuk_akun.Size = new System.Drawing.Size(300, 57);
            this.lbl_masuk_akun.TabIndex = 6;
            this.lbl_masuk_akun.Text = "Masuk Akun";
            // 
            // pictureBox_logo_laundry
            // 
            this.pictureBox_logo_laundry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_logo_laundry.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo_laundry.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo_laundry.Image")));
            this.pictureBox_logo_laundry.Location = new System.Drawing.Point(46, 21);
            this.pictureBox_logo_laundry.Name = "pictureBox_logo_laundry";
            this.pictureBox_logo_laundry.Size = new System.Drawing.Size(410, 568);
            this.pictureBox_logo_laundry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo_laundry.TabIndex = 0;
            this.pictureBox_logo_laundry.TabStop = false;
            // 
            // btn_kembali
            // 
            this.btn_kembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kembali.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_kembali.BorderRadius = 10;
            this.btn_kembali.BorderThickness = 5;
            this.btn_kembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kembali.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.btn_kembali.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btn_kembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_kembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_kembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_kembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_kembali.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_kembali.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.ForeColor = System.Drawing.Color.White;
            this.btn_kembali.Location = new System.Drawing.Point(21, 614);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Padding = new System.Windows.Forms.Padding(5);
            this.btn_kembali.PressedColor = System.Drawing.Color.Pink;
            this.btn_kembali.Size = new System.Drawing.Size(146, 44);
            this.btn_kembali.TabIndex = 7;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // Masuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 670);
            this.Controls.Add(this.lbl_masuk_akun);
            this.Controls.Add(this.lbl_perintah_input_user_pass);
            this.Controls.Add(this.lbl_hai_admin);
            this.Controls.Add(this.panel_masuk);
            this.Controls.Add(this.panel_kiri);
            this.Name = "Masuk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masuk";
            this.Load += new System.EventHandler(this.Masuk_Load);
            this.panel_kiri.ResumeLayout(false);
            this.panel_gambar.ResumeLayout(false);
            this.panel_masuk.ResumeLayout(false);
            this.panel_masuk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo_laundry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_kiri;
        private System.Windows.Forms.PictureBox pictureBox_logo_laundry;
        private System.Windows.Forms.Label lbl_hai_admin;
        private System.Windows.Forms.Label lbl_perintah_input_user_pass;
        private System.Windows.Forms.Panel panel_masuk;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        public Guna.UI2.WinForms.Guna2TextBox txt_username;
        public Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2Button btn_masuk;
        private System.Windows.Forms.Label lbl_masuk_akun;
        private System.Windows.Forms.CheckBox checkBox_show_pass;
        private System.Windows.Forms.Panel panel_gambar;
        private Guna.UI2.WinForms.Guna2Button btn_kembali;
    }
}