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
    public partial class FormTambahGenre : Form
    {
        public FormTambahGenre()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Genre tambah = new Genre();
                tambah.Nama = textBoxNama.Text;
                tambah.Deskripsi = textBoxDeskripsi.Text;

                Genre.TambahData(tambah);
                MessageBox.Show("Tambah berhasil");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Input gagal. Error: "+ex.Message);
            }
        }

        private void FormTambahGenre_Load(object sender, EventArgs e)
        {
            FormUtama utama = (FormUtama)this.MdiParent;
        }
    }
}
