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
    public partial class FormMasterAktor : Form
    {
        public FormMasterAktor()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void buttonCari_Click(object sender, EventArgs e)
        {
            try
            {
                string nilai = textBoxCari.Text;
                if (nilai != "")
                {
                    List<Aktor> listHasil = Aktor.BacaData(nilai);
                    dataGridViewHasil.DataSource = listHasil;
                }
                else
                {
                    MessageBox.Show("Data harus diisi");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :"+ex.Message);
            }
        }

        private void FormMasterAktor_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<Aktor> listHasil = Aktor.BacaData();
            dataGridViewHasil.DataSource = listHasil;

            if (dataGridViewHasil.ColumnCount == 5)
            {
                DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                btnDel.HeaderText = "AKSI";
                btnDel.Text = "HAPUS";
                btnDel.Name = "buttonHapusGrid";
                btnDel.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(btnDel);
            }
        }

        private void FormMasterAktor_FormClosed(object sender, FormClosedEventArgs e)
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
                    Aktor.HapusData(kode);
                    FormMasterAktor_Load(this, e);
                }
            }
        }
    }
}
