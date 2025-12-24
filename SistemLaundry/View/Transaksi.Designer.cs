namespace SistemLaundry.View
{
    partial class Transaksi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_keluar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_transaksi = new System.Windows.Forms.Label();
            this.flowLayoutPanel_pencarian = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_bawah = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_button = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_kembali = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit_status = new Guna.UI2.WinForms.Guna2Button();
            this.btn_detail_transaksi = new Guna.UI2.WinForms.Guna2Button();
            this.panel_dgv_transaksi = new System.Windows.Forms.Panel();
            this.lbl_slogan = new System.Windows.Forms.Label();
            this.lbl_si_laundry = new System.Windows.Forms.Label();
            this.dgv_transaksi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_pencarian = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_header.SuspendLayout();
            this.flowLayoutPanel_pencarian.SuspendLayout();
            this.panel_bawah.SuspendLayout();
            this.flowLayoutPanel_button.SuspendLayout();
            this.panel_dgv_transaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_header.Controls.Add(this.btn_keluar);
            this.panel_header.Controls.Add(this.lbl_transaksi);
            this.panel_header.Controls.Add(this.flowLayoutPanel_pencarian);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1248, 79);
            this.panel_header.TabIndex = 0;
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
            this.btn_keluar.Location = new System.Drawing.Point(1194, 7);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(42, 43);
            this.btn_keluar.TabIndex = 10;
            this.btn_keluar.Text = "X";
            // 
            // lbl_transaksi
            // 
            this.lbl_transaksi.AutoSize = true;
            this.lbl_transaksi.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_transaksi.Location = new System.Drawing.Point(12, 19);
            this.lbl_transaksi.Name = "lbl_transaksi";
            this.lbl_transaksi.Size = new System.Drawing.Size(142, 33);
            this.lbl_transaksi.TabIndex = 4;
            this.lbl_transaksi.Text = "Transaksi";
            // 
            // flowLayoutPanel_pencarian
            // 
            this.flowLayoutPanel_pencarian.Controls.Add(this.txt_pencarian);
            this.flowLayoutPanel_pencarian.Location = new System.Drawing.Point(695, 7);
            this.flowLayoutPanel_pencarian.Name = "flowLayoutPanel_pencarian";
            this.flowLayoutPanel_pencarian.Padding = new System.Windows.Forms.Padding(15, 7, 5, 5);
            this.flowLayoutPanel_pencarian.Size = new System.Drawing.Size(476, 67);
            this.flowLayoutPanel_pencarian.TabIndex = 3;
            // 
            // panel_bawah
            // 
            this.panel_bawah.Controls.Add(this.flowLayoutPanel_button);
            this.panel_bawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bawah.Location = new System.Drawing.Point(0, 527);
            this.panel_bawah.Name = "panel_bawah";
            this.panel_bawah.Size = new System.Drawing.Size(1248, 143);
            this.panel_bawah.TabIndex = 1;
            // 
            // flowLayoutPanel_button
            // 
            this.flowLayoutPanel_button.BackColor = System.Drawing.Color.LavenderBlush;
            this.flowLayoutPanel_button.Controls.Add(this.btn_kembali);
            this.flowLayoutPanel_button.Controls.Add(this.btn_edit_status);
            this.flowLayoutPanel_button.Controls.Add(this.btn_detail_transaksi);
            this.flowLayoutPanel_button.Location = new System.Drawing.Point(184, 27);
            this.flowLayoutPanel_button.Name = "flowLayoutPanel_button";
            this.flowLayoutPanel_button.Padding = new System.Windows.Forms.Padding(20, 20, 8, 8);
            this.flowLayoutPanel_button.Size = new System.Drawing.Size(714, 100);
            this.flowLayoutPanel_button.TabIndex = 0;
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
            this.btn_kembali.HoverState.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_kembali.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(128)))), ((int)(((byte)(178)))));
            this.btn_kembali.Location = new System.Drawing.Point(23, 25);
            this.btn_kembali.Margin = new System.Windows.Forms.Padding(3, 5, 75, 5);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(137, 48);
            this.btn_kembali.TabIndex = 7;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_edit_status
            // 
            this.btn_edit_status.BorderColor = System.Drawing.Color.RosyBrown;
            this.btn_edit_status.BorderRadius = 5;
            this.btn_edit_status.BorderThickness = 2;
            this.btn_edit_status.CustomBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_edit_status.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.btn_edit_status.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit_status.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit_status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit_status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit_status.FillColor = System.Drawing.Color.Tan;
            this.btn_edit_status.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_status.ForeColor = System.Drawing.Color.White;
            this.btn_edit_status.HoverState.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_edit_status.HoverState.FillColor = System.Drawing.Color.Tan;
            this.btn_edit_status.HoverState.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_edit_status.Location = new System.Drawing.Point(238, 25);
            this.btn_edit_status.Margin = new System.Windows.Forms.Padding(3, 5, 15, 5);
            this.btn_edit_status.Name = "btn_edit_status";
            this.btn_edit_status.Size = new System.Drawing.Size(137, 48);
            this.btn_edit_status.TabIndex = 8;
            this.btn_edit_status.Text = "Edit";
            this.btn_edit_status.Click += new System.EventHandler(this.btn_edit_status_Click);
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
            this.btn_detail_transaksi.Location = new System.Drawing.Point(393, 25);
            this.btn_detail_transaksi.Margin = new System.Windows.Forms.Padding(3, 5, 15, 5);
            this.btn_detail_transaksi.Name = "btn_detail_transaksi";
            this.btn_detail_transaksi.Size = new System.Drawing.Size(275, 48);
            this.btn_detail_transaksi.TabIndex = 10;
            this.btn_detail_transaksi.Text = "Detail Transaksi";
            this.btn_detail_transaksi.Click += new System.EventHandler(this.btn_detail_transaksi_Click);
            // 
            // panel_dgv_transaksi
            // 
            this.panel_dgv_transaksi.Controls.Add(this.lbl_slogan);
            this.panel_dgv_transaksi.Controls.Add(this.lbl_si_laundry);
            this.panel_dgv_transaksi.Controls.Add(this.dgv_transaksi);
            this.panel_dgv_transaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dgv_transaksi.Location = new System.Drawing.Point(0, 79);
            this.panel_dgv_transaksi.Name = "panel_dgv_transaksi";
            this.panel_dgv_transaksi.Size = new System.Drawing.Size(1248, 448);
            this.panel_dgv_transaksi.TabIndex = 2;
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
            this.lbl_slogan.Location = new System.Drawing.Point(529, 51);
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
            this.lbl_si_laundry.Location = new System.Drawing.Point(474, 9);
            this.lbl_si_laundry.Name = "lbl_si_laundry";
            this.lbl_si_laundry.Size = new System.Drawing.Size(323, 42);
            this.lbl_si_laundry.TabIndex = 8;
            this.lbl_si_laundry.Text = " Apriluxe Laundry";
            // 
            // dgv_transaksi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_transaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_transaksi.ColumnHeadersHeight = 40;
            this.dgv_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_transaksi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_transaksi.GridColor = System.Drawing.Color.HotPink;
            this.dgv_transaksi.Location = new System.Drawing.Point(37, 76);
            this.dgv_transaksi.Name = "dgv_transaksi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transaksi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_transaksi.RowHeadersVisible = false;
            this.dgv_transaksi.RowHeadersWidth = 62;
            this.dgv_transaksi.RowTemplate.Height = 28;
            this.dgv_transaksi.Size = new System.Drawing.Size(1187, 353);
            this.dgv_transaksi.TabIndex = 3;
            this.dgv_transaksi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_transaksi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_transaksi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.HotPink;
            this.dgv_transaksi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_transaksi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_transaksi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_transaksi.ThemeStyle.GridColor = System.Drawing.Color.HotPink;
            this.dgv_transaksi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.HotPink;
            this.dgv_transaksi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_transaksi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_transaksi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_transaksi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_transaksi.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_transaksi.ThemeStyle.ReadOnly = false;
            this.dgv_transaksi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_transaksi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_transaksi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_transaksi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_transaksi.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_transaksi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_transaksi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_transaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_transaksi_CellClick);
            // 
            // txt_pencarian
            // 
            this.txt_pencarian.BorderRadius = 5;
            this.txt_pencarian.BorderThickness = 2;
            this.txt_pencarian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pencarian.DefaultText = "";
            this.txt_pencarian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pencarian.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pencarian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pencarian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pencarian.FillColor = System.Drawing.Color.LightPink;
            this.txt_pencarian.FocusedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_pencarian.FocusedState.FillColor = System.Drawing.Color.LightPink;
            this.txt_pencarian.FocusedState.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pencarian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pencarian.ForeColor = System.Drawing.Color.White;
            this.txt_pencarian.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.txt_pencarian.IconRight = global::SistemLaundry.Properties.Resources.search;
            this.txt_pencarian.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txt_pencarian.IconRightSize = new System.Drawing.Size(25, 25);
            this.txt_pencarian.Location = new System.Drawing.Point(19, 12);
            this.txt_pencarian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pencarian.Name = "txt_pencarian";
            this.txt_pencarian.PlaceholderText = "";
            this.txt_pencarian.SelectedText = "";
            this.txt_pencarian.Size = new System.Drawing.Size(431, 42);
            this.txt_pencarian.TabIndex = 1;
            this.txt_pencarian.TextChanged += new System.EventHandler(this.txt_pencarian_TextChanged);
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1248, 670);
            this.Controls.Add(this.panel_dgv_transaksi);
            this.Controls.Add(this.panel_bawah);
            this.Controls.Add(this.panel_header);
            this.Name = "Transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.flowLayoutPanel_pencarian.ResumeLayout(false);
            this.panel_bawah.ResumeLayout(false);
            this.flowLayoutPanel_button.ResumeLayout(false);
            this.panel_dgv_transaksi.ResumeLayout(false);
            this.panel_dgv_transaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_pencarian;
        public Guna.UI2.WinForms.Guna2TextBox txt_pencarian;
        private System.Windows.Forms.Label lbl_transaksi;
        private Guna.UI2.WinForms.Guna2Button btn_keluar;
        private System.Windows.Forms.Panel panel_bawah;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_button;
        private System.Windows.Forms.Panel panel_dgv_transaksi;
        private Guna.UI2.WinForms.Guna2Button btn_edit_status;
        private Guna.UI2.WinForms.Guna2Button btn_detail_transaksi;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_transaksi;
        private Guna.UI2.WinForms.Guna2Button btn_kembali;
        private System.Windows.Forms.Label lbl_slogan;
        private System.Windows.Forms.Label lbl_si_laundry;
    }
}