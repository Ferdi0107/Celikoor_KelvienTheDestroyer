namespace ModulMaster
{
    public class Konsumen
    {
        private int id;
        private string nama;
        private string email;
        private string noHP;
        private string gender;
        private DateTime tglLahir;
        private double saldo;
        private string username;

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string NoHP { get => noHP; set => noHP = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Username { get => username; set => username = value; }
    }
}