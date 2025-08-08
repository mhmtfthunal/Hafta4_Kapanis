namespace TeknoMagaza
{
    public class Bilgisayar : BaseMakine
    {
        private int _usbGirisSayisi;

        // Encapsulation: sadece 2 veya 4; aksi durumda uyarı + -1
        public int UsbGirisSayisi
        {
            get => _usbGirisSayisi;
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbGirisSayisi = value;
                }
                else
                {
                    System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                    System.Console.WriteLine("Uyarı: Bilgisayar için USB giriş sayısı yalnızca 2 veya 4 olabilir. Değer -1 olarak atandı.");
                    System.Console.ResetColor();
                    _usbGirisSayisi = -1;
                }
            }
        }

        public bool Bluetooth { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            System.Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
            System.Console.WriteLine($"Bluetooth       : {(Bluetooth ? "Var" : "Yok")}");
        }

        public override string UrunAdiGetir()
        {
            return $"Bilgisayarınızın adı ---> {Ad}";
        }
    }
}
