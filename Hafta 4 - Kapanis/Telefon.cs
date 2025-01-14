using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknolojiMagazasi;

//Telefon BaseMakine'den türetilmiş bir Telefon sınıfı
public class Telefon : BaseMakine
{
    public bool TrLisansli { get; set; } //TR Lisanslı olup olmadığını belirler.

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"TR Lisanslı: {TrLisansli}");
    }

    public override void UrunAdiGetir() //UrunAdiGetir metodunu ezerek telefon adı yazdırıyoruz.
    {
        Console.WriteLine($"Telefonunuzun adı: {Ad}");
    }
}