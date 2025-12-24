namespace SistemLaundry.View
{
    partial class DataPelanggan
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
            this.panel_utama = new System.Windows.Forms.Panel();
            this.panel_konten = new System.Windows.Forms.Panel();
            this.panel_data_grid_view = new System.Windows.Forms.Panel();
            this.lbl_slogan = new System.Windows.Forms.Label();
            this.lbl_si_laundry = new System.Windows.Forms.Label();
            this.dgv_pelanggan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_keluar = new Guna.UI2.WinForms.Guna2Button();
            this.label_data_pelanggan = new System.Windows.Forms.Label();
            this.flowLayoutPanel_pencarian = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_kembali = new Guna.UI2.WinForms.Guna2Button();
            this.btn_hapus = new Guna.UI2.WinForms.Guna2Button();
            this.panel_bawah = new System.Windows.Forms.Panel();
            this.ShadowPanel_input = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txt_alamat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_no_hp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.lbl_no_hp = new System.Windows.Forms.Label();
            this.txt_nama_pelanggan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_nama_pelanggan = new System.Windows.Forms.Label();
            this.lbl_id_pelanggan = new System.Windows.Forms.Label();
            this.txt_id_pelanggan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_pencarian = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_utama.SuspendLayout();
            this.panel_konten.SuspendLayout();
            this.panel_data_grid_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pelanggan)).BeginInit();
            this.panel_header.SuspendLayout();
            this.flowLayoutPanel_pencarian.SuspendLayout();
            this.panel_bawah.SuspendLayout();
            this.ShadowPanel_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_utama
            // 
            this.panel_utama.BackColor = System.Drawing.Color.Pink;
            this.panel_utama.Controls.Add(this.panel_konten);
            this.panel_utama.Controls.Add(this.panel_header);
            this.panel_utama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_utama.Location = new System.Drawing.Point(0, 0);
            this.panel_utama.Name = "panel_utama";
            this.panel_utama.Size = new System.Drawing.Size(1248, 670);
            this.panel_utama.TabIndex = 0;
            // 
            // panel_konten
            // 
            this.panel_konten.Controls.Add(this.panel_data_grid_view);
            this.panel_konten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_konten.Location = new System.Drawing.Point(0, 86);
            this.panel_konten.Name = "panel_konten";
            this.panel_konten.Size = new System.Drawing.Size(1248, 584);
            this.panel_konten.TabIndex = 1;
            // 
            // panel_data_grid_view
            // 
            this.panel_data_grid_view.Controls.Add(this.panel_bawah);
            this.panel_data_grid_view.Controls.Add(this.lbl_slogan);
            this.panel_data_grid_view.Controls.Add(this.lbl_si_laundry);
            this.panel_data_grid_view.Controls.Add(this.dgv_pelanggan);
            this.panel_data_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_data_grid_view.Location = new System.Drawing.Point(0, 0);
            this.panel_data_grid_view.Name = "panel_data_grid_view";
            this.panel_data_grid_view.Size = new System.Drawing.Size(1248, 584);
            this.panel_data_grid_view.TabIndex = 0;
            // 
            // lbl_slogan
            // 
            this.lbl_slogan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_slogan.AutoSize = true;
            this.lbl_slogan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_slogan.Font = new System.Drawing.Font("Goudy Old Style", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slogan.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_slogan.Location = new System.Drawing.Point(516, 50);
            this.lbl_slogan.Name = "lbl_slogan";
            this.lbl_slogan.Size = new System.Drawing.Size(224, 23);
            this.lbl_slogan.TabIndex = 11;
            this.lbl_slogan.Text = "Clean And Fresh Laundry";
            // 
            // lbl_si_laundry
            // 
            this.lbl_si_laundry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_si_laundry.AutoSize = true;
            this.lbl_si_laundry.Font = new System.Drawing.Font("Imprint MT Shadow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_si_laundry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_si_laundry.Location = new System.Drawing.Point(443, 3);
            this.lbl_si_laundry.Name = "lbl_si_laundry";
            this.lbl_si_laundry.Size = new System.Drawing.Size(355, 47);
            this.lbl_si_laundry.TabIndex = 10;
            this.lbl_si_laundry.Text = " Apriluxe Laundry";
            // 
            // dgv_pelanggan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_pelanggan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pelanggan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pelanggan.ColumnHeadersHeight = 40;
            this.dgv_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pelanggan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_pelanggan.GridColor = System.Drawing.Color.HotPink;
            this.dgv_pelanggan.Location = new System.Drawing.Point(31, 80);
            this.dgv_pelanggan.Name = "dgv_pelanggan";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pelanggan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_pelanggan.RowHeadersVisible = false;
            this.dgv_pelanggan.RowHeadersWidth = 62;
            this.dgv_pelanggan.RowTemplate.Height = 28;
            this.dgv_pelanggan.Size = new System.Drawing.Size(1187, 258);
            this.dgv_pelanggan.TabIndex = 2;
            this.dgv_pelanggan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_pelanggan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_pelanggan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.HotPink;
            this.dgv_pelanggan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_pelanggan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_pelanggan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_pelanggan.ThemeStyle.GridColor = System.Drawing.Color.HotPink;
            this.dgv_pelanggan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.HotPink;
            this.dgv_pelanggan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_pelanggan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_pelanggan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_pelanggan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_pelanggan.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_pelanggan.ThemeStyle.ReadOnly = false;
            this.dgv_pelanggan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_pelanggan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_pelanggan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_pelanggan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_pelanggan.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_pelanggan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_pelanggan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_pelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pelanggan_CellClick);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_header.Controls.Add(this.btn_keluar);
            this.panel_header.Controls.Add(this.label_data_pelanggan);
            this.panel_header.Controls.Add(this.flowLayoutPanel_pencarian);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1248, 86);
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
            this.btn_keluar.Location = new System.Drawing.Point(1194, 12);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(42, 43);
            this.btn_keluar.TabIndex = 9;
            this.btn_keluar.Text = "X";
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // label_data_pelanggan
            // 
            this.label_data_pelanggan.AutoSize = true;
            this.label_data_pelanggan.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data_pelanggan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.label_data_pelanggan.Location = new System.Drawing.Point(12, 24);
            this.label_data_pelanggan.Name = "label_data_pelanggan";
            this.label_data_pelanggan.Size = new System.Drawing.Size(313, 33);
            this.label_data_pelanggan.TabIndex = 1;
            this.label_data_pelanggan.Text = "Kelola Data Pelanggan";
            // 
            // flowLayoutPanel_pencarian
            // 
            this.flowLayoutPanel_pencarian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_pencarian.Controls.Add(this.txt_pencarian);
            this.flowLayoutPanel_pencarian.Location = new System.Drawing.Point(684, 12);
            this.flowLayoutPanel_pencarian.Name = "flowLayoutPanel_pencarian";
            this.flowLayoutPanel_pencarian.Padding = new System.Windows.Forms.Padding(15, 7, 5, 5);
            this.flowLayoutPanel_pencarian.Size = new System.Drawing.Size(476, 67);
            this.flowLayoutPanel_pencarian.TabIndex = 1;
            // 
            // btn_edit
            // 
            this.btn_edit.BorderColor = System.Drawing.Color.Tan;
            this.btn_edit.BorderRadius = 5;
            this.btn_edit.BorderThickness = 2;
            this.btn_edit.CustomBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_edit.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit.FillColor = System.Drawing.Color.RosyBrown;
            this.btn_edit.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.HoverState.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_edit.HoverState.FillColor = System.Drawing.Color.Thistle;
            this.btn_edit.Location = new System.Drawing.Point(929, 13);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(137, 48);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.Color.Transparent;
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
            this.btn_kembali.HoverState.FillColor = System.Drawing.Color.LightPink;
            this.btn_kembali.Location = new System.Drawing.Point(929, 182);
            this.btn_kembali.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(137, 48);
            this.btn_kembali.TabIndex = 4;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BorderColor = System.Drawing.Color.RosyBrown;
            this.btn_hapus.BorderRadius = 5;
            this.btn_hapus.BorderThickness = 2;
            this.btn_hapus.CustomBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_hapus.CustomBorderThickness = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.btn_hapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hapus.FillColor = System.Drawing.Color.Maroon;
            this.btn_hapus.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.Color.White;
            this.btn_hapus.HoverState.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_hapus.HoverState.FillColor = System.Drawing.Color.Brown;
            this.btn_hapus.Location = new System.Drawing.Point(929, 101);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(137, 48);
            this.btn_hapus.TabIndex = 2;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // panel_bawah
            // 
            this.panel_bawah.Controls.Add(this.ShadowPanel_input);
            this.panel_bawah.Controls.Add(this.btn_hapus);
            this.panel_bawah.Controls.Add(this.btn_kembali);
            this.panel_bawah.Controls.Add(this.btn_edit);
            this.panel_bawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bawah.Location = new System.Drawing.Point(0, 344);
            this.panel_bawah.Name = "panel_bawah";
            this.panel_bawah.Size = new System.Drawing.Size(1248, 240);
            this.panel_bawah.TabIndex = 12;
            // 
            // ShadowPanel_input
            // 
            this.ShadowPanel_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowPanel_input.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPanel_input.Controls.Add(this.txt_alamat);
            this.ShadowPanel_input.Controls.Add(this.txt_no_hp);
            this.ShadowPanel_input.Controls.Add(this.lbl_alamat);
            this.ShadowPanel_input.Controls.Add(this.lbl_no_hp);
            this.ShadowPanel_input.Controls.Add(this.txt_nama_pelanggan);
            this.ShadowPanel_input.Controls.Add(this.lbl_nama_pelanggan);
            this.ShadowPanel_input.Controls.Add(this.lbl_id_pelanggan);
            this.ShadowPanel_input.Controls.Add(this.txt_id_pelanggan);
            this.ShadowPanel_input.FillColor = System.Drawing.Color.White;
            this.ShadowPanel_input.Location = new System.Drawing.Point(160, 13);
            this.ShadowPanel_input.Name = "ShadowPanel_input";
            this.ShadowPanel_input.ShadowColor = System.Drawing.Color.Black;
            this.ShadowPanel_input.Size = new System.Drawing.Size(729, 219);
            this.ShadowPanel_input.TabIndex = 13;
            // 
            // txt_alamat
            // 
            this.txt_alamat.BorderRadius = 5;
            this.txt_alamat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_alamat.DefaultText = "";
            this.txt_alamat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_alamat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_alamat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_alamat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_alamat.FillColor = System.Drawing.Color.Pink;
            this.txt_alamat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.txt_alamat.FocusedState.FillColor = System.Drawing.Color.LavenderBlush;
            this.txt_alamat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_alamat.ForeColor = System.Drawing.Color.DimGray;
            this.txt_alamat.HoverState.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txt_alamat.Location = new System.Drawing.Point(254, 165);
            this.txt_alamat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.PlaceholderText = "";
            this.txt_alamat.SelectedText = "";
            this.txt_alamat.Size = new System.Drawing.Size(362, 36);
            this.txt_alamat.TabIndex = 7;
            // 
            // txt_no_hp
            // 
            this.txt_no_hp.BorderRadius = 5;
            this.txt_no_hp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_no_hp.DefaultText = "";
            this.txt_no_hp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_no_hp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_no_hp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_no_hp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_no_hp.FillColor = System.Drawing.Color.Pink;
            this.txt_no_hp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.txt_no_hp.FocusedState.FillColor = System.Drawing.Color.LavenderBlush;
            this.txt_no_hp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_no_hp.ForeColor = System.Drawing.Color.DimGray;
            this.txt_no_hp.HoverState.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txt_no_hp.Location = new System.Drawing.Point(254, 119);
            this.txt_no_hp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_no_hp.Name = "txt_no_hp";
            this.txt_no_hp.PlaceholderText = "";
            this.txt_no_hp.SelectedText = "";
            this.txt_no_hp.Size = new System.Drawing.Size(362, 36);
            this.txt_no_hp.TabIndex = 6;
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.AutoSize = true;
            this.lbl_alamat.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_alamat.Location = new System.Drawing.Point(78, 180);
            this.lbl_alamat.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(149, 21);
            this.lbl_alamat.TabIndex = 5;
            this.lbl_alamat.Text = "Alamat            :";
            // 
            // lbl_no_hp
            // 
            this.lbl_no_hp.AutoSize = true;
            this.lbl_no_hp.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_hp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_no_hp.Location = new System.Drawing.Point(77, 134);
            this.lbl_no_hp.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_no_hp.Name = "lbl_no_hp";
            this.lbl_no_hp.Size = new System.Drawing.Size(150, 21);
            this.lbl_no_hp.TabIndex = 4;
            this.lbl_no_hp.Text = "No. Hp            :";
            // 
            // txt_nama_pelanggan
            // 
            this.txt_nama_pelanggan.BorderRadius = 5;
            this.txt_nama_pelanggan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nama_pelanggan.DefaultText = "";
            this.txt_nama_pelanggan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nama_pelanggan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nama_pelanggan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nama_pelanggan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nama_pelanggan.FillColor = System.Drawing.Color.Pink;
            this.txt_nama_pelanggan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.txt_nama_pelanggan.FocusedState.FillColor = System.Drawing.Color.LavenderBlush;
            this.txt_nama_pelanggan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nama_pelanggan.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nama_pelanggan.HoverState.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txt_nama_pelanggan.Location = new System.Drawing.Point(254, 73);
            this.txt_nama_pelanggan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nama_pelanggan.Name = "txt_nama_pelanggan";
            this.txt_nama_pelanggan.PlaceholderText = "";
            this.txt_nama_pelanggan.SelectedText = "";
            this.txt_nama_pelanggan.Size = new System.Drawing.Size(362, 36);
            this.txt_nama_pelanggan.TabIndex = 3;
            // 
            // lbl_nama_pelanggan
            // 
            this.lbl_nama_pelanggan.AutoSize = true;
            this.lbl_nama_pelanggan.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama_pelanggan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_nama_pelanggan.Location = new System.Drawing.Point(77, 88);
            this.lbl_nama_pelanggan.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_nama_pelanggan.Name = "lbl_nama_pelanggan";
            this.lbl_nama_pelanggan.Size = new System.Drawing.Size(149, 21);
            this.lbl_nama_pelanggan.TabIndex = 2;
            this.lbl_nama_pelanggan.Text = "Nama              :";
            // 
            // lbl_id_pelanggan
            // 
            this.lbl_id_pelanggan.AutoSize = true;
            this.lbl_id_pelanggan.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_pelanggan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.lbl_id_pelanggan.Location = new System.Drawing.Point(77, 42);
            this.lbl_id_pelanggan.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbl_id_pelanggan.Name = "lbl_id_pelanggan";
            this.lbl_id_pelanggan.Size = new System.Drawing.Size(152, 21);
            this.lbl_id_pelanggan.TabIndex = 0;
            this.lbl_id_pelanggan.Text = "Id Pelanggan    :";
            // 
            // txt_id_pelanggan
            // 
            this.txt_id_pelanggan.BorderRadius = 5;
            this.txt_id_pelanggan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_pelanggan.DefaultText = "";
            this.txt_id_pelanggan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id_pelanggan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id_pelanggan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id_pelanggan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id_pelanggan.FillColor = System.Drawing.Color.Pink;
            this.txt_id_pelanggan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.txt_id_pelanggan.FocusedState.FillColor = System.Drawing.Color.LavenderBlush;
            this.txt_id_pelanggan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id_pelanggan.ForeColor = System.Drawing.Color.DimGray;
            this.txt_id_pelanggan.HoverState.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txt_id_pelanggan.Location = new System.Drawing.Point(254, 27);
            this.txt_id_pelanggan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id_pelanggan.Name = "txt_id_pelanggan";
            this.txt_id_pelanggan.PlaceholderText = "";
            this.txt_id_pelanggan.SelectedText = "";
            this.txt_id_pelanggan.Size = new System.Drawing.Size(235, 36);
            this.txt_id_pelanggan.TabIndex = 1;
            // 
            // txt_pencarian
            // 
            this.txt_pencarian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txt_pencarian.FocusedState.FillColor = System.Drawing.Color.White;
            this.txt_pencarian.FocusedState.ForeColor = System.Drawing.Color.RosyBrown;
            this.txt_pencarian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pencarian.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pencarian.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.txt_pencarian.IconRight = global::SistemLaundry.Properties.Resources.search;
            this.txt_pencarian.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txt_pencarian.Location = new System.Drawing.Point(19, 12);
            this.txt_pencarian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pencarian.Name = "txt_pencarian";
            this.txt_pencarian.PlaceholderText = "";
            this.txt_pencarian.SelectedText = "";
            this.txt_pencarian.Size = new System.Drawing.Size(431, 42);
            this.txt_pencarian.TabIndex = 1;
            this.txt_pencarian.TextChanged += new System.EventHandler(this.txt_pencarian_TextChanged);
            // 
            // DataPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 670);
            this.Controls.Add(this.panel_utama);
            this.Name = "DataPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataPelanggan";
            this.Load += new System.EventHandler(this.DataPelanggan_Load);
            this.panel_utama.ResumeLayout(false);
            this.panel_konten.ResumeLayout(false);
            this.panel_data_grid_view.ResumeLayout(false);
            this.panel_data_grid_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pelanggan)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.flowLayoutPanel_pencarian.ResumeLayout(false);
            this.panel_bawah.ResumeLayout(false);
            this.ShadowPanel_input.ResumeLayout(false);
            this.ShadowPanel_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_utama;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_pencarian;
        public Guna.UI2.WinForms.Guna2TextBox txt_pencarian;
        private System.Windows.Forms.Label label_data_pelanggan;
        private System.Windows.Forms.Panel panel_konten;
        private System.Windows.Forms.Panel panel_data_grid_view;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_pelanggan;
        private Guna.UI2.WinForms.Guna2Button btn_keluar;
        private System.Windows.Forms.Label lbl_slogan;
        private System.Windows.Forms.Label lbl_si_laundry;
        private Guna.UI2.WinForms.Guna2Button btn_hapus;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_kembali;
        private System.Windows.Forms.Panel panel_bawah;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel_input;
        public Guna.UI2.WinForms.Guna2TextBox txt_alamat;
        public Guna.UI2.WinForms.Guna2TextBox txt_no_hp;
        private System.Windows.Forms.Label lbl_alamat;
        private System.Windows.Forms.Label lbl_no_hp;
        public Guna.UI2.WinForms.Guna2TextBox txt_nama_pelanggan;
        private System.Windows.Forms.Label lbl_nama_pelanggan;
        private System.Windows.Forms.Label lbl_id_pelanggan;
        public Guna.UI2.WinForms.Guna2TextBox txt_id_pelanggan;
    }
}