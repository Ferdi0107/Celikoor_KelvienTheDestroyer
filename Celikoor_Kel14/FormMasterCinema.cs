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
    public partial class FormMasterCinema : Form
    {
        public FormMasterCinema()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void FormMasterCinema_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<Cinema> listHasil = Cinema.BacaData();
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

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahCinema form = new FormTambahCinema();
            form.Owner = this;
            form.ShowDialog();

            FormMasterCinema_Load(this, e);
        }

        private void FormMasterCinema_FormClosed(object sender, FormClosedEventArgs e)
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
                    Cinema.HapusData(kode);
                    FormMasterCinema_Load(this, e);
                }
            }
        }
    }
}
