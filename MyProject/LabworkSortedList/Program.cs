using System;
using System.Collections;

namespace LabworkSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //create sorted list
            SortedList sortedList = new SortedList();
            SortedList sortedList1 = new SortedList(new CaseInsensitiveComparer());
            sortedList.Add(1, "apple");
            sortedList.Add(2, "samsung");
            sortedList.Add(3, "xiaomi");
            sortedList.Add(4, "nokia");

            for (int i = 0; i < sortedList.Count; i++)
            {
                sortedList.GetKey(i);
                
            }



            //copying from hashtable to sortedlist
            Hashtable hashtable = new Hashtable();
            hashtable.Add("key1", "value1");
            hashtable.Add("key2", "value2");
            

            SortedList sortedListWithHashTable = new SortedList(hashtable, new CaseInsensitiveComparer());

            //in entry
            foreach (DictionaryEntry entry in sortedListWithHashTable)
            {
                Console.WriteLine("{0} \t : {1}", entry.Key, entry.Value);
            }

            //in value/key
            foreach (string values in sortedListWithHashTable.Values)
            {
                Console.WriteLine(values);
                
            }
            
            //other way
            IList keys = sortedListWithHashTable.GetKeyList(); 
        }
    }
}
