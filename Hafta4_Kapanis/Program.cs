using System;

namespace Hafta4_Kapanis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n=== Teknoloji Mağazası Ürün Üretim ===");
                Console.WriteLine("Telefon üretmek için: 1");
                Console.WriteLine("Bilgisayar üretmek için: 2");
                Console.Write("Seçiminiz: ");
                var secim = Console.ReadLine()?.Trim();

                switch (secim)
                {
                    case "1":
                        TelefonUret();
                        break;
                    case "2":
                        BilgisayarUret();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 girin.");
                        continue;
                }

                Console.Write("\nBaşka bir ürün üretmek ister misiniz? (E/H): ");
                if (!ReadBoolEH())
                {
                    Console.WriteLine("İyi günler!");
                    break;
                }
                Console.Clear();
            }
        }

        static void TelefonUret()
        {
            var tel = new Telefon
            {
                SeriNumarasi = ReadNonEmpty("Seri Numarası: "),
                Ad = ReadNonEmpty("Ad: "),
                Aciklama = ReadOptional("Açıklama (boş geçilebilir): "),
                IsletimSistemi = ReadNonEmpty("İşletim Sistemi: "),
                TrLisansli = ReadBool("TR Lisanslı mı? (E/H): ")
            };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n✔ Ürün başarıyla üretildi: TELEFON");
            Console.ResetColor();

            tel.BilgileriYazdir();
            Console.WriteLine(tel.UrunAdiGetir());
        }

        static void BilgisayarUret()
        {
            var pc = new Bilgisayar
            {
                SeriNumarasi = ReadNonEmpty("Seri Numarası: "),
                Ad = ReadNonEmpty("Ad: "),
                Aciklama = ReadOptional("Açıklama (boş geçilebilir): "),
                IsletimSistemi = ReadNonEmpty("İşletim Sistemi: "),
                Bluetooth = ReadBool("Bluetooth var mı? (E/H): ")
            };

            pc.UsbGirisSayisi = ReadInt("USB Giriş Sayısı (2 veya 4): ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n✔ Ürün başarıyla üretildi: BİLGİSAYAR");
            Console.ResetColor();

            pc.BilgileriYazdir();
            Console.WriteLine(pc.UrunAdiGetir());
        }

        // ==== yardımcılar ====
        static string ReadNonEmpty(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.WriteLine("Bu alan boş bırakılamaz. Lütfen tekrar deneyin.");
            }
        }

        static string ReadOptional(string prompt)
        {
            Console.Write(prompt);
            return (Console.ReadLine() ?? string.Empty).Trim();
        }

        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine()?.Trim();
                if (int.TryParse(input, out int val))
                    return val;

                Console.WriteLine("Geçerli bir tam sayı girin.");
            }
        }

        static bool ReadBool(string prompt)
        {
            Console.Write(prompt);
            return ReadBoolEH();
        }

        // E/e/evet/1/y/yes = true, H/h/hayır/0/n/no = false
        static bool ReadBoolEH()
        {
            while (true)
            {
                var s = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();
                if (s == "e" || s == "evet" || s == "1" || s == "y" || s == "yes")
                    return true;
                if (s == "h" || s == "hayır" || s == "hayir" || s == "0" || s == "n" || s == "no")
                    return false;

                Console.Write("Lütfen E(=Evet) veya H(=Hayır) girin: ");
            }
        }
    }
}
