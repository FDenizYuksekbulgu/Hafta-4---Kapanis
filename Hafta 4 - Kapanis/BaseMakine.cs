using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TeknolojiMagazasi
{
    //Base Class oluşturuldu. 
    public abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; private set; }
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        //Constructor ile Üretim Tarihi otomatik olarak o anki tarih ve saatle atanacaktır.
        public BaseMakine()
        {
            UretimTarihi = DateTime.Now;
        }

        //Genel bilgileri, ortak olanları yazdıran metot aşağıdaki gibidir.
        //Virtual ile yaptık sonrasında override edebilelim diye.
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
        }

        //Abstract(Soyut) metot
        public abstract void UrunAdiGetir();
    }