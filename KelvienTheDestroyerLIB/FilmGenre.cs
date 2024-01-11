using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KelvienTheDestroyerLIB
{
    public class FilmGenre
    {
        private Film film;
        private Genre genre;

        public FilmGenre()
        {
            Film = new Film();
            Genre = new Genre();
        }

        public Film Film { get => film; set => film = value; }
        public Genre Genre { get => genre; set => genre = value; }

        public static void TambahData(FilmGenre fg)
        {
            string perintah = "INSERT INTO `celikoor`.`genre_film` (`films_id`, `genres_id`) " +
                "VALUES ('"+fg.Film.Id.ToString()+"', '"+fg.Genre.Id.ToString()+"');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<FilmGenre> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "select gf.*, f.judul, g.nama from genre_film gf " +
                    "inner join films f where f.id = gf.films_id inner " +
                    "join genres g on g.id=gf.genres_id";
            }
            else
            {
                perintah = "select gf.*, f.judul, g.nama " +
                    "from genre_film gf inner join films f on f.id=gf.films_id " +
                    "inner join genres g on g.id = gf.genres_id" +
                    " where " + filter + " = '" + nilai + "'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<FilmGenre> listHasil = new List<FilmGenre>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                FilmGenre tampung = new FilmGenre();
                Film tampungFilm = new Film();
                Genre tampungGenre = new Genre();

                tampungFilm.Id = int.Parse(drHasil.GetValue(0).ToString());
                List<Film> listFilm = Film.BacaDataFilm("f.id", tampungFilm.Id.ToString());
                tampung.Film = listFilm[0];

                tampungGenre.Id = int.Parse(drHasil.GetValue(1).ToString());
                List<Genre> listGenre = Genre.BacaData("g.id", tampungGenre.Id.ToString());
                tampung.Genre = listGenre[0];

                listHasil.Add(tampung);
            }

            return listHasil;
        }
        public override string ToString()
        {
            return Genre.Nama;
        }
    }
}
