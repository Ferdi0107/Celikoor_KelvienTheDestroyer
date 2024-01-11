using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelvienTheDestroyerLIB
{
    public class SesiFilm
    {
        private JadwalFilm sesi;
        private FilmStudio filmStudio;

        public SesiFilm()
        {
            Sesi = new JadwalFilm();
            FilmStudio = new FilmStudio();
        }

        public JadwalFilm Sesi { get => sesi; set => sesi = value; }
        public FilmStudio FilmStudio { get => filmStudio; set => filmStudio = value; }

        public static void TambahData(SesiFilm sf)
        {
            string perintah = "INSERT INTO `celikoor`.`sesi_films` " +
                "(`jadwal_film_id`, `studios_id`, `films_id`) " +
                "VALUES ('"+sf.Sesi.Id.ToString()+"', '"+sf.FilmStudio.Studio.Id.ToString()
                +"', '"+ sf.FilmStudio.Film.Id.ToString() + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<SesiFilm> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "SELECT f.judul, g.nama, k.nama, c.nama_cabang, s.nama, jf.tanggal, jf.jam_pemutaran, jf.id " +
                    "FROM films f inner join genre_film gf on f.id=gf.films_id " +
                    "inner join genres g on g.id=gf.genres_id inner join kelompoks k on f.kelompoks_id=k.id " +
                    "inner join sesi_films sf on sf.films_id=f.id inner join studios s on sf.studios_id=s.id " +
                    "inner join jadwal_films jf on jf.id=sf.jadwal_film_id " +
                    "inner join cinemas c on c.id=s.cinemas_id";
;
            }
            else
            {
                perintah = "SELECT f.judul, g.nama, k.nama, c.nama_cabang, s.nama, jf.tanggal, jf.jam_pemutaran, jf.id " +
                    "FROM films f inner join genre_film gf on f.id=gf.films_id " +
                    "inner join genres g on g.id=gf.genres_id inner join kelompoks k on f.kelompoks_id=k.id " +
                    "inner join sesi_films sf on sf.films_id=f.id inner join studios s on sf.studios_id=s.id " +
                    "inner join jadwal_films jf on jf.id=sf.jadwal_film_id " +
                    "inner join cinemas c on c.id=s.cinemas_id where "+filter+" ='"+nilai+"'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<SesiFilm> listHasil = new List<SesiFilm>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                SesiFilm tampungSesi = new SesiFilm();

                tampungSesi.FilmStudio.Film.Judul = drHasil.GetValue(0).ToString();
                List<Film> listFilm = Film.BacaData("f.judul", tampungSesi.FilmStudio.Film.Judul);
                tampungSesi.FilmStudio.Film = listFilm[0];
                
                tampungSesi.FilmStudio.Studio.Nama = drHasil.GetValue(4).ToString();
                List<Studio> listStudio = Studio.BacaData("nama", tampungSesi.FilmStudio.Studio.Nama);
                tampungSesi.FilmStudio.Studio = listStudio[0];

                tampungSesi.Sesi.Id = int.Parse(drHasil.GetValue(7).ToString());
                List<JadwalFilm> listJadwalFilm = JadwalFilm.BacaData(1, tampungSesi.Sesi.Id);
                tampungSesi.Sesi = listJadwalFilm[0];

                listHasil.Add(tampungSesi);
            }

            return listHasil;
        }
    }
}
