using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1= ? 30 olur

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]= ? 999  olur.

            //int,decimali float doun-ble bool= değer tip sadece değeri kopyalar ve ilişki biter olay değer ile ilgilidir.
            //array , class, interface -> referans tiptir.

            //stack değer tip olanlar burda gerçekleşir            //heap 
            //sayi1 =30 sayi1 değeri 30 dur diye okunur .

            //stack                                                            //heap
            // 101/sayilar1 tanımlanır  new dediğn zamna heapte yer açılır   ---------->         101/ [10,20,30]
            // 102/sayilar2                                                  -------------->     102/[100,200,300]         

                //ikisi de referans tip olduğu için adrsi kopyalar yani adres atar 
               // 102 n referans numarasını 101  referansı yerine atanır.
               // ve artık sayilar1 adresi referansi 102dir ve 101 referanslı arrrayı kimse tutmuyor ve garbage collection ile silinir bellekten.

        }
    }
}
