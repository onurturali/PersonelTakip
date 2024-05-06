namespace PersonelTakipModel
{
    public class Departman
    {
        public Guid Id { get; set; }

        public string Ad { get; set; } =  string.Empty;

        public Guid PozisyonId { get; set; }

        public bool Durum { get; set; }
    }
}
