namespace Celikoor_Kel14
{
    partial class FormMasterGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMasterGenre));
            this.buttonKeluar = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.buttonTambah = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.AutoRoundedCorners = true;
            this.buttonKeluar.BackColor = System.Drawing.Color.Transparent;
            this.buttonKeluar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.buttonKeluar.BorderRadius = 21;
            this.buttonKeluar.BorderThickness = 3;
            this.buttonKeluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonKeluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonKeluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonKeluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonKeluar.FillColor = System.Drawing.Color.White;
            this.buttonKeluar.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.buttonKeluar.Location = new System.Drawing.Point(435, 473);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(130, 45);
            this.buttonKeluar.TabIndex = 13;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Location = new System.Drawing.Point(37, 105);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(528, 339);
            this.dataGridViewHasil.TabIndex = 12;
            this.dataGridViewHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasil_CellContentClick);
            // 
            // buttonTambah
            // 
            this.buttonTambah.AutoRoundedCorners = true;
            this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
            this.buttonTambah.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.buttonTambah.BorderRadius = 21;
            this.buttonTambah.BorderThickness = 3;
            this.buttonTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonTambah.FillColor = System.Drawing.Color.White;
            this.buttonTambah.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.buttonTambah.Location = new System.Drawing.Point(295, 473);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(130, 45);
            this.buttonTambah.TabIndex = 14;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // FormMasterGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 599);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewHasil);
            this.DoubleBuffered = true;
            this.Name = "FormMasterGenre";
            this.Text = "FormMasterGenre";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMasterGenre_FormClosed);
            this.Load += new System.EventHandler(this.FormMasterGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private Guna.UI2.WinForms.Guna2Button buttonTambah;
    }
}