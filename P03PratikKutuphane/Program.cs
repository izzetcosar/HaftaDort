using P03PratikKutuphane;

//Parametresiz constructor ile kitap oluşturma
Kitap kitap1 = new Kitap();
kitap1.Ad = "Adı Aylin";
kitap1.YazarAdi = "Ayşe";
kitap1.YazarSoyadi = "Kulin";
kitap1.SayfaSayisi = 398;
kitap1.YayinEvi = "Remzi Kitabevi";
kitap1.KitapBilgileri();

Console.WriteLine("----------------------------");
//Parametreli constructor ile kitap oluşturma
Kitap kitap2 = new Kitap("Adı Aylin", "Ayşe","Kulin",398, "Remzi Kitabevi");
kitap2.KitapBilgileri();

//Class:Birbirleriyle aynı özelliklere sahip nesnelerin ortak şemada topladığımız alanlardır.Örneğimizde Kitap sınıfı oluşturduk.
//Her kitabın adı yazarı sayfasayısı ve yayınlandıysa bir yayınevi mevcuttur.

//Property: Sınıf içinde oluşturduğumuz özelliklerdir.(kitap adı,Yazar Adı,Yazar soyadı,sayfa sayısı,Yayın evi)

//New: Olusturduğumuz class özelliklerine ait yeni bir nesne oluşturmak için kullanuyoruz.(Kitap1,Kitap2)

//Constructor:Yeni bir nesne oluştururken kullanılan metottur.Bunlar nesnelere ilk değerlerini verir.
Console.ReadLine();