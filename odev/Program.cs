using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            pc pc1 = new pc();
            pc1.pcMarka = "Monster";
            pc1.pcPuan = 9;
            pc1.pcFiyat = 6000;

            pc pc2 = new pc();
            pc2.pcMarka = "Lenovo";
            pc2.pcPuan = 9;
            pc2.pcFiyat = 6000;

            pc pc3 = new pc();
            pc3.pcMarka = "Huawei";
            pc3.pcPuan = 9;
            pc3.pcFiyat = 6000;

            pc[] pcler = new pc[] { pc1, pc2, pc3 };

            foreach (var Pc in pcler)
            {
                Console.WriteLine(Pc.pcMarka + " bilgisayar " + Pc.pcPuan + " puan " + Pc.pcFiyat+" TL ");
            }

            Console.WriteLine("-----------------------------------------------");

            arac arac1 = new arac();
            arac1.aracAd = "Volvo";
            arac1.aracYil = 2020;

            arac arac2 = new arac();
            arac2.aracAd = "Fiat";
            arac2.aracYil = 2020;

            arac arac3 = new arac();
            arac3.aracAd = "BMW";
            arac3.aracYil = 2020;

            arac[] araclar = new arac[] { arac1, arac2, arac3 };

            for (int i = 0; i < araclar.Length; i++)
            {
                Console.WriteLine(araclar[i].aracAd+" "+araclar[i].aracYil);
            }

            Console.WriteLine("-----------------------------------------------");

            tel tel1 = new tel();
            tel1.telMarka = "Apple";
            tel1.telPuan = 10;
            tel1.telFiyat = 9000;

            tel tel2 = new tel();
            tel2.telMarka = "Samsung";
            tel2.telPuan = 10;
            tel2.telFiyat = 9000;

            tel tel3 = new tel();
            tel3.telMarka = "Sony";
            tel3.telPuan = 10;
            tel3.telFiyat = 9000;

            tel[] teller = new tel[] { tel1, tel2, tel3 };

            int j = 0;
            while (j<teller.Length)
            {
                Console.Write(teller[j].telMarka + " " + teller[j].telPuan + " " + teller[j].telFiyat+" \n");
                j++;
            }

        }
    }
    class pc
    {
        public string pcMarka { get; set; }
        public int pcFiyat { get; set; }
        public int pcPuan { get; set; }
    }
    class arac
    {
        public string aracAd { get; set; }
        public int aracYil { get; set; }

    }

    class tel
    {
        public string telMarka { get; set; }
        public int telFiyat { get; set; }
        public int telPuan { get; set; }

    }
}
