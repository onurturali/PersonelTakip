using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipModel
{
    public class Pozisyon
    {
        public Guid Id { get; set; }

        public string Ad { get; set; } = string.Empty;

        public bool Durum { get; set; }
    }
}
