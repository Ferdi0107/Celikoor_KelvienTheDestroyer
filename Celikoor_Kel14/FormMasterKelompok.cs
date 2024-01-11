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
    public partial class FormMasterKelompok : Form
    {
        public FormMasterKelompok()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void FormMasterKelompok_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<Kelompok> listHasil = Kelompok.BacaData();
            dataGridViewHasil.DataSource = listHasil;

            if (dataGridViewHasil.ColumnCount == 2)
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
            FormTambahKelompok form = new FormTambahKelompok();
            form.Owner = this;
            form.ShowDialog();

            FormMasterKelompok_Load(this, e);
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonHapusGrid"].Index)
            {
                DialogResult hasil = MessageBox.Show("Yakin menghapus data " + kode + " ?", "HAPUS", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    Kelompok.HapusData(kode);
                    FormMasterKelompok_Load(this, e);
                }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMasterKelompok_FormClosed(object sender, FormClosedEventArgs e)
        {
            utama.MunculPanelMenu();
        }
    }
}
