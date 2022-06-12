using System;
using System.Collections;

namespace LabWorkArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] dataList = new string[] { "Minh", "Linh", "Duc" };
            ArrayList studentList = new ArrayList(dataList);

            foreach ( string stu in studentList) 
            {
                Console.WriteLine(stu);
            }


            ArrayList customer = new ArrayList();
            customer.Add("Thao");
            customer.Add("Quang");
            customer.Add("Long");
            customer.Add("Hiep");
            customer.Insert(2, "Duc");

            ArrayList dataCustomer = new ArrayList();
            dataCustomer.AddRange(customer);
            //customer.RemoveRange(1, 3);

            customer.Contains("Thao");

            for (int i = 0; i < customer.Count; i++)
            {
                Console.WriteLine(customer[i]);
            }
            
            //reverse
            customer.Reverse();
            foreach  (string cus in customer)
            {
                Console.WriteLine(cus);
            }

            //sort
            customer.Sort();
            foreach  (string cusSort in customer)
            {
                Console.WriteLine(cusSort);
            }

            //extract range of values
            ArrayList extractCustomer = customer.GetRange(3, 1); //lấy từ vị trí thứ 3, lấy 1 thằng

            foreach (string extract in extractCustomer)
            {
                Console.WriteLine(extract);
            }



        }   
    }
}
