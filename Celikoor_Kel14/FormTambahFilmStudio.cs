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
    public partial class FormTambahFilmStudio : Form
    {
        public FormTambahFilmStudio()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void FormTambahFilmStudio_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;

            List<Film> listFilm = Film.BacaData();
            comboBoxFilm.DataSource = listFilm;
            comboBoxFilm.DisplayMember = "Nama";

            List<Studio> listStudio = Studio.BacaData();
            comboBoxFilm.DataSource = listStudio;
            comboBoxFilm.DisplayMember = "Nama";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                FilmStudio tambah = new FilmStudio();
                tambah.Studio = (Studio)comboBoxStudio.SelectedItem;
                tambah.Film = (Film)comboBoxFilm.SelectedItem;

                FilmStudio.TambahData(tambah);
                MessageBox.Show("Input berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input gagal. Error: " + ex.Message);
            }

        }
    }
}
