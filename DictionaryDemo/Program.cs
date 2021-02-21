using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(2212, "METEHAN YETKİN");
            myDictionary.Add(3242, "MERT YETKİN");
            myDictionary.Add(2212, "TUGBA ÖKSÜM");
            myDictionary.Add(2322, "ALİ KILIC");
            myDictionary.List();
        }
    }
    class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key, V value)
        {
            K[] TempKey = keys;
            V[] TempValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];
            for (int i = 0; i < TempKey.Length; i++)
            {
                keys[i] = TempKey[i];
                values[i] = TempValues[i];

            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public void List()
        {
            foreach (K data in keys)
            {
                Console.WriteLine("Number:{0} ", data);
            }
            foreach (V data2 in values)
            {
                Console.WriteLine("Name:{0}", data2);
            }
        }
    }
}
