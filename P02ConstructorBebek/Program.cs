using P02ConstructorBebek;

Bebek bebek = new Bebek("Nina", "Sarapova"); //isim ve soyismini parametre alan bebeği olusturduk.
bebek.kimlikyazdir(); //Metot kullanıldı.
Bebek bebek1 = new Bebek(); //parametreleri newleyerek olusturduğumuz bebek
bebek1._name = "Annie";
bebek1._lastName = "Yakarow";
bebek1.kimlikyazdir(); //metot kullanıldı
Console.ReadKey();