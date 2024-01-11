using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelvienTheDestroyerLIB
{
    public class Studio
    {
        private int id;
        private string nama;
        private int kapasitas;
        private JenisStudio jenis;
        private Cinema cinema;
        private int hargaWeekday;
        private int hargaWeekend;

        public Studio()
        {
            Id = 0;
            Nama = "";
            Kapasitas = 0;
            Jenis = new JenisStudio();
            Cinema = new Cinema();
            HargaWeekday = 0;
            HargaWeekend = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public JenisStudio Jenis { get => jenis; set => jenis = value; }
        public Cinema Cinema { get => cinema; set => cinema = value; }
        public int HargaWeekday { get => hargaWeekday; set => hargaWeekday = value; }
        public int HargaWeekend { get => hargaWeekend; set => hargaWeekend = value; }

        public static void TambahData(Studio s)
        {
            string perintah = "INSERT INTO `celikoor`.`studios` " +
                "(`nama`, `kapasitas`, `jenis_studios_id`, `cinemas_id`, `harga_weekday`, `harga_weekend`) " +
                "VALUES ('"+s.Nama+"', '"+s.Kapasitas+"', '"+s.Jenis.Id.ToString() + "', '"+s.Cinema.Id.ToString()+"', '"+s.HargaWeekday.ToString()+"', '"+ s.HargaWeekend.ToString() + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void UbahData(int weekday, int weekend, string id)
        {
            string perintah = "UPDATE `celikoor`.`studios` " +
                "SET `harga_weekday`='"+weekday.ToString()+ "', `harga_weekend`='"+ weekend.ToString()+"' WHERE `id`='"+id+"';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(string idHapus)
        {
            string perintah = "DELETE FROM celikoor.studios WHERE id= '" + idHapus + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Studio> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "select s.* " +
                    "from studios s inner join cinemas c on c.id=s.cinemas_id inner join jenis_studios j on j.id=s.jenis_studios_id";
            }
            else if (filter == "id" || filter == "nama")
            {
                perintah = "select s.* " +
                    "from studios s inner join cinemas c on c.id=s.cinemas_id " +
                    "inner join jenis_studios j on j.id=s.jenis_studios_id where s." + filter + " ='" + nilai + "';";
            }
            else
            {
                perintah = "select s.* " +
                    "from studios s inner join cinemas c on c.id = s.cinemas_id " +
                    "inner join jenis_studios j on j.id = s.jenis_studios_id where s." + filter + " like '%" + nilai + "%'";

            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<Studio> listHasil = new List<Studio>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                Studio tampung = new Studio();
                Cinema tampungCinema = new Cinema();
                JenisStudio tampungJenis = new JenisStudio();

                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama = drHasil.GetValue(1).ToString();
                tampung.Kapasitas = int.Parse(drHasil.GetValue(2).ToString());

                tampungJenis.Id = int.Parse(drHasil.GetValue(3).ToString());
                List<JenisStudio> listJenis = JenisStudio.BacaData(tampungJenis.Id, 1);
                tampung.Jenis = listJenis[0];
                
                tampungCinema.Id = int.Parse(drHasil.GetValue(4).ToString());
                List<Cinema> listCinema = Cinema.BacaData("", tampungCinema.Id, 1);
                tampung.Cinema = listCinema[0];

                tampung.HargaWeekday = int.Parse(drHasil.GetValue(5).ToString());
                tampung.HargaWeekend = int.Parse(drHasil.GetValue(6).ToString());


                listHasil.Add(tampung);
            }

            return listHasil;
        }
    }
}
