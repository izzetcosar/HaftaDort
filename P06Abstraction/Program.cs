using P06Abstraction;
using System.Security.Cryptography;

YazilimGelistirici yazilimci1 = new YazilimGelistirici("hasan", "çıldırmış", "yazılım geliştirme");


yazilimci1.Gorev();
Console.WriteLine();
ProjeYoneticisi projeYoneticisi1 = new ProjeYoneticisi("nermin", "kandırmış","proje yönetimi");

projeYoneticisi1.Gorev();


Console.ReadKey();

