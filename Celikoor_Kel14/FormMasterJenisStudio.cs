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
    public partial class FormMasterJenisStudio : Form
    {
        public FormMasterJenisStudio()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void FormMasterJenisStudio_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<JenisStudio> listHasil = JenisStudio.BacaData();
            dataGridViewHasil.DataSource = listHasil;

            if (dataGridViewHasil.ColumnCount == 3)
            {
                DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                btnDel.HeaderText = "AKSI";
                btnDel.Text = "HAPUS";
                btnDel.Name = "buttonHapusGrid";
                btnDel.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(btnDel);
            }
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonHapusGrid"].Index)
            {
                DialogResult hasil = MessageBox.Show("Yakin menghapus data " + kode + " ?", "HAPUS", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    JenisStudio.HapusData(kode);
                    FormMasterJenisStudio_Load(this, e);
                }
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahJenisStudio form = new FormTambahJenisStudio();
            form.Owner = this;
            form.ShowDialog();

            FormMasterJenisStudio_Load(this, e);
        }
    }
}
