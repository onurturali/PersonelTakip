namespace PersonelTakipModel
{
    public class Personel
    {
        public Guid Id { get; set; }

        public string AdSoyad { get; set; } = string.Empty;

        public int TcKimlikNo { get; set; }

        public DateTime GirisTarihi { get; set; }
        public DateTime? CikisTarihi { get; set; }

        public bool Cinsiyet { get; set; }

        public string Telefon { get; set; } = string.Empty;

        public DateTime DogumTarihi { get; set; }

        public int SicilNo { get; set; }

        public Guid DepartmanId { get; set; }
        public Guid MaasId { get; set; }
        public Guid IzinId { get; set; }

        public int Durum { get; set; }


    }
}
