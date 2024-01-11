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
    public partial class FormMasterFilm : Form
    {
        public FormMasterFilm()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void FormMasterFilm_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<Film> listHasil = Film.BacaData();
            foreach (Film f in listHasil)
            {
                dataGridViewHasil.Rows.Add(f.Judul, f.Tahun.ToString(), f.Durasi.ToString(), f.Kelompok.Nama, f.Bahasa, f.DiskonNominal, string.Join(",", f.FilmAktorList), string.Join(",", f.FilmGenreList));
            }

            if (dataGridViewHasil.ColumnCount == 8)
            {
                DataGridViewButtonColumn btnTambahAktor = new DataGridViewButtonColumn();
                btnTambahAktor.HeaderText = "TAMBAH AKTOR";
                btnTambahAktor.Text = "TAMBAH";
                btnTambahAktor.Name = "buttonTambahAktorGrid";
                btnTambahAktor.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(btnTambahAktor);

                DataGridViewButtonColumn btnTambahGenre = new DataGridViewButtonColumn();
                btnTambahGenre.HeaderText = "TAMBAH GENRE";
                btnTambahGenre.Text = "TAMBAH";
                btnTambahGenre.Name = "buttonTambahGenreGrid";
                btnTambahGenre.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(btnTambahGenre);
            }
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string kode = dataGridViewHasil.CurrentRow.Cells["collumnJudul"].Value.ToString();
                if (e.ColumnIndex == dataGridViewHasil.Columns["buttonTambahAktorGrid"].Index)
                {
                    FormTambahAktorFilm form = new FormTambahAktorFilm();
                    form.Owner = this;
                    form.judulFilm = kode;
                    form.ShowDialog();
                }
                else if (e.ColumnIndex == dataGridViewHasil.Columns["buttonTambahGenreGrid"].Index)
                {
                    FormTambahGenreFilm form = new FormTambahGenreFilm();
                    form.Owner = this;
                    form.judulFilm = kode;
                    form.ShowDialog();
                }
                FormMasterFilm_Load(this, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            //try
            //{
                string filter = "";
                if (comboBoxCari.SelectedIndex == 0)
                {
                    filter = "JUDUL";
                }
                else if (comboBoxCari.SelectedIndex == 1)
                {
                    filter = "TAHUN";
                }

                string nilai = textBoxCari.Text;
                List<Film> listhasil = Film.BacaData(filter, nilai);
                dataGridViewHasil.DataSource = listhasil;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error : " + ex.Message);
            //}
        }
    }
}
