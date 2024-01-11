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
    public partial class FormTambahStudio : Form
    {
        public FormTambahStudio()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void FormTambahStudio_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            List<JenisStudio> listHasilJenis = JenisStudio.BacaData();

            comboBoxJenisStudio.DataSource = listHasilJenis;
            comboBoxJenisStudio.DisplayMember = "Nama";

            List<Cinema> listHasilCinema = Cinema.BacaData();

            comboBoxCinema.DataSource = listHasilCinema;
            comboBoxCinema.DisplayMember = "NamaCabang";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Studio tambah = new Studio();
                tambah.Nama = textBoxNama.Text;
                tambah.Kapasitas = int.Parse(textBoxKapasitas.Text);
                tambah.Jenis = (JenisStudio)comboBoxJenisStudio.SelectedItem;
                tambah.Cinema = (Cinema)comboBoxCinema.SelectedItem;
                tambah.HargaWeekday = int.Parse(textBoxHargaWeekday.Text);
                tambah.HargaWeekend = int.Parse(textBoxHargaWeekend.Text);

                Studio.TambahData(tambah);
                MessageBox.Show("Tambah berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input gagal. Error :" + ex.Message);
            }
        }
    }
}
