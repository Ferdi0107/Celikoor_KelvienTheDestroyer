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
    public partial class FormTambahKelompok : Form
    {
        public FormTambahKelompok()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Kelompok tambah = new Kelompok();
                tambah.Nama = textBoxNama.Text;

                Kelompok.TambahData(tambah);
                MessageBox.Show("Tambah berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input gagal. Error :" + ex.Message);
            }

        }

        private void FormTambahKelompok_Load(object sender, EventArgs e)
        {
            FormUtama utama = (FormUtama)this.MdiParent;
        }
    }
}
