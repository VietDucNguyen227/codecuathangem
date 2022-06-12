using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.firstName = "Bui Thi";
            customer.lastName = "Tu";
            customer.phoneName = "12345678";
            customer.emailAddress = "Tu@gmail.com";

            Console.WriteLine("First name of customer is: " + customer.firstName);
            Console.ReadLine();


            
        }
    }
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneName { get; set; }
        public string emailAddress { get; set; }

        public string getFullname()
        {
            return firstName + " " + lastName;
        }
    }
}
