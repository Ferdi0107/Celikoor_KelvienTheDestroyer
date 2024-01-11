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
    public partial class FormTambahGenreFilm : Form
    {
        public FormTambahGenreFilm()
        {
            InitializeComponent();
        }
        FormUtama utama;
        public string judulFilm;
        public Film filmPilihan;
        private void FormTambahGenreFilm_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.Owner.MdiParent;

            List<Genre> listGenre = Genre.BacaData();
            comboBoxGenre.DataSource = listGenre;
            comboBoxGenre.DisplayMember = "Nama";

            List<Film> listFilm = Film.BacaDataFilm("f.judul", judulFilm);
            filmPilihan = listFilm[0];
            
            labelJudul.Text = judulFilm;
            labelTahun.Text = filmPilihan.Tahun.ToString();
            labelBahasa.Text = filmPilihan.Bahasa;
            labelDurasi.Text = filmPilihan.Durasi.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                FilmGenre filmGenre = new FilmGenre();
                filmGenre.Film = filmPilihan;
                filmGenre.Genre = (Genre)comboBoxGenre.SelectedItem;

                FilmGenre.TambahData(filmGenre);
                MessageBox.Show("Input berhasil.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input gagal. Error: " + ex.Message);
            }
        }
    }
}
