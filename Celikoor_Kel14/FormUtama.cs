using Celikoor_Kel14.Properties;
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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }
        public Konsumen konsumenLogin;
        public Pegawai pegawaiLogin;
        public string nama;
        public string role;
        private void FormUtamaKonsumen_Load(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this;
            formLogin.ShowDialog();
            if (konsumenLogin is null && pegawaiLogin is null)
            { Application.Exit(); }
            else
            {
                AturMenu(role);
                labelNamaLogin.Text = nama;
                if (konsumenLogin is null)
                {
                    MessageBox.Show("Selamat datang " + pegawaiLogin.Name);
                }
                else
                {
                    MessageBox.Show("Selamat datang " + konsumenLogin.Nama);
                }
                AturMenu(role);
            }
        }

        public void AturMenu(string role)
        {
            if (role == "KONSUMEN")
            {
                buttonProfile.Visible = true;
                buttonTopUp.Visible = true;
                panelKonsumen.Visible = true;
                panelKonsumen.Location = new Point(294, 300);
                panelOperator.Visible = false;
                panelAdmin.Visible = false;
                panelKasir.Visible = false;
            }
            else if (role == "OPERATOR")
            {
                buttonProfile.Visible = false;
                buttonTopUp.Visible = false;
                panelKonsumen.Visible = false;
                panelOperator.Visible = true;
                panelOperator.Location = new Point(275, 300);
                panelAdmin.Visible = false;
                panelKasir.Visible = false;
            }
            else if (role == "KASIR")
            {
                buttonProfile.Visible = false;
                buttonTopUp.Visible = false;
                panelKonsumen.Visible = false;
                panelOperator.Visible = false;
                panelAdmin.Visible = false;
                panelKasir.Visible = true;
                panelKasir.Location = new Point(275, 300);
            }
            else if (role == "ADMIN")
            {
                buttonProfile.Visible = false;
                buttonTopUp.Visible = false;
                panelKonsumen.Visible = false;
                panelOperator.Visible = false;
                panelAdmin.Visible = true;
                panelAdmin.Location = new Point(190, 300);
                panelKasir.Visible = false;
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormProfileKonsumen"];
            if (f == null)
            {
                FormProfileKonsumen frm = new FormProfileKonsumen();
                frm.MdiParent = this;
                frm.kLogin = konsumenLogin;
                panelMenu.Visible = false;
                frm.Show();
            }
            else
            {
                f.BringToFront();
                f.Show();
            }
        }
        public void MunculPanelMenu()
        {
            if (panelMenu.Visible == false)
            {
                panelMenu.Visible = true;
            }    
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterPegawai"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormMasterPegawai formMaster = new FormMasterPegawai();
                formMaster.MdiParent = this;
                panelMenu.Visible = false;
                formMaster.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterKonsumen"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormMasterKonsumen formMaster = new FormMasterKonsumen();
                formMaster.MdiParent = this;
                panelMenu.Visible = false;
                formMaster.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterGenre"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormMasterGenre formMaster = new FormMasterGenre();
                formMaster.MdiParent = this;
                panelMenu.Visible = false;
                formMaster.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterKelompok"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormMasterKelompok formMaster = new FormMasterKelompok();
                formMaster.MdiParent = this;
                panelMenu.Visible = false;
                formMaster.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void buttonMasterAktor_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterAktor"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormMasterAktor formMaster = new FormMasterAktor();
                formMaster.MdiParent = this;
                panelMenu.Visible = false;
                formMaster.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterCinema"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormMasterCinema formMaster = new FormMasterCinema();
                formMaster.MdiParent = this;
                panelMenu.Visible = false;
                formMaster.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterJenisStudio"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormMasterJenisStudio formMaster = new FormMasterJenisStudio();
                formMaster.MdiParent = this;
                panelMenu.Visible = false;
                formMaster.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterJadwalFilm"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormMasterJadwalFilm formMaster = new FormMasterJadwalFilm();
                formMaster.MdiParent = this;
                panelMenu.Visible = false;
                formMaster.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterStudio"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormMasterStudio formMaster = new FormMasterStudio();
                formMaster.MdiParent = this;
                panelMenu.Visible = false;
                formMaster.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormMasterFilm"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormMasterFilm formMaster = new FormMasterFilm();
                formMaster.MdiParent = this;
                panelMenu.Visible = false;
                formMaster.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void buttonPesanTiket_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormBeliTiket"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormBeliTiket formTiket = new FormBeliTiket();
                formTiket.MdiParent = this;
                panelMenu.Visible = false;
                formTiket.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPenjadwalanFilm"];

            if (form == null) // jika FormMasterKategori tidak ditemukan
            {
                FormPenjadwalanFilm formTiket = new FormPenjadwalanFilm();
                formTiket.MdiParent = this;
                panelMenu.Visible = false;
                formTiket.Show();
            }
            else // jika FormMasterKategori ditemukan di memory
            {    // FormMasterKategori ditampilkan kembali
                form.Show();
                form.BringToFront();
            }
        }
    }
}
