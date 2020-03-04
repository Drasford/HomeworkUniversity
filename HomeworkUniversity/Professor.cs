using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkUniversity
{
    public class Professor
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public List<Course> courses = new List<Course>();

        public Professor(string name, string surname, string email)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
    }
}
