using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, string surname, int age, string subject) : base(name, surname, age)
        {
            Subject = subject;
        }

        public override string ToString()
        {
            return base.ToString()+$"\t\tSubject: {Subject}";
        }
    }
}
