using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ConstructorBebek
{
    public class Bebek //istenen 3 adet property olusturuldu.
    {
        public string _name {  get; set; }
        public string _lastName { get; set; }
        public DateTime _date { get; set; }

        public Bebek() //Parametre almayan bebek
        {
            Console.WriteLine("Ingaaaa");
            _date = DateTime.Now; //Olusturma anında doğum tarihi olusturmak için anlık tarihi atadım.
        }

        public Bebek(string name, string lastName) //ad ve soyad paremetrelerini alan bebek
        {
            Console.WriteLine("Ingaaaa");
            _date = DateTime.Now; //Olusturma anında doğum tarihi olusturmak için anlık tarihi atadım.
            _name = name;
            _lastName = lastName;
            
        }
        public void kimlikyazdir() //Konsol ekranına bebeklerimizin kimliklerini yazdırıcak metotu olusturdum.
        { 
            Console.WriteLine($"Bebek adı:{_name}{_lastName},Doğum Tarihi:{_date}");
        }



        


    }
}
