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

       
        
    }
    public class YazilimGelistirici : Calisan
    {
        public YazilimGelistirici(string ad, string soyad, string departman) : base(ad, soyad, departman)
        {
        }

        public override void Gorev()
        {
            Console.Write($"{Ad} {Soyad},{Departman} departmanında yazılım geliştirici olarak çalışıyorum.");
            
        }
    }
    class ProjeYoneticisi : Calisan
    {
        public ProjeYoneticisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad},{Departman} departmanında proje yöneticisi olarak çalışıyorum.");
        }
    }

    
    class SatisTemsilcisi : Calisan
    {
        public SatisTemsilcisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad},{Departman} departmanında satış temsilcisi olarak çalışıyorum.");
        }
    }

}
