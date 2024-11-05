using P06Abstraction;
using System.Security.Cryptography;

YazilimGelistirici yazilimci1 = new YazilimGelistirici("hasan", "çıldırmış", "yazılım geliştirme");

yazilimci1.kimlik();
yazilimci1.Gorev();
Console.WriteLine();
ProjeYoneticisi projeYoneticisi1 = new ProjeYoneticisi("nermin", "kandırmış","Proje Yönetimi");
projeYoneticisi1.kimlik();
projeYoneticisi1.Gorev();


Console.ReadKey();

