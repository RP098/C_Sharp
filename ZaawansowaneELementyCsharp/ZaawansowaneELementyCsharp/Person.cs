using System;
using System.Collections.Generic;
using System.Text;

namespace ZaawansowaneELementyCsharp
{
    class Person
    {
        public  string name;
        public int age;
        public static Person operator + (Person person, Person person1)
        {
            Person person2 = new Person();
            person2.age = person.age + person1.age;
            person2.name = person.name + person1.name;
            return person2;
        }
        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override string ToString()
        {
            return this.name + this.age;
        }
        public static bool operator ==(Person person, Person person1)
      {
            return person.Equals(person1);
       
        }
        public static bool operator !=(Person person, Person person1)
        {
            return !person.Equals(person1);

        }

    }
}
