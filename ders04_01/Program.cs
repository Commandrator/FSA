namespace ders04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While Kullanımı
            Console.Write("Kaç adet sayı gireceksiniz:");
            int amount = Convert.ToInt32(Console.ReadLine());
            double[] sayilar = new double[amount];
            int index = 0;
            while (index< amount)
            {
                Console.Write($"{index+1}. sayıyı giriniz:");
                sayilar[index] = Convert.ToDouble(Console.ReadLine());
                index++;
            }
            double toplam = 0;
            index = 0;
            while (index< amount)
            {
                toplam += sayilar[index];
                index++;
            }
            double ortalama = toplam / amount;
            Console.WriteLine($"Girilen {amount} adet sayının ortalaması {ortalama} dır.");
        }
    }
}