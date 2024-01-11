using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelvienTheDestroyerLIB
{
    public class Invoice
    {
        private int id;
        private DateTime tanggal;
        private double grandTotal;
        private double diskonNominal;
        private Konsumen konsumen;
        private Pegawai pegawai;
        private string status;

        public Invoice()
        {
            Id = 0;
            Tanggal = DateTime.Now;
            GrandTotal = 0;
            DiskonNominal = 0;
            Konsumen = new Konsumen();
            Pegawai = new Pegawai();
            Status = "";
        }

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public double GrandTotal { get => grandTotal; set => grandTotal = value; }
        public double DiskonNominal { get => diskonNominal; set => diskonNominal = value; }
        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        public string Status { get => status; set => status = value; }

        public static void TambahData(Invoice i)
        {
            string perintah = "INSERT INTO `celikoor`.`invoices` " +
                "(`tanggal`, `grand_total`, `diskon_nominal`, `konsumens_id`, `kasir_id`, `status`) " +
                "VALUES (now(), '"+i.GrandTotal.ToString()+"', '"+i.DiskonNominal.ToString()+"', '"+i.Konsumen.Id.ToString()+"', '"+
                i.Pegawai.Id.ToString()+"', '"+i.Status+"');";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(string idHapus)
        {
            string perintah = "DELETE FROM celikoor.invoices WHERE id= '" + idHapus + "';";
            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Invoice> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "select i.* from invoices i inner join " +
                    "konsumens k on i.konsumens_id=k.id inner join " +
                    "pegawais p on i.kasir_id=p.id";
            }
            else
            {
                perintah = "select i.* from invoices i inner join konsumens k on i.konsumens_id=k.id " +
                    "inner join pegawais p on i.kasir_id=p.id" +
                    " where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahReader(perintah);

            List<Invoice> listHasil = new List<Invoice>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                Invoice tampung = new Invoice();
                Konsumen tampungKonsumen = new Konsumen();
                Pegawai tampungPegawai = new Pegawai();

                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Tanggal = DateTime.Parse(drHasil.GetValue(1).ToString());
                tampung.GrandTotal = double.Parse(drHasil.GetValue(2).ToString());
                tampung.DiskonNominal = Double.Parse(drHasil.GetValue(3).ToString());
                
                tampungKonsumen.Id = int.Parse(drHasil.GetValue(4).ToString());
                List<Konsumen> listKonsumen = Konsumen.BacaData("id", tampungKonsumen.Id.ToString());
                tampung.Konsumen = listKonsumen[0];

                tampungPegawai.Id = int.Parse(drHasil.GetValue(5).ToString());
                List<Pegawai> listPegawai = Pegawai.BacaData("", tampungKonsumen.Id.ToString(), 2);
                tampung.Pegawai = listPegawai[0];

                tampung.Status = drHasil.GetValue(6).ToString();

                listHasil.Add(tampung);
            }

            return listHasil;
        }
    }
}
