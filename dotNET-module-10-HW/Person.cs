using System;

namespace PersonLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Person otherPerson)
            {
                return this.Name == otherPerson.Name && this.Age == otherPerson.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (ReferenceEquals(person1, null))
                return ReferenceEquals(person2, null);

            return person1.Equals(person2);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}
