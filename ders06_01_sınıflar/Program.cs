namespace ders06_01_sınıflar
{
    internal class Program
    {
        static void Main()
        {
            //Öğrenci 1
            Ogrenci ogr1 = new Ogrenci();//New obje oluşturmak için kullanılmaktadır.
            ogr1.isim = "Talha";
            ogr1.soyisim = "Yaşar";
            ogr1.final = 80;
            ogr1.vize = 100;

            Ogrenci ogr2 = new Ogrenci();//New obje oluşturmak için kullanılmaktadır.
            ogr2.isim = "Nefise";
            ogr2.soyisim = "Yaşar";
            ogr2.final = 95;
            ogr2.vize = 100;
            string text = "{0,-4} |{1,-15} | {2,-15} | {3,-10} | {4,-10}";
            Console.WriteLine(String.Format(text, "#", "İsim", "Soyisim", "Vize", "Final", "not"));
            Console.WriteLine(String.Format(text, 1, ogr1.isim, ogr1.soyisim, ogr1.vize, ogr1.final, ogr1.vize * 0.4 + ogr1.final * 0.6));
            Console.WriteLine(String.Format(text, 2, ogr2.isim, ogr2.soyisim, ogr2.vize, ogr2.final, ogr2.vize * 0.4 + ogr2.final * 0.6));
        }
    }
}