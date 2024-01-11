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
    public partial class FormPenjadwalanFilm : Form
    {
        public FormPenjadwalanFilm()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        FormUtama utama;
        Film filmPilih;
        Cinema cinemaPilih;
        private void FormPenjadwalanFilm_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<SesiFilm> listSesiFilm = SesiFilm.BacaData();
            foreach(SesiFilm sf in listSesiFilm)
            {
                dataGridView1.Rows.Add(sf.FilmStudio.Film.Judul, string.Join(",", sf.FilmStudio.Film.FilmGenreList), 
                    sf.FilmStudio.Film.Kelompok.Nama, sf.FilmStudio.Studio.Cinema.NamaCabang,
                    sf.FilmStudio.Studio.Nama, sf.Sesi.Tanggal.ToString(), sf.Sesi.JamPemutaran);
            }

            List<Cinema> listCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "NamaCabang";

            List<Film> listFilm = Film.BacaDataFilm();
            comboBoxJudul.DataSource = listFilm;
            comboBoxJudul.DisplayMember = "Judul";
        }

        private void comboBoxJudul_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            cinemaPilih = (Cinema)comboBoxCinema.SelectedItem;
            List<Studio> listStudio = Studio.BacaData("s.cinemas_id", cinemaPilih.Id.ToString());
            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.DisplayMember = "Nama";
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                JadwalFilm jadwalBaru = new JadwalFilm();
                jadwalBaru.Tanggal = guna2DateTimePicker1.Value;
                if (checkBox1.Checked)
                {
                    jadwalBaru.JamPemutaran = "I";
                }
                else if (checkBox2.Checked)
                {
                    jadwalBaru.JamPemutaran = "II";
                }
                else if (checkBox3.Checked)
                {
                    jadwalBaru.JamPemutaran = "III";
                }
                else if (checkBox4.Checked)
                {
                    jadwalBaru.JamPemutaran = "IV";
                }
                SesiFilm sesiFilm = new SesiFilm();
                sesiFilm.Sesi = jadwalBaru;
                sesiFilm.FilmStudio.Film = filmPilih;
                sesiFilm.FilmStudio.Studio = (Studio)comboBoxStudio.SelectedItem;

                SesiFilm.TambahData(sesiFilm);
                MessageBox.Show("Penjadwalan berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penjadwalan gagal. Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Studio studioPilih = (Studio)comboBoxStudio.SelectedItem;
            labelJenis.Text = studioPilih.Jenis.Nama;
            labelWeekday.Text = studioPilih.HargaWeekday.ToString();
            labelWeekend.Text = studioPilih.HargaWeekend.ToString();
        }
    }
}
