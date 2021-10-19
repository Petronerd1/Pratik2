using System;

namespace BüyükOlanSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci Sayı : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayı : ");
            int sayi2 = int.Parse(Console.ReadLine());

            if (sayi1 > sayi2)
                Console.WriteLine("{0} sayısı büyüktür", sayi1);
            else if (sayi2 > sayi1)
                Console.WriteLine("{0} sayısı büyüktür", sayi2);
            else
                Console.WriteLine("{0} sayısı {1} sayısına eşittir.",sayi2,sayi1);
            Console.ReadKey();

        }
    }
}
