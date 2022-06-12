using System;

namespace Lab03
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();
            Car car = new Car();

            bicycle.Company = "Piaggio";
            bicycle.Model = "A1234";
            bicycle.NumberOfTyres = 2;
            int number = bicycle.GetNumberOfTyres();

            Console.WriteLine("Bike called {0} with model {1} has {2} tyres", bicycle.Company, bicycle.Model, number); 
            


            car.Company = "BMW";
            car.Model = "I8";
            car.FrontTyres = 2;
            car.BackTyres = 2;
            int number1 = car.GetNumberOfTyres();

            Console.WriteLine("Car's Company: " + car.Company + "\nCar's Model: " + car.Model + "\nNumber of car's front tyres: "
                + car.FrontTyres+"\nNumber of car's back tyres: "+car.BackTyres + "\nTotal number of car's tyres: "+ number1);

            BankAccount bankAccount = new BankAccount();
            bankAccount.Credit(20000);
            bankAccount.Debit(10000);*/

        static void Main(string[] args)
        {
            Student student = new Student(1, "Nguyen Viet Duc", "Hanoi", "01234567");

            Console.WriteLine(student);
        }
    }
}
