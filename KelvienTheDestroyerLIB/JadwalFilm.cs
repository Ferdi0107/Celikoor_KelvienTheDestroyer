using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelvienTheDestroyerLIB
{
    public class JadwalFilm
    {
        private int id;
        private DateTime tanggal;
        private string jamPemutaran;

        public JadwalFilm()
        {
            Id = 0;
            Tanggal = DateTime.Now;
            JamPemutaran = "";
        }

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string JamPemutaran { get => jamPemutaran; set => jamPemutaran = value; }

        public static void TambahData(JadwalFilm data)
        {
            string perintah = "INSERT INTO celikoor.jadwal_films " +
                "(tanggal, jam_pemutaran) " +
                "VALUES ('" + data.Tanggal + "', '" + data.JamPemutaran + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(string kode)
        {
            string perintah = "DELETE FROM celikoor.jadwal_films WHERE id= '" + kode + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<JadwalFilm> BacaData(int nilai = 0, int kode = 0)
        {
            string perintah = "";
            if (kode == 0)
            {
                perintah = "select j.* from jadwal_films j";
            }
            else
            {
                perintah = "select j.* from jadwal_films j where id='" + nilai + "'";
            }

            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<JadwalFilm> listHasil = new List<JadwalFilm>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                JadwalFilm tampung = new JadwalFilm();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Tanggal = DateTime.Parse(drHasil.GetValue(1).ToString());
                tampung.JamPemutaran = drHasil.GetValue(2).ToString();

                listHasil.Add(tampung);
            }

            return listHasil;
        }
    }
}
