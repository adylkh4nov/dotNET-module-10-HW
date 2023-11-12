// В сборке StudentLibrary
using System;

namespace StudentLibrary
{
    public class Student : PersonLibrary.Person
    {
        public int StudentId { get; set; }
        public int CurrentCourse { get; set; } // Добавлено свойство CurrentCourse

        public virtual void Print()
        {
            Console.WriteLine($"Студент: {Name}, Возраст: {Age}, StudentId: {StudentId}, Текущий курс: {CurrentCourse}");
        }

        public override string ToString()
        {
            return $"Студент: {Name}, Возраст: {Age}, StudentId: {StudentId}, Текущий курс: {CurrentCourse}";
        }

        

        // Метод для перемещения студента на следующий курс
        public void MoveToNextCourse()
        {
            CurrentCourse++;
        }
    }
}
