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
    public partial class FormMasterKonsumen : Form
    {
        public FormMasterKonsumen()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void buttonCari_Click(object sender, EventArgs e)
        {
            string filter = "";
            if (comboBoxCari.SelectedIndex == 0)
            {
                filter = "Username";
            }
            else if (comboBoxCari.SelectedIndex == 1)
            {
                filter = "Nama";
            }

            string nilai = textBoxCari.Text;
            
            if (filter != "" && nilai != "")
            {
                List<Konsumen> listHasil = Konsumen.BacaData(filter, nilai);
                dataGridViewHasil.DataSource = listHasil;
            }
            else
            {
                MessageBox.Show("Data harus diisi");
            }
        }

        private void FormMasterKonsumen_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<Konsumen> listHasil = Konsumen.BacaData();
            dataGridViewHasil.DataSource = listHasil;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMasterKonsumen_FormClosed(object sender, FormClosedEventArgs e)
        {
            utama.MunculPanelMenu();
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
