// BaseGeometrikSekil sınıfı
public class BaseGeometrikSekil
{
    public double Genişlik { get; set; }
    public double Yükseklik { get; set; }

    public BaseGeometrikSekil(double genişlik, double yükseklik)
    {
        Genişlik = genişlik;
        Yükseklik = yükseklik;
    }

    // Polimorfizm için sanal alan hesaplama metodu
    public virtual double AlanHesapla()
    {
        return Genişlik * Yükseklik; // Default olarak Kare ve Dikdörtgenler için
    }
    public virtual void AlanYazdir()
    {
        Console.WriteLine($"Alan: {AlanHesapla()}");
    }
}

// Kare sınıfı
public class Kare : BaseGeometrikSekil
{
    public Kare(double kenar) : base(kenar, kenar)
    {
    }

    public override double AlanHesapla()
    {
        return Genişlik * Yükseklik; // Kare olduğu için Genişlik x Yükseklik, yani kenar^2
    }
    public override void AlanYazdir()
    {
        Console.WriteLine($"Kare Alanı: {AlanHesapla()}");
    }
}


public class Dikdortgen : BaseGeometrikSekil
{
    public Dikdortgen(double genişlik, double yükseklik) : base(genişlik, yükseklik)
    {
    }

    public override double AlanHesapla()
    {
        return Genişlik * Yükseklik; // Dikdörtgen alanı = Genişlik x Yükseklik
    }
    public override void AlanYazdir()
    {
        Console.WriteLine($"Dikdörtgen Alanı: {AlanHesapla()}");
    }
}


public class DikUcgen : BaseGeometrikSekil
{
    public DikUcgen(double genişlik, double yükseklik) : base(genişlik, yükseklik)
    {
    }

    public override double AlanHesapla()
    {
        return (Genişlik * Yükseklik) / 2; // Dik üçgen alanı = (Genişlik x Yükseklik) / 2
    }
    public override void AlanYazdir()
    {
        Console.WriteLine($"Dik Üçgen Alanı: {AlanHesapla()}");
    }
}