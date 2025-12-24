namespace SistemLaundry.View
{
    partial class DataAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_atas = new System.Windows.Forms.Panel();
            this.lbl_data_admin = new System.Windows.Forms.Label();
            this.lbl_slogan = new System.Windows.Forms.Label();
            this.lbl_si_laundry = new System.Windows.Forms.Label();
            this.panel_dgv_data_admin = new System.Windows.Forms.Panel();
            this.dgv_data_admin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_manajemen_admin = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.btn_kembali = new Guna.UI2.WinForms.Guna2Button();
            this.btn_aktifkan = new Guna.UI2.WinForms.Guna2Button();
            this.panel_atas.SuspendLayout();
            this.panel_dgv_data_admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_admin)).BeginInit();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_atas
            // 
            this.panel_atas.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_atas.Controls.Add(this.lbl_data_admin);
            this.panel_atas.Controls.Add(this.lbl_si_laundry);
            this.panel_atas.Controls.Add(this.lbl_slogan);
            this.panel_atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_atas.Location = new System.Drawing.Point(0, 0);
            this.panel_atas.Name = "panel_atas";
            this.panel_atas.Size = new System.Drawing.Size(1248, 86);
            this.panel_atas.TabIndex = 0;
            // 
            // lbl_data_admin
            // 
            this.lbl_data_admin.AutoSize = true;
            this.lbl_data_admin.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_data_admin.Location = new System.Drawing.Point(12, 27);
            this.lbl_data_admin.Name = "lbl_data_admin";
            this.lbl_data_admin.Size = new System.Drawing.Size(175, 33);
            this.lbl_data_admin.TabIndex = 6;
            this.lbl_data_admin.Text = "Data Admin";
            // 
            // lbl_slogan
            // 
            this.lbl_slogan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_slogan.AutoSize = true;
            this.lbl_slogan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_slogan.Font = new System.Drawing.Font("Goudy Old Style", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slogan.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_slogan.Location = new System.Drawing.Point(511, 51);
            this.lbl_slogan.Name = "lbl_slogan";
            this.lbl_slogan.Size = new System.Drawing.Size(204, 22);
            this.lbl_slogan.TabIndex = 9;
            this.lbl_slogan.Text = "Clean And Fresh Laundry";
            // 
            // lbl_si_laundry
            // 
            this.lbl_si_laundry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_si_laundry.AutoSize = true;
            this.lbl_si_laundry.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_si_laundry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_si_laundry.Location = new System.Drawing.Point(456, 9);
            this.lbl_si_laundry.Name = "lbl_si_laundry";
            this.lbl_si_laundry.Size = new System.Drawing.Size(323, 42);
            this.lbl_si_laundry.TabIndex = 8;
            this.lbl_si_laundry.Text = " Apriluxe Laundry";
            // 
            // panel_dgv_data_admin
            // 
            this.panel_dgv_data_admin.Controls.Add(this.panel_button);
            this.panel_dgv_data_admin.Controls.Add(this.lbl_manajemen_admin);
            this.panel_dgv_data_admin.Controls.Add(this.dgv_data_admin);
            this.panel_dgv_data_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dgv_data_admin.Location = new System.Drawing.Point(0, 86);
            this.panel_dgv_data_admin.Name = "panel_dgv_data_admin";
            this.panel_dgv_data_admin.Size = new System.Drawing.Size(1248, 584);
            this.panel_dgv_data_admin.TabIndex = 12;
            // 
            // dgv_data_admin
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_data_admin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_data_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_admin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_data_admin.ColumnHeadersHeight = 40;
            this.dgv_data_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data_admin.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_data_admin.GridColor = System.Drawing.Color.HotPink;
            this.dgv_data_admin.Location = new System.Drawing.Point(62, 59);
            this.dgv_data_admin.Name = "dgv_data_admin";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_admin.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_data_admin.RowHeadersVisible = false;
            this.dgv_data_admin.RowHeadersWidth = 62;
            this.dgv_data_admin.RowTemplate.Height = 28;
            this.dgv_data_admin.Size = new System.Drawing.Size(1123, 341);
            this.dgv_data_admin.TabIndex = 13;
            this.dgv_data_admin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_data_admin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_data_admin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.HotPink;
            this.dgv_data_admin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_data_admin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_data_admin.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_data_admin.ThemeStyle.GridColor = System.Drawing.Color.HotPink;
            this.dgv_data_admin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.HotPink;
            this.dgv_data_admin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_data_admin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_data_admin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_data_admin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_data_admin.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_data_admin.ThemeStyle.ReadOnly = false;
            this.dgv_data_admin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_data_admin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_data_admin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_data_admin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_data_admin.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_data_admin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_data_admin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lbl_manajemen_admin
            // 
            this.lbl_manajemen_admin.AutoSize = true;
            this.lbl_manajemen_admin.Font = new System.Drawing.Font("Imprint MT Shadow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manajemen_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_manajemen_admin.Location = new System.Drawing.Point(505, 19);
            this.lbl_manajemen_admin.Name = "lbl_manajemen_admin";
            this.lbl_manajemen_admin.Size = new System.Drawing.Size(210, 25);
            this.lbl_manajemen_admin.TabIndex = 10;
            this.lbl_manajemen_admin.Text = "Manajemen Admin";
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_button.Controls.Add(this.btn_aktifkan);
            this.panel_button.Controls.Add(this.btn_kembali);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 485);
            this.panel_button.Name = "panel_button";
            this.panel_button.Padding = new System.Windows.Forms.Padding(10);
            this.panel_button.Size = new System.Drawing.Size(1248, 99);
            this.panel_button.TabIndex = 14;
            // 
            // btn_kembali
            // 
            this.btn_kembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btn_kembali.Location = new System.Drawing.Point(62, 25);
            this.btn_kembali.Margin = new System.Windows.Forms.Padding(3, 5, 15, 5);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(226, 48);
            this.btn_kembali.TabIndex = 10;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_aktifkan
            // 
            this.btn_aktifkan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aktifkan.BorderColor = System.Drawing.Color.RosyBrown;
            this.btn_aktifkan.BorderRadius = 5;
            this.btn_aktifkan.BorderThickness = 2;
            this.btn_aktifkan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_aktifkan.CustomBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_aktifkan.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.btn_aktifkan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_aktifkan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_aktifkan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_aktifkan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_aktifkan.FillColor = System.Drawing.Color.Brown;
            this.btn_aktifkan.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aktifkan.ForeColor = System.Drawing.Color.White;
            this.btn_aktifkan.HoverState.FillColor = System.Drawing.Color.Pink;
            this.btn_aktifkan.Location = new System.Drawing.Point(964, 25);
            this.btn_aktifkan.Margin = new System.Windows.Forms.Padding(3, 5, 15, 5);
            this.btn_aktifkan.Name = "btn_aktifkan";
            this.btn_aktifkan.Size = new System.Drawing.Size(221, 48);
            this.btn_aktifkan.TabIndex = 11;
            this.btn_aktifkan.Text = "Aktifkan";
            this.btn_aktifkan.Click += new System.EventHandler(this.btn_aktifkan_Click);
            // 
            // DataAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1248, 670);
            this.Controls.Add(this.panel_dgv_data_admin);
            this.Controls.Add(this.panel_atas);
            this.Name = "DataAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataAdmin";
            this.Load += new System.EventHandler(this.DataAdmin_Load);
            this.panel_atas.ResumeLayout(false);
            this.panel_atas.PerformLayout();
            this.panel_dgv_data_admin.ResumeLayout(false);
            this.panel_dgv_data_admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_admin)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_atas;
        private System.Windows.Forms.Label lbl_data_admin;
        private System.Windows.Forms.Label lbl_slogan;
        private System.Windows.Forms.Label lbl_si_laundry;
        private System.Windows.Forms.Panel panel_dgv_data_admin;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_data_admin;
        private System.Windows.Forms.Label lbl_manajemen_admin;
        private System.Windows.Forms.Panel panel_button;
        private Guna.UI2.WinForms.Guna2Button btn_aktifkan;
        private Guna.UI2.WinForms.Guna2Button btn_kembali;
    }
}