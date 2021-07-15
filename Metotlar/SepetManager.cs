using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention 
        //syntax
        public void Ekle(Product urun) // Product urun bir parametredir. Product class'tır. urun ise bizim kullanacağımız nesneye verdiğimiz herhangi bir isim olabilir.
        {
            Console.WriteLine("Tebrikler. Ürün sepete eklendi. Ürün ismi: "+ urun.Adi);
        }
    }
}
