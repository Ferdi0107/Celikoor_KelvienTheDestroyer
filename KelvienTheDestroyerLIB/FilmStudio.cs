using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelvienTheDestroyerLIB
{
    public class FilmStudio
    {
        private Studio studio;
        private Film film;

        public FilmStudio()
        {
            Studio = new Studio() ;
            Film = new Film();
        }

        public Studio Studio { get => studio; set => studio = value; }
        public Film Film { get => film; set => film = value; }
        
        public static void TambahData(FilmStudio fs)
        {
            string perintah = "INSERT INTO `celikoor`.`film_studio` " +
                "(`studios_id`, `films_id`) " +
                "VALUES ('" + fs.Studio.Id.ToString() + "', '" + fs.Film.Id.ToString() + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public List<FilmStudio> BacaData()
        {
            string perintah = "select * from film_studio";
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<FilmStudio> listHasil = new List<FilmStudio>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                FilmStudio tampung = new FilmStudio();
                Film tampungFilm = new Film();
                Studio tampungStudio = new Studio();

                tampungStudio.Id = int.Parse(drHasil.GetValue(0).ToString());
                List<Studio> listStudio = Studio.BacaData("id", tampungStudio.Id.ToString());
                tampung.Studio = listStudio[0];

                tampungFilm.Id = int.Parse(drHasil.GetValue(1).ToString());
                List<Film> listFilm = Film.BacaData("id", tampungFilm.Id.ToString());
                tampung.Film = listFilm[0];

                listHasil.Add(tampung);
            }

            return listHasil;
        }
    }
}
