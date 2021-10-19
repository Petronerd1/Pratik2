using System;

namespace FiyatAdet
{
    class Program
    {
        static void Main(string[] args)
        {
            double fiyat = 0;
            int adet = 0;
            Console.Write("Ürün Fiyatını Giriniz : ");
        OkuFiyat:
            fiyat = Convert.ToDouble(Console.ReadLine());
            if(fiyat <= 0)
            {
                Console.Write("Yanlış fiyat bilgisi girdiniz.\nFiiyatı tekrardan giriniz.");
                goto OkuFiyat;
            }
            Console.Write("Aldığınız ürün miktarını giriniz.");
        OkuAdet:
            adet = Convert.ToInt32(Console.ReadLine());

            if(adet <=0)
            {
                Console.Write("Yanlış miktar bilgisi girdiniz.\nAldığınız ürün miktarını tekrar giriniz.");
                goto OkuAdet;
            }
            double tutar = fiyat * adet;
            Console.WriteLine("Ödeyeceğiniz toplam tutar {0} TL",tutar);
            Console.ReadKey();
        }
    }
}
