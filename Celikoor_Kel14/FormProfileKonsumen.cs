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
    public partial class FormProfileKonsumen : Form
    {
        public FormProfileKonsumen()
        {
            InitializeComponent();
        }
        FormUtama utama;
        public Konsumen kLogin;
        private void FormProfileKonsumen_Load(object sender, EventArgs e)
        {
            utama = (FormUtama)this.MdiParent;
            labelNamaLogin.Text = kLogin.Nama;
            labelNama.Text = kLogin.Nama;
            labelNoHp.Text = kLogin.NoHP;
            labelUsername.Text = kLogin.Username;
            labelPassword.Text = kLogin.Password;
            labelSaldo.Text = kLogin.Saldo.ToString();
            if (kLogin.Gender == "L")
            {
                labelGender.Text = "Laki-laki";
            }
            else
            {
                labelGender.Text = "Perempuan";
            }
            labelBirthDate.Text = kLogin.TglLahir.ToString("dd-MM-yyyy");
            labelEmail.Text = kLogin.Email;
        }

        private void FormProfileKonsumen_FormClosed(object sender, FormClosedEventArgs e)
        {
            utama.MunculPanelMenu();
        }
    }
}
