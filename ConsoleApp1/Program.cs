using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself.
            //type safety - tip güvenliği
            //değer tutucu / alias - takma ad
            string kategoriEtiketi = "Kategori";
            int ogrenci = 32000;
            double faizOrani = 3.2;
            bool girisYapmisMi = true;


            double dolarDun = 3.45;
            double dolarBugun = 3.50;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
            //Console.WriteLine(kategoriEtiketi);

            //if (girisYapmisMi == true)
            //{
            //    Console.WriteLine("Kullanıcı ayarları butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap butonu");
            //}

        }
    }
}
