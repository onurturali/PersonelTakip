namespace PersonelTakipModel
{
    public class Izin
    {
        public Guid Id { get; set; }

        public DateTime IzinBaslangic { get; set; }

        public DateTime IzinBitis { get; set; }

        public bool Durum { get; set; }
    }
}
