using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkUniversity
{
    public class Faculty
    {
        public string name { get; set; }
        public int maxNumOfStudents { get; set; }

        public List<Professor> professors = new List<Professor>();
        public List<Student> students = new List<Student>();

        public Faculty(string name, int maxNumOfStudents)
        {
            this.name = name;
            this.maxNumOfStudents = maxNumOfStudents;
        }

        public void EnrollStudent(Student student)
        {
            if (maxNumOfStudents <= students.Count)
            {
                Console.WriteLine($"{this.name} is full of students!! ova samo u programava se desava");
            }
            else
            {
                if (students.Contains(student))
                {
                    Console.WriteLine($"{student.name} is already enrolled!!!!!");
                }
                else if (maxNumOfStudents <= students.Count)
                {
                    Console.WriteLine("This fax is full!");
                }
                else
                {
                    Console.WriteLine($"{student.name} was enrolled to {this.name}");
                    students.Add(student);
                }
            }

        }

        public void ListStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine($"{this.name} has no enrolled students!");
            }
            else
            {
                foreach (Student student in students)
                {
                    Console.WriteLine($"Studentot {student.name} studira na {name}!");
                }
            }

        }
        public void ListTypeOfStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine($"{this.name} has no enrolled students!");
            }
            else
            {
                var tipovi =
                    from stud in students
                    group stud by stud.typeOfStudent into gstud
                    select new
                    {
                        typeOfStudent = gstud.Key,
                        Count = (from stud in gstud select stud.typeOfStudent).Count()
                    };

                Console.WriteLine($"{this.name} ima:");
                foreach (var item in tipovi)
                {
                  Console.WriteLine($"{item.typeOfStudent} ------  {item.Count}");
                }
            }
        }
    }
}
