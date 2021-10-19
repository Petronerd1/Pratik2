using System;

namespace _20SayiOrtalama
{
    class Program
    {
        static void Main(string[] args)
        {
            double snotu = 0, ortalama = 0, toplam = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. notu giriniz:",(i+1));
            Okunot:
                snotu = Convert.ToDouble(Console.ReadLine());
                if(snotu <0 || snotu>100)
                {
                    Console.Write("Yanlış not girdiniz.\nTekrardan giriniz : ");
                    goto Okunot;
                }
                toplam += snotu;
            }
            ortalama = toplam/20;
            Console.WriteLine("Toplam={0}\nOrtalama={1}",toplam,ortalama);
            Console.ReadKey();
        }
    }
}
