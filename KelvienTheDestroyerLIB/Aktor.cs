using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace KelvienTheDestroyerLIB
{
    public class Aktor
    {
        private int id;
        private string nama;
        private DateTime tglLahir;
        private string gender;
        private string negaraAsal;
        public Aktor()
        {
            Id = 0;
            Nama = "-";
            TglLahir = DateTime.Now;
            Gender = "-";
            NegaraAsal = "-";
        }
        public Aktor(int id, string nama, DateTime tglLahir, string gender, string negaraAsal)
        {
            Id = id;
            Nama = nama;
            TglLahir = tglLahir;
            Gender = gender;
            NegaraAsal = negaraAsal;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NegaraAsal { get => negaraAsal; set => negaraAsal = value; }
        public static void TambahData(Aktor a)
        {
            string perintah = "INSERT INTO celikoor.aktors " +
                "(id, nama, tgl_lahir, gender, negara_asal) " +
                "VALUES (" + a.Id + ", " + a.Nama + ", " + a.TglLahir.ToString("yyyy-MM-dd") + ", " + a.Gender + ", " + a.NegaraAsal + ");";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void UbahData(Aktor a)
        {
            string perintah = "UPDATE celikoor.aktors SET id=" + a.Id + ", nama=" + a.Nama + ", tgl_lahir=" + a.TglLahir.ToString("yyyy-MM-dd") +
                "gender=" + a.Gender + ", negara_asal=" + a.NegaraAsal + ";";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(string idHapus)
        {
            string perintah = "DELETE FROM celikoor.aktors WHERE id= '" + idHapus + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Aktor> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "select a.*" +
                    "from aktors a";
            }
            else
            {
                perintah = "select a.*" +
                    "from aktors a where "+filter+" = '" + nilai + "'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<Aktor> listHasil = new List<Aktor>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                Aktor tampung = new Aktor();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama = drHasil.GetValue(1).ToString();
                tampung.TglLahir = DateTime.Parse(drHasil.GetValue(2).ToString());
                tampung.Gender = drHasil.GetValue(3).ToString();
                tampung.NegaraAsal = drHasil.GetValue(4).ToString();

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
