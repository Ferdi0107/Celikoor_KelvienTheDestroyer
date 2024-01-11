using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelvienTheDestroyerLIB
{
    public class FilmAktor
    {
        private Film film;
        private Aktor aktor;
        private string peran;

        public FilmAktor()
        {
            Film = new Film();
            Aktor = new Aktor();
            Peran = "";
        }

        public Film Film { get => film; set => film = value; }
        public Aktor Aktor { get => aktor; set => aktor = value; }
        public string Peran { get => peran; set => peran = value; }

        public static void TambahData(FilmAktor fa)
        {
            string perintah = "Insert into celikoor.aktor_film " +
                "VALUES('" + fa.Aktor.Id.ToString() + "', '" + fa.Film.Id.ToString() + "', '" + fa.Peran + "');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<FilmAktor> BacaData(string filter = "", string nilai = "")
        {
            string perintah = "";
            if (filter == "")
            {
                perintah = "select af.*, a.nama, f.judul from aktor_film af " +
                    "inner join aktors a on a.id=af.aktors_id inner join films f " +
                    "on f.id=af.films_id";
            }
            else
            {
                perintah = "select af.*, a.nama, f.judul from aktor_film af " +
                    "inner join aktors a on a.id=af.aktors_id inner join films f " +
                    "on f.id=af.films_id where " + filter + "='" + nilai + "';";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<FilmAktor> listHasil = new List<FilmAktor>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                FilmAktor tampung = new FilmAktor();
                Film tampungFilm = new Film();
                Aktor tampungAktor = new Aktor();

                tampungAktor.Id = int.Parse(drHasil.GetValue(0).ToString());
                List<Aktor> listAktor = Aktor.BacaData("a.id", tampungAktor.Id.ToString());
                tampung.Aktor = listAktor[0];

                tampungFilm.Id = int.Parse(drHasil.GetValue(1).ToString());
                List<Film> listFilm = Film.BacaDataFilm("f.id", tampungFilm.Id.ToString());
                tampung.Film = listFilm[0];

                tampung.Peran = drHasil.GetValue(2).ToString();

                listHasil.Add(tampung);
            }

            return listHasil;
        }
        public override string ToString()
        {
            return Aktor.Nama;
        }
    }
}
