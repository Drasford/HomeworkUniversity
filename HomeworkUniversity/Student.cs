using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkUniversity
{
    public enum TypeOfStudent
    {
        Regular, Associate
    }
    public enum MartialStatus
    {
        Singel, Married, Divorced, Seperated, Widowed
    }

    public class Student
    {
        public string name { get; set; }
        public string surname { get; set; }

        public bool driving = false;
        public string email { get; set; }
        public DateTime dateOfEnrollment = new DateTime();

        public string eMBG { get; set; }



        public DateTime dateGraduated = new DateTime();

        public TypeOfStudent typeOfStudent;

        public MartialStatus martialStatus;

        public Student(string name, string surname, bool driving, string email, DateTime dateOfEnrollment, string eMBG, DateTime dateGraduated, TypeOfStudent typeOfStudent, MartialStatus martialStatus)
        {
            this.name = name;
            this.surname = surname;
            this.driving = driving;
            this.email = email;
            this.dateOfEnrollment = dateOfEnrollment;
            this.eMBG = eMBG;
            this.dateGraduated = dateGraduated;
            this.typeOfStudent = typeOfStudent;
            this.martialStatus = martialStatus;
        }
    }
}
