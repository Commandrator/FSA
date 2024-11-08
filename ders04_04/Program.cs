namespace ders04_04
{
    internal class Program
    {
        //double sayı alma fonksiyonu
        static double SayiAl(string msg)
        {
            // gelen mesajı ekrana bastırılır, ardından veri alma işlemi başlatılır.
            Console.Write(msg);
            try
            {
                double sayi = Convert.ToDouble(Console.ReadLine());
                return sayi;
            }
            catch
            {
                return 0;
            }
        }
        static string IslemAl(string msg)
        {
            Console.Write(msg);
            string islem = Console.ReadLine();
            return islem;
        }
        static void PrintResult(string islem, double s1, double s2, double result)
        {

            string text = "{0} {1} {2} = {3}";
            Console.WriteLine(String.Format(text, s1, islem, s2, result));
        }
        static void Main(string[] args)
        {
            //Sayılar değişkende tutulmak üzere SayıAl fonkiyonu çalıştırılır.
            double sayi1 = SayiAl("Birinci sayıyı giriniz:");
            double sayi2 = SayiAl("İkinci sayıyı giriniz:");
            string islem = IslemAl("İşlem giriniz:");
            double result = 0;
            switch (islem)
            {
                case "+":
                    result = sayi1 + sayi2;
                    PrintResult(islem, sayi1, sayi2, result);
                    break;
                case "-":
                    result = sayi1 - sayi2;
                    PrintResult(islem, sayi1, sayi2, result);
                    break;
                case "*":
                    result = sayi1 * sayi2;
                    PrintResult(islem, sayi1, sayi2, result);
                    break;
                case "/":
                    result = sayi1 / sayi2;
                    PrintResult(islem, sayi1, sayi2, result);
                    break;
                default:
                    Console.WriteLine("Tanımlanmamıiş işlem girdiniz!");
                    break;
            }
        }
    }
}