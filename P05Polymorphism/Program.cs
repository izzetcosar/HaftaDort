// Kare nesnesi
BaseGeometrikSekil kare = new Kare(5);
kare.AlanYazdir();  

// Dikdörtgen nesnesi
BaseGeometrikSekil dikdortgen = new Dikdortgen(4, 6);
dikdortgen.AlanYazdir();  

// Dik üçgen nesnesi
BaseGeometrikSekil dikUcgen = new DikUcgen(3, 7);
dikUcgen.AlanYazdir();  
Console.ReadKey();