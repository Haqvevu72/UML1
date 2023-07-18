using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        public float Average { get; set; }
        public Student(string name, string surname, int age, float average) : base(name, surname, age)
        {
            Average = average;
        }

        public override string ToString()
        {
            return base.ToString()+$"\t\tAverage: {Average}";
        }
    }
}
