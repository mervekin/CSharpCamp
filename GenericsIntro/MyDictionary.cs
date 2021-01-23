using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary< TKey,TValue >
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];


        }
        public void Add(TKey key, TValue value)
        {
            TKey[] temp = keys;
            TValue[] tempvalues = values;

            keys = new TKey[keys.Length+1];
            values = new TValue[values.Length + 1];

            for(int i=0; i < temp.Length; i++)
            {
                keys[i] = temp[i];
                values[i]=tempvalues[i];
            }
            for(int j =0;j<temp.Length; j++)
            {
                if (key == null)
                {
                    throw new ArgumentNullException("Key cannot be null.");
                }
                else if (temp[j].Equals(key))
                {
                    throw new ArgumentException("An element with the same key already exists in key array");
                }

            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}
