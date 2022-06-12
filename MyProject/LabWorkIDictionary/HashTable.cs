using System;
using System.Collections;

namespace LabWorkIDictionary
{
    class HashTable
    {
        static void Main(string[] args)
        {
            /*HashTable
            Khong quan tam den thu tu sap xep
            Khong cho phep cac gia tri trung nhau va khong duoc null
            Entry quan ly cap key, value
            => nhanh + data nhieu`*/

            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "value");
            hashTable.Add(2, "value");
            hashTable.Add("key", "value");
            hashTable.Add("key3", "value");

            //hashtable with capacity
            Hashtable hastableWithCapacity = new Hashtable(1000);
            hastableWithCapacity.Add("key2", "value2");
            //hastableWithCapacity["key2"] = "value2";

            Console.WriteLine(hastableWithCapacity["key2"].ToString());

            //print entry
            foreach  (DictionaryEntry entry in hastableWithCapacity)
            {
                Console.WriteLine("{0}\t : {1}",entry.Key,entry.Value);
            }

            //print value/key
            foreach  (string value in hashTable.Values)
            {
                Console.WriteLine(value);
            }

            //contain 
            Console.WriteLine("contain key 'key2': {0}", hastableWithCapacity.ContainsKey("key2"));



            
        }
    }
}
