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
    public partial class FormTambahAktor : Form
    {
        public FormTambahAktor()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Aktor tambah = new Aktor();
            tambah.Nama = textBoxNama.Text;
            tambah.TglLahir = dateTimePickerTanggalLahir.Value;
            tambah.NegaraAsal = textBoxNegaraAsal.Text;
            if (comboBoxGender.SelectedIndex == 0)
            {
                tambah.Gender = "L";
            }
            else
            {
                tambah.Gender = "P";
            }
            Aktor.TambahData(tambah);
            MessageBox.Show("Input berhasil");
            this.Close();
        }

        private void FormTambahAktor_Load(object sender, EventArgs e)
        {
            FormUtama utama = (FormUtama)this.MdiParent;
        }
    }
}
