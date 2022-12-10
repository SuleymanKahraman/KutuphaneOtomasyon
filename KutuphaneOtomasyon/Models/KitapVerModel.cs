using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Models
{
    public class KitapVerModel
    {
        public int UyeId { get; set; }
        public int KitapId { get; set; }
        public int Uygunluk { get; set; }
        public int CezaPuani { get; set; }
        public DateTime AlimTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }

    }
}
