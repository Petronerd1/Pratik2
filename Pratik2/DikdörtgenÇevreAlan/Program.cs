using System;

namespace DikdörtgenÇevreAlan
{
    class Program
    {
        static void Main(string[] args)
        {

            int ukenar = 0, kkenar = 0, alan = 0, cevre = 0;
            Console.Write("Dikdörtgenin uzun kenarını giriniz : ");
            ukenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörtgenin kısa kenarını giriniz : ");
            kkenar = Convert.ToInt32(Console.ReadLine());
            alan = ukenar * kkenar;
            cevre = (ukenar + kkenar);
            Console.WriteLine("Çevre ={0} \nAlan = {1} ", cevre,alan);
            Console.ReadKey();
        }
    }
}
