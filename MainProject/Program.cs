using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        PersonLibrary.Person[] people = new PersonLibrary.Person[5];
        people[0] = new StudentLibrary.Student { Name = "Khabib", Age = 30,CurrentCourse = 1};
        people[1] = new StudentLibrary.Student { Name = "Lama", Age = 25, CurrentCourse = 2};
        people[2] = new StudentLibrary.Student { Name = "Bob", Age = 11, CurrentCourse = 1 };

        people[3] = new TeacherLibrary.Teacher { Name = "Messi", Age = 32, Students = new List<StudentLibrary.Student>() { (StudentLibrary.Student) people[0], (StudentLibrary.Student)people[1] } };
        people[4] = new TeacherLibrary.Teacher { Name = "Johny", Age = 22, Students = new List<StudentLibrary.Student>() { (StudentLibrary. Student)people[2], (StudentLibrary.Student)people[1] } };
       
        

        foreach (var person in people)
        {
            if (person is StudentLibrary.Student student)
            {
                student.Print();
                
            }
        }
        Console.WriteLine();
        foreach (var person in people)
        {
            if (person is TeacherLibrary.Teacher teacher)
            {
                teacher.Print();

            }
        }


        int personCount = 0, studentCount = 0, teacherCount = 0;

        foreach (var person in people)
        {
            if (person is PersonLibrary.Person)
                personCount++;
            if (person is StudentLibrary.Student)
                studentCount++;
            if (person is TeacherLibrary.Teacher)
                teacherCount++;

            if (person is StudentLibrary.Student student)
            {
                
                student.MoveToNextCourse(); 
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Колво людей: {personCount}");
        Console.WriteLine($"Студенты: {studentCount}");
        Console.WriteLine($"Учителей: {teacherCount}");
    }
}
