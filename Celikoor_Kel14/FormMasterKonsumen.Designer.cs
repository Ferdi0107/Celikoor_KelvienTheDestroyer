namespace Celikoor_Kel14
{
    partial class FormMasterKonsumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMasterKonsumen));
            this.buttonKeluar = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCari = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxCari = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
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
            this.buttonKeluar.Location = new System.Drawing.Point(737, 467);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(130, 45);
            this.buttonKeluar.TabIndex = 10;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.groupBox1.Controls.Add(this.buttonCari);
            this.groupBox1.Controls.Add(this.textBoxCari);
            this.groupBox1.Controls.Add(this.comboBoxCari);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(808, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // buttonCari
            // 
            this.buttonCari.AutoRoundedCorners = true;
            this.buttonCari.BackColor = System.Drawing.Color.Transparent;
            this.buttonCari.BorderRadius = 21;
            this.buttonCari.BorderThickness = 3;
            this.buttonCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCari.FillColor = System.Drawing.Color.White;
            this.buttonCari.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.ForeColor = System.Drawing.Color.Black;
            this.buttonCari.Location = new System.Drawing.Point(681, 38);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(104, 45);
            this.buttonCari.TabIndex = 3;
            this.buttonCari.Text = "Cari";
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // textBoxCari
            // 
            this.textBoxCari.AutoRoundedCorners = true;
            this.textBoxCari.BackColor = System.Drawing.Color.Transparent;
            this.textBoxCari.BorderRadius = 19;
            this.textBoxCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCari.DefaultText = "";
            this.textBoxCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCari.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCari.Location = new System.Drawing.Point(280, 38);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.PasswordChar = '\0';
            this.textBoxCari.PlaceholderText = "";
            this.textBoxCari.SelectedText = "";
            this.textBoxCari.Size = new System.Drawing.Size(372, 40);
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
            "Username",
            "Nama"});
            this.comboBoxCari.Location = new System.Drawing.Point(101, 38);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(126, 36);
            this.comboBoxCari.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari :";
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Location = new System.Drawing.Point(59, 221);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(808, 216);
            this.dataGridViewHasil.TabIndex = 8;
            this.dataGridViewHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasil_CellContentClick);
            // 
            // FormMasterKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(926, 558);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewHasil);
            this.DoubleBuffered = true;
            this.Name = "FormMasterKonsumen";
            this.Text = "FormMasterKonsumen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMasterKonsumen_FormClosed);
            this.Load += new System.EventHandler(this.FormMasterKonsumen_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonKeluar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button buttonCari;
        private Guna.UI2.WinForms.Guna2TextBox textBoxCari;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
    }
}