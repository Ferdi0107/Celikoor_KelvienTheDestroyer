using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace KelvienTheDestroyerLIB
{
    public class Kelompok
    {
        private int id;
        private string nama;
        public Kelompok()
        {
            Id = 0;
            Nama = "-";
        }
        public Kelompok(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public static void TambahData(Kelompok k)
        {
            string perintah = "INSERT INTO celikoor.kelompoks " +
                "(id, nama) " +
                "VALUES ('" + k.Id + "', '" + k.Nama + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void UbahData(Kelompok k)
        {
            string perintah = "UPDATE celikoor.kelompoks SET id=" + k.Id + ", nama=" + k.Nama + ";";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(string idHapus)
        {
            string perintah = "DELETE FROM celikoor.kelompoks WHERE id= '" + idHapus + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Kelompok> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "select k.*" +
                    "from kelompoks k";
            }
            else
            {
                perintah = "select k.*" +
                    "from kelompoks k where "+filter+"='"+nilai+"'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<Kelompok> listHasil = new List<Kelompok>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                Kelompok tampung = new Kelompok();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama = drHasil.GetValue(1).ToString();

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
