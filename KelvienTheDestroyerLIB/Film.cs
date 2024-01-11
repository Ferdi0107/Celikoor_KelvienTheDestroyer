using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KelvienTheDestroyerLIB
{
    public class Film
    {
        private int id;
        private string judul;
        private string sinopsis;
        private int tahun;
        private int durasi;
        private Kelompok kelompok;
        private string bahasa;
        private bool subIndo;
        private Image coverImage;
        private double diskonNominal;
        private List<FilmAktor> filmAktorList;
        private List<FilmGenre> filmGenreList;

        public Film()
        {
            Id = 0;
            Judul = "";
            Sinopsis = "";
            Tahun = 0;
            Durasi = 0;
            Kelompok = new Kelompok();
            Bahasa = "";
            SubIndo = false;
            CoverImage = null;
            DiskonNominal = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public Kelompok Kelompok { get => kelompok; set => kelompok = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public Image CoverImage { get => coverImage; set => coverImage = value; }
        public double DiskonNominal { get => diskonNominal; set => diskonNominal = value; }
        public bool SubIndo { get => subIndo; set => subIndo = value; }
        public List<FilmAktor> FilmAktorList { get => filmAktorList; set => filmAktorList = value; }
        public List<FilmGenre> FilmGenreList { get => filmGenreList; set => filmGenreList = value; }

        public static void TambahData(Film f)
        {
            string perintah = "INSERT INTO `celikoor`.`films` (`judul`, `sinopsis`, `tahun`, `durasi`, `kelompoks_id`, " +
                "`bahasa`, `is_sub_indo`, `diskon_nominal`) " +
                "VALUES ('"+f.Judul+"', '"+f.Sinopsis+"', '"+f.Tahun.ToString()+"', '"+f.Durasi.ToString()+"', '"+f.Kelompok.Id.ToString()+"', '"+
                f.Bahasa+"', '"+f.SubIndo+"', '"+f.DiskonNominal.ToString()+"');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void TambahAktor(FilmAktor fa)
        {
            foreach (FilmAktor f in fa.Film.FilmAktorList)
            {
                string perintahAktor = "INSERT INTO aktor_film VALUES('" + fa.Aktor.Id.ToString() + "', '" + fa.Film.Id.ToString() + "', '" + fa.Peran + "')";
                Koneksi.JalankanPerintahNonQuery(perintahAktor);
            }
        }
        public static void HapusData(string idHapus)
        {
            string perintah = "DELETE FROM celikoor.films WHERE id= '" + idHapus + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Film> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "SELECT * from films f inner join kelompoks k on f.kelompoks_id=k.id";
            }
            else if (filter == "JUDUL" || filter == "TAHUN")
            {
                perintah = "SELECT * from films f inner join kelompoks k on f.kelompoks_id=k.id " +
                    "where f." + filter + " ='" + nilai + "'";
            }
            else
            {
                perintah = "SELECT * from films f inner join kelompoks k on f.kelompoks_id=k.id " +
                    "where f." + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);
            List<Film> listHasil = new List<Film>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                Film tampung = new Film();
                Kelompok tampungKelompok = new Kelompok();

                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Judul = drHasil.GetValue(1).ToString();
                tampung.Sinopsis = drHasil.GetValue(2).ToString();
                tampung.Tahun = int.Parse(drHasil.GetValue(3).ToString());
                tampung.Durasi = int.Parse(drHasil.GetValue(4).ToString());

                tampungKelompok.Id = int.Parse(drHasil.GetValue(5).ToString());
                List<Kelompok> listKelompok = Kelompok.BacaData("id", drHasil.GetValue(5).ToString());
                tampung.Kelompok = listKelompok[0];

                tampung.Bahasa = drHasil.GetValue(6).ToString();
                if (drHasil.GetValue(7).ToString() == "1")
                {
                    tampung.SubIndo = true;
                }
                else
                {
                    tampung.SubIndo = false;
                }
                tampung.CoverImage = null;
                tampung.DiskonNominal = double.Parse(drHasil.GetValue(9).ToString());


                listHasil.Add(tampung);
            }
            foreach (Film f in listHasil)
            {
                f.FilmGenreList = FilmGenre.BacaData("films_id", f.Id.ToString());
                f.FilmAktorList = FilmAktor.BacaData("films_id", f.Id.ToString());
            }

            return listHasil;
        }
        public static List<Film> BacaDataFilm(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "select f.*, a.nama, g.nama from films f " +
                    "inner join aktor_film af on f.id=af.films_id " +
                    "inner join aktors a on af.aktors_id=a.id " +
                    "inner join genre_film gf on f.id=gf.films_id " +
                    "inner join genres g on gf.genres_id=g.id inner join kelompoks k on f.kelompoks_id=k.id";
            }
            else
            {
                perintah = "select f.*, a.nama, g.nama from films f " +
                    "inner join aktor_film af on f.id=af.films_id " +
                    "inner join aktors a on af.aktors_id=a.id " +
                    "inner join genre_film gf on f.id=gf.films_id " +
                    "inner join genres g on gf.genres_id=g.id inner join kelompoks k on f.kelompoks_id=k.id " +
                    "where " + filter + " ='" + nilai + "'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);
            List<Film> listHasil = new List<Film>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                Film tampung = new Film();
                Kelompok tampungKelompok = new Kelompok();

                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Judul = drHasil.GetValue(1).ToString();
                tampung.Sinopsis = drHasil.GetValue(2).ToString();
                tampung.Tahun = int.Parse(drHasil.GetValue(3).ToString());
                tampung.Durasi = int.Parse(drHasil.GetValue(4).ToString());

                tampungKelompok.Id = int.Parse(drHasil.GetValue(5).ToString());
                List<Kelompok> listKelompok = Kelompok.BacaData("id", drHasil.GetValue(5).ToString());
                tampung.Kelompok = listKelompok[0];

                tampung.Bahasa = drHasil.GetValue(6).ToString();
                if (drHasil.GetValue(7).ToString() == "1")
                {
                    tampung.SubIndo = true;
                }
                else
                {
                    tampung.SubIndo = false;
                }
                tampung.CoverImage = null;
                tampung.DiskonNominal = double.Parse(drHasil.GetValue(9).ToString());


                listHasil.Add(tampung);
            }

            return listHasil;
        }
    }
}
