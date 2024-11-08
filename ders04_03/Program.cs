namespace ders04_03
{
    internal class Program
    {
        static int SayiAl(String mesaj) // dönecek sayı formatı türünde fonksiyon olmalı
        {
            Console.Write(mesaj);
            try
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                return sayi;
            }
            catch
            {
                return 0;
            }
        }
        static void Main()
        {
            int sayi1 = SayiAl("Birinci sayıyı giriniz:");
            int sayi2 = SayiAl("İkinci sayıyı giriniz:");
            string text = "{0} + {1} = {2}";
            Console.WriteLine(String.Format(text, sayi1, sayi2, sayi1 + sayi2));
        }
    }
}