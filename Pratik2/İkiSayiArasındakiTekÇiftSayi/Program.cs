using System;

namespace İkiSayiArasındakiTekÇiftSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Başlangıç Değerini Giriniz : ");
            int baslangic = int.Parse(Console.ReadLine());
            Console.Write("Bitiş Değerini Griniz : ");
            int bitiş = int.Parse(Console.ReadLine());
            for (int i = baslangic; i<bitiş; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0} çifttir", i);
                else if (i % 2 == 1)
                    Console.WriteLine("{0} tektir",i);
            }
            Console.ReadKey();
        }
    }
}
