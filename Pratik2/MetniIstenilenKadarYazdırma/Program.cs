using System;

namespace MetniIstenilenKadarYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı Giriniz :");
            string ad = Console.ReadLine();
            Console.Write("Tekrar sayısını girniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("{0}.{1}",(i + 1), ad);
            }
            Console.ReadKey();
        }
    }
}
