using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {   //#type safety - tip güvenliği burda ve java da önemli ve katıdır.
            //Do not repeat yourself
            //deger tutucu ,alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirirsYamisMi = false;
            double dolarBugun = 7.32;

            if (sistemeGirirsYamisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

         

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
