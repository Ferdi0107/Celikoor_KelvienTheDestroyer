using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace KelvienTheDestroyerLIB
{
    public class Genre
    {
        private int id;
        private string nama;
        private string deskripsi;
        public Genre()
        {
            Id = 0;
            Nama = "-";
            Deskripsi = "-";
        }
        public Genre(int id, string nama, string deskripsi)
        {
            Id = id;
            Nama = nama;
            Deskripsi = deskripsi;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public static void TambahData(Genre g)
        {
            string perintah = "INSERT INTO celikoor.genres " +
                "(id, nama, deskripsi) " +
                "VALUES ('" + g.Id + "', '" + g.Nama + "', '" + g.Deskripsi + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void UbahData(Genre g)
        {
            string perintah = "UPDATE celikoor.genres SET id='" + g.Id + "', nama='" + g.Nama + "', deskripsi='" + g.Deskripsi + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(string idHapus)
        {
            string perintah = "DELETE FROM celikoor.genres WHERE id= '" + idHapus + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Genre> BacaData(string filter = "", string nilai = "")
        {
            string perintah = "";
            if (filter == "")
            {
                perintah = "select g.*" + "from genres g";
            }
            else
            {
                perintah = "select g.*" + "from genres g where "+filter+"='"+nilai+"';";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<Genre> listHasil = new List<Genre>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                Genre tampung = new Genre();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama = drHasil.GetValue(1).ToString();
                tampung.Deskripsi = drHasil.GetValue(2).ToString();

                listHasil.Add(tampung);
            }

            return listHasil;
        }
    }
}
