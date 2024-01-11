using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelvienTheDestroyerLIB
{
    public class Tiket
    {
        List<string> listKursi = new List<string>();
        Invoice invoice;
        private bool statusHadir;
        private Pegawai pegawaiOperator;
        private int harga;
        SesiFilm sesiFilm;

        public Tiket()
        {
            ListKursi = new List<string>();
            Invoice = new Invoice();
            StatusHadir = false;
            PegawaiOperator = new Pegawai();
            Harga = harga;
            SesiFilm = new SesiFilm();
        }

        public List<string> ListKursi { get => listKursi; set => listKursi = value; }
        public Invoice Invoice { get => invoice; set => invoice = value; }
        public bool StatusHadir { get => statusHadir; set => statusHadir = value; }
        public Pegawai PegawaiOperator { get => pegawaiOperator; set => pegawaiOperator = value; }
        public int Harga { get => harga; set => harga = value; }
        public SesiFilm SesiFilm { get => sesiFilm; set => sesiFilm = value; }
    }
}
