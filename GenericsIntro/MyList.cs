using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor newlediğin an çalışan sınıf constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {   //yeni eleman gelince önceki referasın numarası uçmasın diye tempe atıyoruz eskiyi
            T[] tempArray = items;
            items = new T[items.Length + 1];//eleman sayısını bir arttırdım.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //tempArraya geçici attığımız elemanları yeniden items arrayına  atıyoruz

            }
            items[items.Length - 1] = item; //eklenmek istenen eleman eklendi.

        }
        
    }
}
