using P04Inheritance;

Ogrenci ogrenci1 = new Ogrenci(); // ad ve soyad property lerini üstü sınıfdan aldık
ogrenci1.name = "izzet";
ogrenci1.lastName = "cosar";
ogrenci1.ogrenciNumber = 236;  //ogrenci numarası ogrenci class ına ait özellik
ogrenci1.ogrenciTanim();

Ogretmen ogretmen1 = new Ogretmen();  // ad ve soyad property lerini üstü sınıfdan aldık
ogretmen1.name = "gürkan";
ogretmen1.lastName = "gümüş";
ogretmen1.maas =70000; //maas ogretmen class ına ait özellik
ogretmen1.ogretmenTanim();

Console.ReadKey();
