using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkUniversity
{
    public enum TypeOfCourse
    {
        Compulsory, Elective
    }
    public enum Language
    {
        MK, AL, EN
    }

    public class Course
    {
        public int code { get; set; }
        public string nameOfCourse { get; set; }
        public int credits { get; set; }

        public TypeOfCourse typeOfCourse;

        public Language language;

        public List<Student> courseStudents = new List<Student>();

        public Course(int code, string nameOfCourse, int credits, TypeOfCourse typeOfCourse, Language language)
        {
            this.code = code;
            this.nameOfCourse = nameOfCourse;
            this.credits = credits;
            this.typeOfCourse = typeOfCourse;
            this.language = language;
        }

        public void EnrollStudentToCourse(Student student)
        {
            if (courseStudents.Contains(student))
            {
                Console.WriteLine($"{student.name} is allready enrolled to this course");
            }
            else
            {
                Console.WriteLine($"{student.name} was enrolled to {this.nameOfCourse}");
                courseStudents.Add(student);
            }
        }

        public void ListCourseStudents()
        {
            foreach (Student student in courseStudents)
            {
                Console.WriteLine($"{student.name} is enrolled to {this.nameOfCourse}");
            }
        }
    }
}
