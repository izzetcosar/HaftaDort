namespace P04Encapsulation
{
    public class araba //class oluşturduk.
    {
        public string marka { get; set; } //properies

        public string model { get; set; }

        public string renk { get; set; }

        private int _kapiSayisi; //kapı sayısında istendiği şekilde kapsülleme yapıyoruz.

        public int kapiSayisi
        {
            get
            {
                return _kapiSayisi;
            }
            set
            {
                if (value == 2 || value == 4) //kapı sayısı 2 veya 4 girilmesi durumunda kapı sayısını gösteriyoruz
                {
                    _kapiSayisi = value;
                }
                else
                {
                    _kapiSayisi = -1; //kapı adedi istenen dışında girildiğinde otomatik olarak -1 girişi yapıyoruz.
                }
            }
        }

        public void ArabaBilgileriniGöster() //araba özelliklerini gösteren bir metod oluşturduk.
        {
            Console.WriteLine($"Marka: {marka}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Renk: {renk}");
            if (_kapiSayisi == -1) //kapı sayısı istenen sayı dışında girildiğinde -1 gösterilip uyarı veriliyor.
            {
                Console.WriteLine($"Kapı Sayısı: {kapiSayisi} (Uyarı: Kapı sayısı sadece 2 veya 4 olabilir.)");
            }
            else
            {
                Console.WriteLine($"Kapı Sayısı: {kapiSayisi}"); //kapı sayısı istenen şekilde girildiğinde adet bilgisi veriliyor.
            }
            

        }
    }
}
    
