namespace ders04_05
{
    internal class Program
    {
        static string MetinAl(string msg)
        {
            Console.Write(msg);
            string metin = Console.ReadLine();
            return metin;
        }
        static double SayiAl(string msg)
        {
            Console.Write(msg);
            double sayi = Convert.ToDouble(Console.ReadLine());
            return sayi;
        }
        static void Main(string[] args)
        {
            //Liste kullanımı
            //Format: List<dataType> varaible = new List<dataType>();
            List<string> isimler = new List<string>();
            List<string> soyisimler = new List<string>();
            List<double> vizeler = new List<double>();
            List<double> finaller = new List<double>();
            Console.Write("Kaç öğrenci bilgisi girilecek:");
            int ogrrenciSayisi = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (int i = 0;i< ogrrenciSayisi; i++)
            {
                isimler.Add(MetinAl(String.Format("{0}. öğrenci adı:",i+1)));
                soyisimler.Add(MetinAl(String.Format("{0}. öğrencinin soyadı:",i + 1)));
                vizeler.Add(SayiAl(String.Format("{0}. öğrencinin vize notu:", i+1)));
                finaller.Add(SayiAl(String.Format("{0}.  öğrencinin final notu:", i + 1)));
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write($"|   | {"İsim",-10} | {"Soyisim",-10} | {"Vize",5} "
                        + $"| {"Final",5} | {"GNotu",5} |\n");
            Console.Write("--------------------------------------------------------\n");
            for (int i = 0; i < ogrrenciSayisi; i++)
            {
                Console.Write($"| {i + 1} | {isimler[i],-10} | {soyisimler[i],-10} | {vizeler[i],5} "
                            + $"| {finaller[i],5} | {(vizeler[i] * 0.4 + finaller[i] * 0.6),5} |\n");
            }
            //List<string> isimler = new List<string>();
            //List<string> soyisimler = new List<string>();
            //List<double> vizeler = new List<double>();
            //List<double> finaller = new List<double>();

            //isimler.Add("Ramazan");
            //isimler.Add("Ahmet");
            //isimler.Add("Zeynep");

            //soyisimler.Add("Doğan");
            //soyisimler.Add("Şahin");
            //soyisimler.Add("Türe");

            //vizeler.Add(60);
            //vizeler.Add(50);
            //vizeler.Add(40);

            //finaller.Add(70);
            //finaller.Add(50);
            //finaller.Add(60);

            //Console.Write($"|   | {"İsim",-10} | {"Soyisim",-10} | {"Vize",5} "
            //            + $"| {"Final",5} | {"GNotu",5} |\n");
            //Console.Write("--------------------------------------------------------\n");
            //Console.Write($"| 1 | {isimler[0],-10} | {soyisimler[0],-10} | {vizeler[0],5} "
            //            + $"| {finaller[0],5} | {(vizeler[0] * 0.4 + finaller[0] * 0.6),5} |\n");
            //Console.Write($"| 2 | {isimler[1],-10} | {soyisimler[1],-10} | {vizeler[1],5} "
            //            + $"| {finaller[1],5} | {(vizeler[1] * 0.4 + finaller[1] * 0.6),5} |\n");
            //Console.Write($"| 3 | {isimler[2],-10} | {soyisimler[2],-10} | {vizeler[2],5} "
            //            + $"| {finaller[2],5} | {(vizeler[2] * 0.4 + finaller[2] * 0.6),5} |\n");
        }
    }
}