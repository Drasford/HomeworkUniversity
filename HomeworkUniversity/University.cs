using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkUniversity
{
    public class University
    {
        public string name { get; set; }
        public string location { get; set; }
        public List<Faculty> faculties = new List<Faculty>();

        public University(string name, string location)
        {
            this.name = name;
            this.location = location;
        }

        public void AddFaculty(Faculty faculty)
        {
            if (faculties.Contains(faculty))
            {
                Console.WriteLine($"Faculty {faculty.name} already exist in this University");
            }
            else
            {
                Console.WriteLine($"{faculty.name} was added !");
                faculties.Add(faculty);
            }
        }

        public void FindLargestFaculty()
        {
            if(faculties.Count == 0)
            {
                Console.WriteLine($"{this.name} has no faculties");
            }
            else
            {
                var biggest = faculties.OrderByDescending(faculty => faculty.maxNumOfStudents).First();
                Console.WriteLine($"{biggest.name} has the most students in {this.name}");
            }
            
        }
    }
}
