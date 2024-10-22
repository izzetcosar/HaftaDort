using P01IlkSinifimiziOlusturuyoruz;


person Ogrenci1 = new person();
Ogrenci1.name = "izzet";
Ogrenci1.lastname = "cosar";
Ogrenci1.dateTime = new DateTime(1994, 10, 12);

person Ogrenci2 = new person();
Ogrenci2.name = "buket";
Ogrenci2.lastname = "engel";
Ogrenci2.dateTime = new DateTime(1998, 4, 4);

person Ogretmen1 = new person();
Ogretmen1.name = "Gürkan";
Ogretmen1.lastname = "Gümüş";
Ogretmen1.dateTime = new DateTime(1984, 5, 24);


Ogrenci1.KendiniTanit();
Ogrenci2.KendiniTanit();
Ogretmen1.KendiniTanit();

Console.ReadKey();
