using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KelvienTheDestroyerLIB;

namespace Celikoor_Kel14
{
    public partial class FormBeliTiket : Form
    {
        public FormBeliTiket()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormBeliTiket"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormBeliTiket formTiket = new FormBeliTiket();
                formTiket.MdiParent = this;
                formTiket.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void FormBeliTiket_Load(object sender, EventArgs e)
        {
            List<Film> listFilm = Film.BacaData();
            comboBoxJudul.DataSource = listFilm;
            comboBoxJudul.DisplayMember = "Judul";

            List<Cinema> listCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "NamaCabang";
        }
    }
}
