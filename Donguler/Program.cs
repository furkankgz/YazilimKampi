using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirici Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //foreach dizi temelli yapıları tek tek dönmeye yarıyor
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
