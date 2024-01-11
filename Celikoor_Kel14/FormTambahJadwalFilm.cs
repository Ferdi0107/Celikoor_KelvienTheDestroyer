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
    public partial class FormTambahJadwalFilm : Form
    {
        public FormTambahJadwalFilm()
        {
            InitializeComponent();
        }

        private void FormTambahJadwalFilm_Load(object sender, EventArgs e)
        {
            FormUtama utama = (FormUtama)this.MdiParent;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                JadwalFilm tambah = new JadwalFilm();
                tambah.Tanggal = dateTimePickerTanggal.Value;
                string jamPemutaran = "";
                if (comboBoxJam.SelectedIndex == 0)
                {
                    jamPemutaran = "I";
                }
                else if (comboBoxJam.SelectedIndex == 1)
                {
                    jamPemutaran = "II";
                }
                else if (comboBoxJam.SelectedIndex == 2)
                {
                    jamPemutaran = "III";
                }
                else if (comboBoxJam.SelectedIndex == 3)
                {
                    jamPemutaran = "IV";
                }
                tambah.JamPemutaran = jamPemutaran;

                JadwalFilm.TambahData(tambah);
                MessageBox.Show("Input berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input gagal. Error :" + ex.Message);
            }
        }
    }
}
