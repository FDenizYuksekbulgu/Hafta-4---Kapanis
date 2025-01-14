using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknolojiMagazasi;

//BaseMakine'den türetilmiş bir Bilgisayar sınıfı
public class Bilgisayar : BaseMakine
{
    private int usbGirisSayisi;
    public int UsbGirisSayisi
    {
        get => usbGirisSayisi; //USB giriş sayısının getirir.
        set
        {
            if (value == 2 || value == 4)
                usbGirisSayisi = value;
            else
            {   //USB giriş sayısı 2 veya 4 olmalıdır.
                Console.WriteLine("USB giriş sayısı 2 veya 4 olmalıdır. Varsayılan olarak -1 atandı.");
                usbGirisSayisi = -1;
            }
        }
    }
    public bool Bluetooth { get; set; }

    public override void BilgileriYazdir() //Bilgileri yazdırma metodunu override ediyoruz.
    {
        base.BilgileriYazdir(); //Bilgileri yazdırma metodunu override ediyoruz.
        Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
        Console.WriteLine($"Bluetooth: {Bluetooth}");
    }

    public override void UrunAdiGetir() //UrunAdiGetir metodunu ezerek bilgisayar adı yazdırıyoruz.
    {
        Console.WriteLine($"Bilgisayarınızın adı: {Ad}");
    }
}