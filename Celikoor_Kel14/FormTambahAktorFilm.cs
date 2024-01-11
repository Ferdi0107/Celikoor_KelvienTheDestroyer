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
    public partial class FormTambahAktorFilm : Form
    {
        public FormTambahAktorFilm()
        {
            InitializeComponent();
        }
        FormUtama utama;
        public string judulFilm;
        Film filmPilihan;
        private void FormTambahAktorFilm_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;

            List<Film> listFilm = Film.BacaDataFilm("f.judul", judulFilm);
            filmPilihan = listFilm[0];

            labelJudul.Text = filmPilihan.Judul;
            labelTahun.Text = filmPilihan.Tahun.ToString();
            labelDurasi.Text = filmPilihan.Durasi.ToString();

            List<Aktor> listAktor = Aktor.BacaData();
            comboBoxAktor.DataSource = listAktor;
            comboBoxAktor.DisplayMember = "Nama";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                FilmAktor filmAktor = new FilmAktor();
                filmAktor.Film = filmPilihan;
                filmAktor.Aktor = (Aktor)comboBoxAktor.SelectedItem;
                filmAktor.Peran = comboBoxPeran.SelectedItem.ToString();

                FilmAktor.TambahData(filmAktor);
                MessageBox.Show("Input Aktor Film berhasil.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input gagal. Error: " + ex.Message);
            }
        }
    }
}
