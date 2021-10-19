using System;

namespace Tek_CiftSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0)
                Console.WriteLine("{0} sayısı çifttir", sayi);
            else
                Console.WriteLine("{0} sayısı tektir", sayi);
            Console.ReadKey();

        }
    }
}
