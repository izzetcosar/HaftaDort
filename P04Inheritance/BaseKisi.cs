using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Inheritance
{
    public class BaseKisi //base kisi adlı class oluşturuldu.
    {
        public string name { get; set; } 
        public string lastName { get; set; }

        public void kimlikYazdir()
        {
            Console.Write($"Adı:{name} {lastName} "); //alt sınıflarında kullanabileceği bir metot uygulandı.
        }
    }
    public class Ogrenci : BaseKisi
    {
        public int ogrenciNumber {  get; set; }
        public void ogrenciTanim ()
        {
           
            Console.Write($"Numarası:{ogrenciNumber} "); //sınıfa özel metot
            kimlikYazdir(); //üst sınıfdan aldığımız metodu ekledik.
            Console.WriteLine();
        }

    }
    public class Ogretmen : BaseKisi 
    {
        public decimal maas { get; set; }
        public void ogretmenTanim()
        {
            Console.Write($"Maaşı:{maas} "); //sınıfa özel metot
            kimlikYazdir(); //üst sınıfdan aldığımuz metot
            Console.WriteLine();

        }
    }
}
