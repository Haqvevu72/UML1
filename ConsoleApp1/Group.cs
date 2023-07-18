using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Group
    {
        public string? GroupName { get; set; }
        public Teacher? Teacher { get; set; }
        public List<Student>? Students { get; set; }

        public Group(string? groupName, Teacher? teacher, List<Student>? students)
        {
            GroupName = groupName;
            Teacher = teacher;
            Students = students;
        }

        public override string ToString()
        {
            string? students = null;
            for (int i = 0;i<Students.Count;i++) 
            {
                students += Students[i].ToString()+"\n";
            }
            string teacher = Teacher.ToString();

            return $"Group Name: {GroupName}\n" +
                   $"---------------------------\n" +
                   $"Teacher: {teacher}\n" +
                   $"---------------------------\n" +
                   $"Students: {students}";
        }
    }
}
