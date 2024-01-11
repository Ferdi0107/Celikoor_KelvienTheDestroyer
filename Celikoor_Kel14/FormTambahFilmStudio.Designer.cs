namespace Celikoor_Kel14
{
    partial class FormTambahFilmStudio
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
            this.comboBoxStudio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxFilm = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.guna2Button1.Location = new System.Drawing.Point(147, 200);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(195, 51);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Confirm";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // comboBoxStudio
            // 
            this.comboBoxStudio.AutoRoundedCorners = true;
            this.comboBoxStudio.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxStudio.BorderRadius = 17;
            this.comboBoxStudio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxStudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.comboBoxStudio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxStudio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxStudio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxStudio.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxStudio.ItemHeight = 30;
            this.comboBoxStudio.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.comboBoxStudio.Location = new System.Drawing.Point(304, 118);
            this.comboBoxStudio.Name = "comboBoxStudio";
            this.comboBoxStudio.Size = new System.Drawing.Size(163, 36);
            this.comboBoxStudio.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(307, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Studio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Film";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(260, 43);
            this.label13.TabIndex = 0;
            this.label13.Text = "Input Film Studio";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxFilm);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.comboBoxStudio);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(269, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 276);
            this.panel2.TabIndex = 25;
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.AutoRoundedCorners = true;
            this.comboBoxFilm.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxFilm.BorderRadius = 17;
            this.comboBoxFilm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.comboBoxFilm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxFilm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxFilm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxFilm.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxFilm.ItemHeight = 30;
            this.comboBoxFilm.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.comboBoxFilm.Location = new System.Drawing.Point(34, 118);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(163, 36);
            this.comboBoxFilm.TabIndex = 23;
            // 
            // FormTambahFilmStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 495);
            this.Controls.Add(this.panel2);
            this.Name = "FormTambahFilmStudio";
            this.Text = "FormTambahFilmStudio";
            this.Load += new System.EventHandler(this.FormTambahFilmStudio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxStudio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxFilm;
    }
}