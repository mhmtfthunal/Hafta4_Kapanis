using System;

namespace Hafta4_Kapanis
{
    // Inheritance + Abstraction
    public abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; }  // ctor'da otomatik atanır
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        protected BaseMakine()
        {
            UretimTarihi = DateTime.Now; // Telefon ve Bilgisayar için geçerli
        }

        // Polymorphism: temel bilgiler
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine("=== Ürün Bilgileri ===");
            Console.WriteLine($"Üretim Tarihi   : {UretimTarihi:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Seri Numarası   : {SeriNumarasi}");
            Console.WriteLine($"Ad              : {Ad}");
            Console.WriteLine($"Açıklama        : {Aciklama}");
            Console.WriteLine($"İşletim Sistemi : {IsletimSistemi}");
        }

        // Abstraction: alt sınıflar isim mesajını özelleştirir
        public abstract string UrunAdiGetir();
    }
}
