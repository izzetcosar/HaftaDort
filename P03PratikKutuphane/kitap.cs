using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03PratikKutuphane
{
    public class Kitap //Class Özelliklerini oluşturduğumuz property
    {
        public string Ad {  get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int SayfaSayisi { get; set; }
        public string YayinEvi { get; set; }
        public DateTime KayitTarihi { get; set; }

        public Kitap()  //Parametresiz constructor parametrelerini oluşturduğumuzda atayacağız
        { 
        KayitTarihi = DateTime.Now; //Kayıt Tarihi otomatik olarak kitap oluşturulduğunda oluşturuluyor
        }
        public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinEvi) // Parametreli Constructor oluştururken tüm bilgileri doldurmamız gerekiyor
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            SayfaSayisi = sayfaSayisi;
            YayinEvi = yayinEvi;
            KayitTarihi = DateTime.Now; //Kayıt Tarihi otomatik olarak kitap oluşturulduğunda oluşturuluyor
        }
        public void KitapBilgileri() //bilgileri yazdırdığımız method
        {
            Console.WriteLine($"Kitap Adı: {Ad}");
            Console.WriteLine($"Yazar Adı:{YazarAdi} {YazarSoyadi}");
            Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
            Console.WriteLine($"Yayınevi: {YayinEvi}");
            Console.WriteLine($"Kayıt Tarihi: {KayitTarihi}");
        }

    }
}
