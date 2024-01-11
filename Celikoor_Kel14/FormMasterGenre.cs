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
    public partial class FormMasterGenre : Form
    {
        public FormMasterGenre()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void FormMasterGenre_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<Genre> listHasil = Genre.BacaData();
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

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahGenre form = new FormTambahGenre();
            form.Owner = this;
            form.ShowDialog();

            FormMasterGenre_Load(this, e);
        }

        private void FormMasterGenre_FormClosed(object sender, FormClosedEventArgs e)
        {
            utama.MunculPanelMenu();
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonHapusGrid"].Index)
            {
                DialogResult hasil = MessageBox.Show("Yakin menghapus data " + kode + " ?", "HAPUS", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    Genre.HapusData(kode);
                    FormMasterGenre_Load(this, e);
                }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
