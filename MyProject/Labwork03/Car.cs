using System;
using System.Collections.Generic;
using System.Text;

namespace Labwork03
{
    class Car
    {
        public string Make;
        public string Model;
        public string Color;
        public int YearBuilt;
        public void Start()
        {
            Console.WriteLine(Model + " started");
        }

        public void Stop()
        {
            Console.WriteLine(Model + " stopped");
        }
    }
}
