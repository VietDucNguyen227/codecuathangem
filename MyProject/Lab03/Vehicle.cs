using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    public abstract class Vehicle {

        //cho phép ghi đè khi lớp con kế thừa lại phương thức abstract
        public abstract int GetNumberOfTyres();
        public string GetModel()
        {
            return "year";
        }
    }

    public class Bicycle : Vehicle //":" là extend/implement
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public int NumberOfTyres { get; set; }
        public override int GetNumberOfTyres()
        {
            return NumberOfTyres;
        }
    }

    public class Car : Vehicle
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public int FrontTyres { get; set; }
        public int BackTyres { get; set; }
        public override int GetNumberOfTyres()
        {
            return FrontTyres + BackTyres;
        }
    }
}
