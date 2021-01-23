using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary");
            Dictionary<string, string> liste = new Dictionary<string, string>();
            liste.Add("Adı", "Canan");
            liste.Add("Soyadı", "Kan");
            Console.WriteLine(liste.Count);
            foreach (KeyValuePair<string,string> item in liste)
            {
                Console.WriteLine(item.Key.ToString() + ":" + item.Value.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("MyDictionary");
            MyDictionary<string, string> liste2 = new MyDictionary<string, string>();
            liste2.Add("Adı", "Veli");
            liste2.Add("Adı", "Kan");
            Console.WriteLine(liste2.Count());
            liste2.List();
        }
    }


    class MyDictionary<TKey,TValue>
    {
        //Burada dizilerden yararlanarak dictionary yapısını oluşturmaya çalıştım.
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public int Count() {
            return keys.Length;
        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + ":" + values[i]);
            }
        }
    }

}
