namespace Celikoor_Kel14
{
    partial class FormMasterFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMasterFilm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCari = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxCari = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new Guna.UI2.WinForms.Guna2Button();
            this.buttonTambah = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.collumnJudul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnTahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnDurasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnKelompok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnBahasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnDiskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnAktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.groupBox1.Controls.Add(this.buttonCari);
            this.groupBox1.Controls.Add(this.textBoxCari);
            this.groupBox1.Controls.Add(this.comboBoxCari);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(716, 85);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // buttonCari
            // 
            this.buttonCari.AutoRoundedCorners = true;
            this.buttonCari.BackColor = System.Drawing.Color.Transparent;
            this.buttonCari.BorderRadius = 17;
            this.buttonCari.BorderThickness = 3;
            this.buttonCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCari.FillColor = System.Drawing.Color.White;
            this.buttonCari.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.ForeColor = System.Drawing.Color.Black;
            this.buttonCari.Location = new System.Drawing.Point(568, 32);
            this.buttonCari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(78, 37);
            this.buttonCari.TabIndex = 3;
            this.buttonCari.Text = "Cari";
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // textBoxCari
            // 
            this.textBoxCari.AutoRoundedCorners = true;
            this.textBoxCari.BackColor = System.Drawing.Color.Transparent;
            this.textBoxCari.BorderRadius = 15;
            this.textBoxCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCari.DefaultText = "";
            this.textBoxCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCari.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCari.Location = new System.Drawing.Point(268, 32);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.PasswordChar = '\0';
            this.textBoxCari.PlaceholderText = "";
            this.textBoxCari.SelectedText = "";
            this.textBoxCari.Size = new System.Drawing.Size(279, 32);
            this.textBoxCari.TabIndex = 3;
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.AutoRoundedCorners = true;
            this.comboBoxCari.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCari.BorderColor = System.Drawing.Color.White;
            this.comboBoxCari.BorderRadius = 17;
            this.comboBoxCari.BorderThickness = 2;
            this.comboBoxCari.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCari.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCari.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F);
            this.comboBoxCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxCari.ItemHeight = 30;
            this.comboBoxCari.Items.AddRange(new object[] {
            "JUDUL",
            "TAHUN"});
            this.comboBoxCari.Location = new System.Drawing.Point(134, 32);
            this.comboBoxCari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(96, 36);
            this.comboBoxCari.TabIndex = 4;
            this.comboBoxCari.SelectedIndexChanged += new System.EventHandler(this.comboBoxCari_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari :";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.AutoRoundedCorners = true;
            this.buttonKeluar.BackColor = System.Drawing.Color.Transparent;
            this.buttonKeluar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.buttonKeluar.BorderRadius = 17;
            this.buttonKeluar.BorderThickness = 3;
            this.buttonKeluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonKeluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonKeluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonKeluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonKeluar.FillColor = System.Drawing.Color.White;
            this.buttonKeluar.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.buttonKeluar.Location = new System.Drawing.Point(665, 414);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(98, 37);
            this.buttonKeluar.TabIndex = 14;
            this.buttonKeluar.Text = "Keluar";
            // 
            // buttonTambah
            // 
            this.buttonTambah.AutoRoundedCorners = true;
            this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
            this.buttonTambah.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.buttonTambah.BorderRadius = 17;
            this.buttonTambah.BorderThickness = 3;
            this.buttonTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonTambah.FillColor = System.Drawing.Color.White;
            this.buttonTambah.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.buttonTambah.Location = new System.Drawing.Point(548, 414);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(103, 37);
            this.buttonTambah.TabIndex = 13;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collumnJudul,
            this.collumnTahun,
            this.collumnDurasi,
            this.collumnKelompok,
            this.collumnBahasa,
            this.collumnDiskon,
            this.collumnAktor,
            this.collumnGenre});
            this.dataGridViewHasil.Location = new System.Drawing.Point(47, 209);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(716, 176);
            this.dataGridViewHasil.TabIndex = 12;
            this.dataGridViewHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasil_CellContentClick);
            // 
            // collumnJudul
            // 
            this.collumnJudul.HeaderText = "Judul Film";
            this.collumnJudul.MinimumWidth = 6;
            this.collumnJudul.Name = "collumnJudul";
            this.collumnJudul.ReadOnly = true;
            this.collumnJudul.Width = 125;
            // 
            // collumnTahun
            // 
            this.collumnTahun.HeaderText = "Tahun Rilis";
            this.collumnTahun.MinimumWidth = 6;
            this.collumnTahun.Name = "collumnTahun";
            this.collumnTahun.ReadOnly = true;
            this.collumnTahun.Width = 125;
            // 
            // collumnDurasi
            // 
            this.collumnDurasi.HeaderText = "Durasi";
            this.collumnDurasi.MinimumWidth = 6;
            this.collumnDurasi.Name = "collumnDurasi";
            this.collumnDurasi.ReadOnly = true;
            this.collumnDurasi.Width = 125;
            // 
            // collumnKelompok
            // 
            this.collumnKelompok.HeaderText = "Kelompok";
            this.collumnKelompok.MinimumWidth = 6;
            this.collumnKelompok.Name = "collumnKelompok";
            this.collumnKelompok.ReadOnly = true;
            this.collumnKelompok.Width = 125;
            // 
            // collumnBahasa
            // 
            this.collumnBahasa.HeaderText = "Bahasa";
            this.collumnBahasa.MinimumWidth = 6;
            this.collumnBahasa.Name = "collumnBahasa";
            this.collumnBahasa.ReadOnly = true;
            this.collumnBahasa.Width = 125;
            // 
            // collumnDiskon
            // 
            this.collumnDiskon.HeaderText = "Diskon Nominal";
            this.collumnDiskon.MinimumWidth = 6;
            this.collumnDiskon.Name = "collumnDiskon";
            this.collumnDiskon.ReadOnly = true;
            this.collumnDiskon.Width = 125;
            // 
            // collumnAktor
            // 
            this.collumnAktor.HeaderText = "Aktor";
            this.collumnAktor.MinimumWidth = 6;
            this.collumnAktor.Name = "collumnAktor";
            this.collumnAktor.ReadOnly = true;
            this.collumnAktor.Width = 125;
            // 
            // collumnGenre
            // 
            this.collumnGenre.HeaderText = "Genre";
            this.collumnGenre.MinimumWidth = 6;
            this.collumnGenre.Name = "collumnGenre";
            this.collumnGenre.ReadOnly = true;
            this.collumnGenre.Width = 125;
            // 
            // FormMasterFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewHasil);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMasterFilm";
            this.Text = "FormMasterFilm";
            this.Load += new System.EventHandler(this.FormMasterFilm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button buttonCari;
        private Guna.UI2.WinForms.Guna2TextBox textBoxCari;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCari;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonKeluar;
        private Guna.UI2.WinForms.Guna2Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnJudul;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnTahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnDurasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnKelompok;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnBahasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnDiskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnAktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnGenre;
    }
}