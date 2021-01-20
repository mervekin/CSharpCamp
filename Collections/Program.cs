using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    { //ctrl k + c toplu comment
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin","Murat", "Kerem" };


            List<string> isimler2= new List<string> { "Engin", "Murat", "Kerem" ,"Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);




        }
    }
}
