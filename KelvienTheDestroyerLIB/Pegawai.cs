using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KelvienTheDestroyerLIB
{
    public class Pegawai
    {
        private int id;
        private string name;
        private string email;
        private string username;
        private string password;
        private string roles;

        public Pegawai()
        {
            Id = 0;
            Name = "";
            Email = "";
            Username = "";
            Password = "";
            Roles = "";
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Roles { get => roles; set => roles = value; }

        public static void TambahData(Pegawai p)
        {
            string perintah = "INSERT INTO celikoor.pegawais (nama, email, username, password, roles) " +
                "VALUES ('"+p.Name+"', '"+p.Email+"', '"+p.Username+"', '"+p.Password+"', '"+p.Password+"');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void UbahData(Pegawai p)
        {
            string perintah = "UPDATE celikoor.pegawais " +
                "SET nama='"+p.Name+"', email='"+p.Email+"', username='"+p.Username+"', password='"+
                p.Password+"', roles='"+p.Roles+"' WHERE id='"+p.Id+"';";
        }
        public static void HapusData(string hapus)
        {
            string perintah = "DELETE FROM celikoor.pegawais WHERE id= '" + hapus + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Pegawai> BacaData(string role = "", string nama= "", int kode = 0)
        {
            string perintah;
            if (kode == 0)
            {
                perintah = "SELECT * from pegawais";
            }
            else if (kode == 2)
            {
                perintah = "SELECT * from pegawais where id='" + nama + "'";
            }
            else
            {
                perintah = "SELECT * from pegawais where nama like '%" + nama + "%' and roles='"+ role + "'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<Pegawai> listHasil = new List<Pegawai>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                Pegawai tampung = new Pegawai();

                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Name = drHasil.GetValue(1).ToString();
                tampung.Email = drHasil.GetValue(2).ToString();
                tampung.Username = drHasil.GetValue(3).ToString();
                tampung.Password = drHasil.GetValue(4).ToString();
                tampung.Roles = drHasil.GetValue(5).ToString();

                listHasil.Add(tampung);
            }

            return listHasil;
        }
        public static Pegawai CekLogin(string username, string password)
        {
            string perintah = "SELECT * from pegawais where username='" + username + "' and password ='" + password + "'";
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                Pegawai tampung = new Pegawai();

                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Name = drHasil.GetValue(1).ToString();
                tampung.Email = drHasil.GetValue(2).ToString();
                tampung.Username = drHasil.GetValue(3).ToString();
                tampung.Password = drHasil.GetValue(4).ToString();
                tampung.Roles = drHasil.GetValue(5).ToString();

                return tampung;
            }

            return null;
        }  
    }
}
