using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace KelvienTheDestroyerLIB
{
    public class Konsumen
    {
        private int id;
        private string nama;
        private string email;
        private string noHP;
        private string gender;
        private DateTime tglLahir;
        private double saldo;
        private string username;
        private string password;
        public Konsumen()
        {
            Id = 0;
            Nama = "";
            Email = "";
            NoHP = "";
            Gender = "";
            TglLahir = DateTime.Now;
            Saldo = 0;
            Username = "";
            Password = "";
        }
        public Konsumen(int id, string nama, string email, string noHP, string gender, DateTime tglLahir, double saldo, string username, string password)
        {
            Id = id;
            Nama = nama;
            Email = email;
            NoHP = noHP;
            Gender = gender;
            TglLahir = tglLahir;
            Saldo = saldo;
            Username = username;
            Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string NoHP { get => noHP; set => noHP = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public static void TambahData(Konsumen k)
        {
            string perintah = "INSERT INTO celikoor.konsumens " +
                "(id, nama, email, no_hp, gender, tgl_lahir, saldo, username, password) " +
                "VALUES ('" +k.Id+"', '"+k.Nama+"', '"+ k.Email + "', '"+k.NoHP+"', '"+k.Gender+"', '"+ 
                k.TglLahir.ToString("yyyy-MM-dd") + "', '"+k.Saldo+"', '"+k.Username+"', '"+k.Password+"');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void UbahData(Konsumen k)
        {
            string perintah = "UPDATE celikoor.konsumens SET id='" + k.Id + "', nama='" + k.Nama + "', email='" + k.Email + "', no_hp='" + k.NoHP + "', '" +
                "'gender='" + k.Gender + "', tgl_lahir='" + k.TglLahir.ToString("yyyy-MM-dd") + "', saldo='" + k.Saldo + "', username='" + k.Username + 
                "', password='" + k.Password + "' WHERE id='" + k.Id + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(string idHapus)
        {
            string perintah = "DELETE FROM celikoor.konsumens WHERE id= '" + idHapus + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Konsumen> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "select k.*" +
                    "from konsumens k";
            }
            else if (filter == "id")
            {
                perintah = "select k.*" +
                    "from konsumens k where " + filter + " ='" + nilai + "'";
            }
            else
            {
                perintah = "select k.*" +
                    "from konsumens k where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<Konsumen> listHasil = new List<Konsumen>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                Konsumen tampung = new Konsumen();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama = drHasil.GetValue(1).ToString();
                tampung.Email = drHasil.GetValue(2).ToString();
                tampung.NoHP = drHasil.GetValue(3).ToString();
                tampung.Gender = drHasil.GetValue(4).ToString();
                if (drHasil.GetValue(5).ToString() != null)
                {
                    tampung.TglLahir = DateTime.Parse(drHasil.GetValue(5).ToString());
                }
                tampung.Saldo = int.Parse(drHasil.GetValue(6).ToString());
                tampung.Username = drHasil.GetValue(7).ToString();
                tampung.Password = drHasil.GetValue(8).ToString();


                listHasil.Add(tampung);
            }

            return listHasil;
        }
        public static Konsumen CekLogin(string id, string password)
        {
            string perintah = "select k.* " +
                    "from konsumens k where username='" + id + "' and password='" + password + "';";
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);
            if (drHasil.Read() == true) //jika ada data yang terpanggil (terdaftar)
            {
                Konsumen tampung = new Konsumen();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama = drHasil.GetValue(1).ToString();
                tampung.Email = drHasil.GetValue(2).ToString();
                tampung.NoHP = drHasil.GetValue(3).ToString();
                tampung.Gender = drHasil.GetValue(4).ToString();
                tampung.TglLahir = DateTime.Parse(drHasil.GetValue(5).ToString());
                tampung.Saldo = int.Parse(drHasil.GetValue(6).ToString());
                tampung.Username = drHasil.GetValue(7).ToString();
                tampung.Password = drHasil.GetValue(8).ToString();


                return tampung;
            }

            return null;
        }
    }
}