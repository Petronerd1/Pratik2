using System;

namespace DaireAlan
{
    class Program
    {
        static void Main(string[] args)
        {
            double yarıcap = 0, alan = 0, cevre = 0;
            const double pi = 3.14;
            Console.Write("Dairenin yarıçapını girniz : ");
            yarıcap = Convert.ToDouble(Console.ReadLine());
            alan = pi * Math.Pow(yarıcap, 2);
            cevre = 2 * pi * yarıcap;
            Console.WriteLine("Çevre = {0} \nAlan = {1}", cevre, alan);
            Console.ReadKey();
        
        }
    }
}
