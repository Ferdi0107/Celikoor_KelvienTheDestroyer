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
    public partial class FormTambahFilm : Form
    {
        public FormTambahFilm()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void label9_Click(object sender, EventArgs e)
        {

        }
        List<Film> listFilm;
        private void FormTambahFilm_Load(object sender, EventArgs e)
        {
            listFilm = Film.BacaDataFilm();
            dataGridView1.DataSource = listFilm;

            utama = (FormUtama)this.MdiParent;
            List<Kelompok> listKelompok = Kelompok.BacaData();
            comboBoxKelompok.DataSource = listKelompok;
            comboBoxKelompok.DisplayMember = "Nama";

            if (dataGridView1.ColumnCount == 8)
            {
                DataGridViewButtonColumn btnTambahAktor = new DataGridViewButtonColumn();
                btnTambahAktor.HeaderText = "AKSI";
                btnTambahAktor.Text = "TAMBAH";
                btnTambahAktor.Name = "buttonTambahAktorGrid";
                btnTambahAktor.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnTambahAktor);

                DataGridViewButtonColumn btnTambahGenre = new DataGridViewButtonColumn();
                btnTambahGenre.HeaderText = "AKSI";
                btnTambahGenre.Text = "TAMBAH";
                btnTambahGenre.Name = "buttonTambahGenreGrid";
                btnTambahGenre.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnTambahGenre);
            }
        }

        private void ButtonSimpan_Click_1(object sender, EventArgs e)
        {
            try
            {
                Film tambah = new Film();
                tambah.Judul = textBoxJudul.Text;
                tambah.Bahasa = comboBoxBahasa.SelectedValue.ToString();
                if (radioButtonYes.Checked )
                {
                    tambah.SubIndo = true;
                }
                else if (radioButtonNo.Checked )
                {
                    tambah.SubIndo = false;
                }
                tambah.Sinopsis = textBoxSinopsis.Text;
                tambah.Durasi = int.Parse(textBoxDurasi.Text);
                tambah.Kelompok = (Kelompok)comboBoxKelompok.SelectedValue;
                tambah.DiskonNominal = int.Parse(textBoxDIskon.Text);

                Film.TambahData(tambah);
                MessageBox.Show("Input berhasil");
                listFilm.Add(tambah);
                dataGridView1.DataSource = listFilm;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input gagal. Error:" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            if (e.ColumnIndex == dataGridView1.Columns["buttonTambahAktorGrid"].Index)
            {
                FormTambahAktorFilm form = new FormTambahAktorFilm();
                form.Owner = this;
                form.judulFilm = kode;
                form.ShowDialog();

                FormTambahFilm_Load(this, e);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["buttonTambahGenreGrid"].Index)
            {
                FormTambahGenreFilm form = new FormTambahGenreFilm();
                form.Owner = this;
                form.judulFilm = kode;
                form.ShowDialog();

                FormTambahFilm_Load(this, e);
            }
        }
    }
}
