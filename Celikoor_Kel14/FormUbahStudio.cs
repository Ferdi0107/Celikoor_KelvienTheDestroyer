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
    public partial class FormUbahStudio : Form
    {
        public FormUbahStudio()
        {
            InitializeComponent();
        }
        FormUtama utama;
        FormMasterStudio studio;
        private void FormUbahStudio_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.Owner.MdiParent;
            studio = (FormMasterStudio)this.Owner;
            List<Studio> listHasil = Studio.BacaData("id", studio.kode);
            labelNama.Text = listHasil[0].Nama;
            labelKapasitas.Text = listHasil[0].Kapasitas.ToString();
            labelJenisStudio.Text = listHasil[0].Jenis.Nama;
            labelCinema.Text = listHasil[0].Cinema.NamaCabang;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int weekday = int.Parse(textBoxHargaWeekday.Text);
                int weekend = int.Parse(textBoxHargaWeekend.Text);

                Studio.UbahData(weekday, weekend, studio.kode);
                MessageBox.Show("Ubah Data Berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ubah data gagal. error : " + ex.Message);
            }
            
        }
    }
}
