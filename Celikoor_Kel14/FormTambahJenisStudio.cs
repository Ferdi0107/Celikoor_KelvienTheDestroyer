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
    public partial class FormTambahJenisStudio : Form
    {
        public FormTambahJenisStudio()
        {
            InitializeComponent();
        }
        FormUtama utama;
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                JenisStudio tambah = new JenisStudio();
                tambah.Nama = textBoxNama.Text;
                tambah.Deskripsi = textBoxDeskripsi.Text;

                JenisStudio.TambahData(tambah);
                MessageBox.Show("Input berhasil");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Input gagal. Error :"+ex.Message);
            }
        }

        private void FormTambahJenisStudio_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
        }

        private void FormTambahJenisStudio_FormClosed(object sender, FormClosedEventArgs e)
        {
            utama.MunculPanelMenu();
        }
    }
}
