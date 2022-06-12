using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string PhoneNumber { get; set; }

        public Student()
        {

        }
        public Student(int Id, string Name, string Address, string Phone)
        {
            StudentID = Id;
            StudentName = Name;
            StudentAddress = Address;
            PhoneNumber = Phone;
        }

        public override string ToString()
        {
            return $"Id of the student: {StudentID},\nname: {StudentName},"+$"\n address: {StudentAddress},"+$"\n{PhoneNumber}";

        }
    }
}
