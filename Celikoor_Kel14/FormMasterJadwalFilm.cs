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
    public partial class FormMasterJadwalFilm : Form
    {
        public FormMasterJadwalFilm()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void FormMasterJadwalFilm_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<JadwalFilm> listHasil = JadwalFilm.BacaData();
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
                    JadwalFilm.HapusData(kode);
                    FormMasterJadwalFilm_Load(this, e);
                }
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahJadwalFilm form = new FormTambahJadwalFilm();
            form.Owner = this;
            form.ShowDialog();

            FormMasterJadwalFilm_Load(this, e);
        }
    }
}
