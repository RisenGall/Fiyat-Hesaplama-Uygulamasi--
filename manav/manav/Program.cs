internal class Program
{
    private static void Main(string[] args)
    {
        double kgelma, kgmuz, kgcilek, kgportakal, ödeme;
        int fiyate = 14;
        int fiyatm = 44;
        int fiyatc = 60;
        int fiyatp = 20;
        

        Console.WriteLine("Hoşgeldiniz! Lütfen satın almak istediğiniz ürünlerin ağırlık değerlerini giriniz?");
        Console.WriteLine("Elma kg: ");
        kgelma=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Muz kg: ");
        kgmuz=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Çilek kg: ");
        kgcilek=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Portakal kg: ");
        kgportakal=Convert.ToDouble(Console.ReadLine());

        if (kgelma > 10)
        {
            fiyate = 10;
        }
        if (kgmuz > 5)
        {
            fiyatm = 42;
        }
        if (kgcilek > 5)
        {
            fiyatc = 50;
        }
        if (kgportakal > 10) 
        {
            fiyatp = 15;
        }

        ödeme = kgelma * fiyate + kgmuz * fiyatm + kgcilek * fiyatc + kgportakal * fiyatp;
        Console.WriteLine(ödeme + " TL ödemelisiniz. ");

    }
}