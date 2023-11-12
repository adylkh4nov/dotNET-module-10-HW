using System;
using System.Collections.Generic;

namespace TeacherLibrary
{
    public class Teacher : PersonLibrary.Person
    {
        public List<StudentLibrary.Student> Students { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Препод: {Name}, Возраст: {Age}");
            Console.WriteLine("Студенты:");
            foreach (var student in Students)
            {
                student.Print();
            }
        }

        public override string ToString()
        {
            return $"Препод: {Name}, Возраст: {Age}";
        }
    }
}
