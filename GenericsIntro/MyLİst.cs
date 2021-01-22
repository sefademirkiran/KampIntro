using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyLİst<T>
    {
        T[] items;
        public MyLİst()
        {
            items new = T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;         //geçici dizi 
            items = new T[items.Length+1]; //eleman sayısı 1 arttı.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
        public int Lenght
        {
            get { return Lenght}
        }
    }
}
