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
    public partial class FormRegisterPegawai : Form
    {
        public FormRegisterPegawai()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Pegawai tambah = new Pegawai();
            tambah.Name = textBoxNama.Text;
            tambah.Email = textBoxEmail.Text;
            tambah.Username = textBoxUsername.Text;
            tambah.Password = textBoxPassword.Text;
            tambah.Roles = comboBoxRole.SelectedText;


            Pegawai.TambahData(tambah);
            MessageBox.Show("Tambah berhasil");
            this.Close();
        }

        private void FormRegisterPegawai_Load(object sender, EventArgs e)
        {
            FormUtama utama = (FormUtama)this.MdiParent;
            this.BackgroundImage = Properties.Resources.BackgroundRegisterPegawai;
        }
    }
}
