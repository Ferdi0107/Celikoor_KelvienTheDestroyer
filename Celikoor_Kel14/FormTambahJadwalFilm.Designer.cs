namespace Celikoor_Kel14
{
    partial class FormTambahJadwalFilm
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxJam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerTanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.guna2Button1.BorderRadius = 24;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.guna2Button1.Location = new System.Drawing.Point(141, 249);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(195, 51);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Confirm";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // comboBoxJam
            // 
            this.comboBoxJam.AutoRoundedCorners = true;
            this.comboBoxJam.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxJam.BorderRadius = 17;
            this.comboBoxJam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxJam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.comboBoxJam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxJam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxJam.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJam.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxJam.ItemHeight = 30;
            this.comboBoxJam.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.comboBoxJam.Location = new System.Drawing.Point(34, 186);
            this.comboBoxJam.Name = "comboBoxJam";
            this.comboBoxJam.Size = new System.Drawing.Size(163, 36);
            this.comboBoxJam.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Jam Pemutaran";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 43);
            this.label13.TabIndex = 0;
            this.label13.Text = "Input Jadwal";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePickerTanggal);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.comboBoxJam);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(150, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 327);
            this.panel2.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tanggal Pemutaran";
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.AutoRoundedCorners = true;
            this.dateTimePickerTanggal.BorderRadius = 17;
            this.dateTimePickerTanggal.Checked = true;
            this.dateTimePickerTanggal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.dateTimePickerTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerTanggal.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePickerTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(34, 121);
            this.dateTimePickerTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerTanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(205, 36);
            this.dateTimePickerTanggal.TabIndex = 23;
            this.dateTimePickerTanggal.Value = new System.DateTime(2023, 11, 30, 20, 23, 39, 83);
            // 
            // FormTambahJadwalFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "FormTambahJadwalFilm";
            this.Text = "FormTambahJadwalFilm";
            this.Load += new System.EventHandler(this.FormTambahJadwalFilm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxJam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.Label label12;
    }
}