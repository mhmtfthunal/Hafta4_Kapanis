namespace Hafta4_Kapanis
{
    public class Telefon : BaseMakine
    {
        public bool TrLisansli { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            System.Console.WriteLine($"TR Lisanslı     : {(TrLisansli ? "Evet" : "Hayır")}");
        }

        public override string UrunAdiGetir()
        {
            return $"Telefonunuzun adı ---> {Ad}";
        }
    }
}
