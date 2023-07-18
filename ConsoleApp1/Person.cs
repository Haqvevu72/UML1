using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Person
    {
        private static int id = 0;
        public  int ID { get; set; }
        public  string Name { get; set; }
        public  string Surname { get; set; }
        public  int Age { get; set; }

        protected Person(string name, string surname, int age)
        {
            ID = ++id;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return $"ID: {ID}\t\tName: {Name}\t\tSurname: {Surname}\t\tAge: {Age} ";
        }
    }
}
