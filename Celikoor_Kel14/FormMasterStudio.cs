using KelvienTheDestroyerLIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Kel14
{
    public partial class FormMasterStudio : Form
    {
        public FormMasterStudio()
        {
            InitializeComponent();
        }
        FormUtama utama;
        public string kode;
        private void FormMasterStudio_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<Studio> listHasil = Studio.BacaData();
            dataGridViewHasil.DataSource = listHasil;

            if (dataGridViewHasil.ColumnCount == 7)
            {
                DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                btnDel.HeaderText = "AKSI";
                btnDel.Text = "HAPUS";
                btnDel.Name = "buttonHapusGrid";
                btnDel.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(btnDel);

                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                btnUbah.HeaderText = "AKSI";
                btnUbah.Text = "UBAH";
                btnUbah.Name = "buttonUbahGrid";
                btnUbah.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(btnUbah);
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahStudio form = new FormTambahStudio();
            form.Owner = this;
            form.ShowDialog();

            FormMasterStudio_Load(this, e);
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kode = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonHapusGrid"].Index)
            {
                DialogResult hasil = MessageBox.Show("Yakin menghapus data " + kode + " ?", "HAPUS", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    Studio.HapusData(kode);
                    FormMasterStudio_Load(this, e);
                }
            }
            else if (e.ColumnIndex == dataGridViewHasil.Columns["buttonUbahGrid"].Index)
            {
                FormUbahStudio form = new FormUbahStudio();
                form.Owner = this;
                form.ShowDialog();

                FormMasterStudio_Load(this, e);
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = "";
                if (comboBoxCari.SelectedIndex == 0)
                {
                    filter = "ID";
                }
                else if (comboBoxCari.SelectedIndex == 1)
                {
                    filter = "NAMA";
                }

                string nilai = textBoxCari.Text;
                List<Studio> listhasil = Studio.BacaData(filter, nilai);
                dataGridViewHasil.DataSource = listhasil;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
