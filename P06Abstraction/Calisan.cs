namespace P06Abstraction
{
    public abstract class Calisan
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }
        

        public Calisan(string ad, string soyad,string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
           
            
        }
        public abstract void Gorev();

        public void kimlik()
        {
            Console.Write($"{Ad} {Soyad},{Departman} departmanında ");
        }

        
    }
    public class YazilimGelistirici : Calisan
    {
        public YazilimGelistirici(string ad, string soyad, string departman) : base(ad, soyad, departman)
        {
        }

        public override void Gorev()
        {
            Console.Write("yazılım geliştirici olarak çalışıyorum.");
            
        }
    }
    class ProjeYoneticisi : Calisan
    {
        public ProjeYoneticisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
        }
    }

    
    class SatisTemsilcisi : Calisan
    {
        public SatisTemsilcisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
        }
    }

}
