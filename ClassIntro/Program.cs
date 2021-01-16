using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Merve";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 70;

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);

                
            }
            Console.ReadLine();
        }
     
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    class Product
    {
        public string  Name { get; set; }
        public double Price { get; set; }
        public string  Type { get; set; }
        public string NumberOfLikes { get; set; }
    }
    
}
