namespace KutuphaneOtomasyon.Models
{
    // ctrl + .(nokta) ile öneriler açılır ve "MoveTo" komutuyla ilgili sınıfı ayrı bir dosyaya çıkarmış oluruz. 
    public class KitapIslemModel
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string Tur { get; set; }
        public int Sayfa { get; set; }
        public int Uygunluk { get; set; }

    }
}
