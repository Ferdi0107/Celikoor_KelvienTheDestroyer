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
    public partial class FormTambahCinema : Form
    {
        public FormTambahCinema()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Cinema tambah = new Cinema();
            tambah.NamaCabang = textBoxNama.Text;
            tambah.Alamat = textBoxAlamat.Text;
            tambah.TglBuka = dateTimePickerTanggalBuka.Value;
            tambah.Kota = textBoxKota.Text;

            Cinema.TambahData(tambah);
            MessageBox.Show("Tambah berhasil");
            this.Close();
        }

        private void FormTambahCinema_Load(object sender, EventArgs e)
        {
            FormUtama utama = (FormUtama)this.MdiParent;
        }
    }
}
