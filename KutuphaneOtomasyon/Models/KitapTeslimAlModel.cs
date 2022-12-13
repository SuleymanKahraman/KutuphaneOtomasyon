using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon
{
    public class KitapTeslimAlModel
    {
        public int TakipId { get; set; }
        public int UyeId { get; set; }
        public int KitapId { get; set; }
        public int CezaPuani { get; set; }
        public int IslemSonuc { get; set; }
        public DateTime GeldigiTarih { get; set; }
        public DateTime TeslimTarihi { get; set; }
        

    }
}
