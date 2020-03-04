using System;

namespace HomeworkUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            University university1 = new University("UKIM", "Skopje");
             Faculty faculty1 = new Faculty("FINKI", 10);
              Faculty faculty2 = new Faculty("Ekonomski", 20);
              Faculty faculty3 = new Faculty("Medicina", 1000);

              Professor professor1 = new Professor("Ivan", "Chorbev", "chorbev@finki.ukim.mk");
              Professor professor2 = new Professor("Aristotel", "Tentov", "tentov@ekonomski.ukim.mk");
              Professor professor3 = new Professor("Cvetanka", "manceva", "manceva@medicina.ukim.mk");

              string data = "03/03/2020";
              string dataFinish = "12/12/1990";

              Student student1 = new Student("Dame","Ivanovski",true,"dame@finki.ukim.mk",Convert.ToDateTime(data),"2209997450004",Convert.ToDateTime(null),TypeOfStudent.Regular,MartialStatus.Married);
              Student student2 = new Student("Jovan", "Nakov", true, "jovan@finki.ukim.mk", Convert.ToDateTime(data), "073228646323", Convert.ToDateTime(null), TypeOfStudent.Regular, MartialStatus.Singel);
              Student student3 = new Student("Ana", "Ivanovska", true, "ana@finki.ukim.mk", Convert.ToDateTime(data), "112255445548", Convert.ToDateTime(dataFinish), TypeOfStudent.Associate, MartialStatus.Divorced);

              Course course1 = new Course(11111, "EndavaCourseMK", 6, TypeOfCourse.Compulsory, Language.MK); ;
              Course course2 = new Course(22222, "EndavaCourseAL", 6, TypeOfCourse.Compulsory, Language.AL); ;
              Course course3 = new Course(33333, "EndavaCourseEN", 6, TypeOfCourse.Compulsory, Language.EN); ;

              /* Adding faculties*/
              university1.AddFaculty(faculty1);
              university1.AddFaculty(faculty1);
              university1.AddFaculty(faculty2);
              /*Adding students to faculties*/
              faculty1.EnrollStudent(student1);
              faculty1.EnrollStudent(student1);
              faculty1.EnrollStudent(student2);
              faculty1.EnrollStudent(student3);
            /*Adding a course to a professor*/
            professor1.AddCourse(course1);
                
              /*Faculty listing all students*/
              faculty1.ListStudents();

            /* Enrolling students to a course*/
            course1.EnrollStudentToCourse(student1);
            course1.EnrollStudentToCourse(student1);
            course1.EnrollStudentToCourse(student2);
            course1.ListCourseStudents();
            /*Najgolem fakultet*/
            university1.FindLargestFaculty();
            /*List type of students*/
            faculty1.ListTypeOfStudents();
        }
    }
}
