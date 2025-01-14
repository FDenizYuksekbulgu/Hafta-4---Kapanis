

class Program
{
    static void Main(string[] args)
    {
        bool devamEt = true;
        //Telefon ve Bilgisayar seçimli ikili varyasyon içerir.
        while (devamEt) //Döngü için kontrol değişkeni, kullanıcı istemediği sürece devam edecektir.
        {
            Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız:");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1) //Telefon üretmen için kullanılacak yol.
             {
                Telefon telefon = new Telefon();

                Console.Write("Seri Numarası: ");
                telefon.SeriNumarasi = Console.ReadLine();

                Console.Write("Ad: ");
                telefon.Ad = Console.ReadLine();

                Console.Write("Açıklama: ");
                telefon.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                telefon.IsletimSistemi = Console.ReadLine();

                Console.Write("TR Lisanslı mı? (Evet/Hayır): ");
                telefon.TrLisansli = Console.ReadLine().ToLower() == "evet";

                Console.WriteLine("Ürün başarıyla üretildi!");
                telefon.BilgileriYazdir();
                telefon.UrunAdiGetir();
            }
            else if (secim == 2) //Bilgisayar üretmek için kullanılacak yol.
            {
                Bilgisayar bilgisayar = new Bilgisayar();

                Console.Write("Seri Numarası: ");
                bilgisayar.SeriNumarasi = Console.ReadLine();

                Console.Write("Ad: ");
                bilgisayar.Ad = Console.ReadLine();

                Console.Write("Açıklama: ");
                bilgisayar.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                bilgisayar.IsletimSistemi = Console.ReadLine();

                Console.Write("USB Giriş Sayısı (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bluetooth var mı? (Evet/Hayır): ");
                bilgisayar.Bluetooth = Console.ReadLine().ToLower() == "evet";

                Console.WriteLine("Ürün başarıyla üretildi!");
            }
        }
    }
}