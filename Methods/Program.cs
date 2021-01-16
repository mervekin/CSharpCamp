using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";
            product1.StokAdedi = 23;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";
            product2.StokAdedi =50;

            Product[] products = new Product[] { product1, product2 };

            //type-safe
            foreach (Product product in products)
            {
              
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("------------------Metotlar---------------------");

            //Instance - örnek
            //Encapsulation : 

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);


            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu",12);



            Console.ReadLine();
        }
    }
}
//Dont reperat yourself -DRY - Clean Code - Best Practice