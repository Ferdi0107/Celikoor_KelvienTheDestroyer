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
    public partial class FormRegisterKonsumen : Form
    {
        public FormRegisterKonsumen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Konsumen tambah = new Konsumen();
                tambah.Nama = textBoxNama.Text;
                tambah.Email = textBoxEmail.Text;
                tambah.NoHP = textBoxNoHp.Text;
                if (comboBoxGender.SelectedIndex == 0)
                {
                    tambah.Gender = "L";
                }
                else
                {
                    tambah.Gender = "P";
                }
                tambah.TglLahir = dateTimePickerTanggalLahir.Value;
                tambah.Username = textBoxUsername.Text;
                tambah.Password = textBoxPassword.Text;
                Konsumen.TambahData(tambah);
                MessageBox.Show("Registrasi berhasil");
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Registrasi gagal. Error = " + x.Message);
            }
            
        }

        private void FormRegisterKonsumen_Load(object sender, EventArgs e)
        {
            FormUtama utama = (FormUtama)this.MdiParent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTanggalLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNoHp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
