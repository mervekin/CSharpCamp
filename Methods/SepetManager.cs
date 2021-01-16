using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax
        //cw +tab

        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi: " + product.Adi);


        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi: " + urunAdi);

        }

    }
}
