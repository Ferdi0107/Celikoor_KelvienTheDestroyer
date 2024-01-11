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
    public partial class FormMasterPegawai : Form
    {
        public FormMasterPegawai()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void buttonCari_Click(object sender, EventArgs e)
        {
            string filter = "";
            if (comboBoxCari.SelectedIndex == 0)
            {
                filter = "OPERATOR";
            }
            else if (comboBoxCari.SelectedIndex == 1)
            {
                filter = "ADMIN";
            }
            else if (comboBoxCari.SelectedIndex == 2)
            {
                filter = "KASIR";
            }

            string nilai = textBoxCari.Text;
            if (filter != "" && nilai != "")
            {
                List<Pegawai> listHasil = Pegawai.BacaData(filter, nilai, 1);
                dataGridViewHasil.DataSource = listHasil;
            }
            else
            {
                MessageBox.Show("Data harus diisi");
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormRegisterPegawai form = new FormRegisterPegawai();
            form.Owner = this;
            form.ShowDialog();

            FormMasterPegawai_Load(this, e);
        }

        private void FormMasterPegawai_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<Pegawai> listHasil = Pegawai.BacaData();
            dataGridViewHasil.DataSource = listHasil;

            if (dataGridViewHasil.ColumnCount == 6)
            {
                DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                btnDel.HeaderText = "AKSI";
                btnDel.Text = "HAPUS";
                btnDel.Name = "buttonHapusGrid";
                btnDel.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(btnDel);
            }
        }

        private void FormMasterPegawai_FormClosed(object sender, FormClosedEventArgs e)
        {
            utama.MunculPanelMenu();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonHapusGrid"].Index)
            {
                DialogResult hasil = MessageBox.Show("Yakin menghapus data " + kode + " ?", "HAPUS", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    Pegawai.HapusData(kode);
                    FormMasterPegawai_Load(this, e);
                }
            }
        }
    }
}
