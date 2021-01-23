using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("merve");

            MyDictionary<int, string> müsteriler = new MyDictionary<int, string>();
            müsteriler.Add(12, "Leyla");
        }
    }
}
