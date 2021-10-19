using System;

namespace Negatif_PozitifSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Sayıyı Giriniz : ");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi > 0)
                    Console.WriteLine("{0} sayısı Pozitiftir", sayi);
                else if (sayi < 0)
                    Console.WriteLine("{0} sayısı Negatiftir", sayi);
                else
                    Console.WriteLine("{0} sayısı sıfırdır", sayi);

                Console.ReadKey();
            }
        }
    }
}
