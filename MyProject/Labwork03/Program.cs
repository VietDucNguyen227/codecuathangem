using System;

namespace Labwork03
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare a Car object reference named myCar
            Car myCar;
            // Create a Car object, and assign its address to myCar
            Console.WriteLine("Creating a Car object and assigning " +
                "its memory location to myCar");
            myCar = new Car();

            myCar.Make = "Toyota";
            myCar.Model = "MR2";
            myCar.Color = "black";
            myCar.YearBuilt = 1995;

            //display
            Console.WriteLine("myCar details:");
            Console.WriteLine("myCar.make:" + myCar.Make);
            Console.WriteLine("myCar.model:" + myCar.Model);
            Console.WriteLine("myCar.color:"+ myCar.Color);
            Console.WriteLine("myCar.yearbuild:" + myCar.YearBuilt);

            //call the methods using myCar
            myCar.Start();
            myCar.Stop();

            //declare another car object
            Console.WriteLine("Creating another Car object and assigning its memory location to redPorsche");
            Car redPorsche = new Car();
            redPorsche.Make = "Porsche";
            redPorsche.Model = "Boxster";
            redPorsche.Color = "red";
            redPorsche.YearBuilt = 2000;
            Console.WriteLine("redPorsche is a "+redPorsche.Model);
            //change the object referenced by the myCar object
            //reference to the object referenced by redPorsche
            Console.WriteLine("Assigning redPorsche to myCar");
            myCar = redPorsche;
            Console.WriteLine("myCar details: ");
            Console.WriteLine("myCar.make:" + myCar.Make);
            Console.WriteLine("myCar.model:" + myCar.Model);
            Console.WriteLine("myCar.color:" + myCar.Color);
            Console.WriteLine("myCar.yearbuild:" + myCar.YearBuilt);
            //assign null to myCar (my Car will no longer reference an object
            myCar = null;
            Console.WriteLine("mycar details: "+ myCar);
            Console.ReadLine();
        }
    }
}
