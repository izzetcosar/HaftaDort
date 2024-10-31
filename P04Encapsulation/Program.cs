using P04Encapsulation;

araba araba1 = new araba();
araba1.marka = "Mercedes-Benz";
araba1.model = "C180";
araba1.renk = "İnci Beyazı";
araba1.kapiSayisi = 4;
araba1.ArabaBilgileriniGöster();
Console.WriteLine();

araba araba2 = new araba();
araba1.marka = "BMW";
araba1.model = "M3";
araba1.renk = "Parlement Mavisi";
araba1.kapiSayisi = 2;
araba1.ArabaBilgileriniGöster();
Console.WriteLine();

araba araba3 = new araba();
araba1.marka = "Dacia";
araba1.model = "Duster";
araba1.renk = "Siyah";
araba1.kapiSayisi = 1;
araba1.ArabaBilgileriniGöster();

Console.ReadKey();