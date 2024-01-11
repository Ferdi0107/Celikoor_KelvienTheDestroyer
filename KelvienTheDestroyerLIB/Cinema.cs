using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace KelvienTheDestroyerLIB
{
    public class Cinema
    {
        private int id;
        private string namaCabang;
        private string alamat;
        private DateTime tglBuka;
        private string kota;
        public Cinema()
        {
            Id = 0;
            NamaCabang = "-";
            Alamat = "-";
            TglBuka = DateTime.Now;
            Kota = "-";
        }
        public Cinema(int id, string namaCabang, string alamat, DateTime tglBuka, string kota)
        {
            Id = id;
            NamaCabang = namaCabang;
            Alamat = alamat;
            TglBuka = tglBuka;
            Kota = kota;
        }

        public int Id { get => id; set => id = value; }
        public string NamaCabang { get => namaCabang; set => namaCabang = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime TglBuka { get => tglBuka; set => tglBuka = value; }
        public string Kota { get => kota; set => kota = value; }

        public static void TambahData(Cinema c)
        {
            string perintah = "INSERT INTO celikoor.cinemas " +
                "(id, nama_cabang, alamat, tgl_dibuka, kota) " +
                "VALUES ('" + c.Id + "', '" + c.NamaCabang + "', '" + c.Alamat + "', '" + c.TglBuka.ToString("yyyy-MM-dd") + "', '" + c.Kota + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void UbahData(Cinema c)
        {
            string perintah = "UPDATE celikoor.cinemas SET id='" + c.Id + "', nama_cabang='" + c.NamaCabang + "', alamat='" + c.Alamat +
                " 'tgl_dibuka='" + c.TglBuka.ToString("yyyy-MM-dd") + "', kota='" + c.Kota + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(string idHapus)
        {
            string perintah = "DELETE FROM celikoor.cinemas WHERE id= '" + idHapus + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Cinema> BacaData(string filter = "", int nilai = 0, int kode = 0)
        {
            string perintah = "";
            if (kode == 0)
            {
                perintah = "select c.*" + "from cinemas c";
            }
            else
            {
                perintah = "select c.*" + "from cinemas c where id='"+nilai+"'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<Cinema> listHasil = new List<Cinema>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                Cinema tampung = new Cinema();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.NamaCabang = drHasil.GetValue(1).ToString();
                tampung.Alamat = drHasil.GetValue(2).ToString();
                tampung.TglBuka = DateTime.Parse(drHasil.GetValue(3).ToString());
                tampung.Kota = drHasil.GetValue(4).ToString();

                listHasil.Add(tampung);
            }

            return listHasil;
        }
        public override string ToString()
        {
            return NamaCabang;
        }
    }
}
