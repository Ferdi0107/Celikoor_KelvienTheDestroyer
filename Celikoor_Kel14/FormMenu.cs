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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            try
            {
                //string server = db.Default.server;
                //string database = db.Default.database;
                //string uid = db.Default.uid;
                //string pwd = db.Default.pwd;
                //Koneksi k = new Koneksi(server, database, uid, pwd);
                //MessageBox.Show("Koneksi berhasil");
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Owner = this;
                formLogin.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Error : " + ex.Message);
            }
        }
    }
}
