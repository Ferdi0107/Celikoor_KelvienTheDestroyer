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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                FormUtama utama = (FormUtama)this.Owner;
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                
                utama.konsumenLogin = Konsumen.CekLogin(username, password);
                if (utama.konsumenLogin is null)
                {
                    utama.pegawaiLogin = Pegawai.CekLogin(username, password);
                    if (utama.pegawaiLogin is null)
                    {
                        MessageBox.Show("Login gagal");
                        Application.Exit();
                    }
                    else
                    {
                        utama.Show();
                        utama.nama = utama.pegawaiLogin.Name;
                        utama.role = utama.pegawaiLogin.Roles;
                        this.Close();
                    }
                }
                else
                {
                    utama.Show();
                    utama.nama = utama.konsumenLogin.Nama;
                    utama.role = "KONSUMEN";
                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Login gagal. Error : " + x.Message);
            }
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Text = "";
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterKonsumen formRegisterKonsumen = new FormRegisterKonsumen();
            formRegisterKonsumen.Owner = this;
            formRegisterKonsumen.ShowDialog();
        }
    }
}
