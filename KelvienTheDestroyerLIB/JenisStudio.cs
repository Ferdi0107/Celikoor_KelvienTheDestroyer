using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KelvienTheDestroyerLIB
{
    public class JenisStudio
    {
        private int id;
        private string nama;
        private string deskripsi;

        public JenisStudio()
        {
            Id = 0;
            Nama = "";
            Deskripsi = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }

        public static void TambahData(JenisStudio c)
        {
            string perintah = "INSERT INTO celikoor.jenis_studios " +
                "(nama, deskripsi) " +
                "VALUES ('" + c.Nama + "', '" + c.Deskripsi + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(string idHapus)
        {
            string perintah = "DELETE FROM celikoor.jenis_studios WHERE id= '" + idHapus + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<JenisStudio> BacaData(int nilai = 0, int kode = 0)
        {
            string perintah = "";
            if (kode == 0)
            {
                perintah = "select j.* from jenis_studios j";
            }
            else
            {
                perintah = "select j.* from jenis_studios j where id='" + nilai+"'";
            }
            
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<JenisStudio> listHasil = new List<JenisStudio>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                JenisStudio tampung = new JenisStudio();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama = drHasil.GetValue(1).ToString();
                tampung.Deskripsi = drHasil.GetValue(2).ToString();

                listHasil.Add(tampung);
            }

            return listHasil;
        }
        public override string ToString()
        {
            return Nama;
        }
    }
}
