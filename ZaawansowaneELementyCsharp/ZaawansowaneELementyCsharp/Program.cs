using System;
using System.Collections.Generic;
namespace ZaawansowaneELementyCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IndexerMethod indexerMethod = new IndexerMethod();
            indexerMethod[0] = new Person();
            indexerMethod[1] = new Person();
            indexerMethod[0].age = 31;
            indexerMethod[0].name = "Adam";
            indexerMethod[1].age = 21;
            indexerMethod[1].name = "Marek";
            List<Person> person = new List<Person>();
            person.Add(new Person());
            person.Add(new Person());
            person[0].name = "Adam Generic";
            person[0].age = 24;
            person[1].name = "Marek Generic";
            person[1].age = 34;
            foreach (Person item in indexerMethod)
            {
                Console.WriteLine(item.age+" "+item.name);
            }
            Console.WriteLine("\nNew person list \n");
            foreach (Person item in person)
            {
                Console.WriteLine(item.age + " " + item.name);
            }
            DictionaryIndexedMethod dictionaryIndexedMethod = new DictionaryIndexedMethod();
            dictionaryIndexedMethod["Adam"] = new Person();
            dictionaryIndexedMethod["Marek"] = new Person();
            dictionaryIndexedMethod["Adam"].age = 24;
            dictionaryIndexedMethod["Adam"].name = "Adam";
            dictionaryIndexedMethod["Marek"].age = 34;
            dictionaryIndexedMethod["Marek"].name = "Marek";
            indexerMethod["Ewa"] = new Person();
            indexerMethod["Ewa"].age=19;
            indexerMethod["Ewa"].name="Ewa";
            IndexerMultidimensionalArray indexer = new IndexerMultidimensionalArray();
            indexer[1, 1] = 33;
            indexer[1, 2] = 34;
            indexer[1, 3] = 35;
            Console.WriteLine($"Add two person Adam 24 and Marek 34 result = {(dictionaryIndexedMethod["Adam"]+ dictionaryIndexedMethod["Marek"]).name } {(dictionaryIndexedMethod["Adam"] + dictionaryIndexedMethod["Marek"]).age}. ");

            Console.WriteLine( indexerMethod[0] == indexerMethod[0]);

            Console.WriteLine("Change type with rectangle to square");
            Console.WriteLine("Fun with Conversions");
            Console.WriteLine("Rectangle");
            Rectangle rectangle = new Rectangle(5,8);
            Console.WriteLine(rectangle.ToString());
            rectangle.Draw();
            Console.WriteLine("\nSquare made with rectangle height");
            Square square = (Square)rectangle;
            Console.WriteLine(square.ToString());
            square.Draw();
            Console.WriteLine("Conversions Square to Int and Int to Square ");
            int number = (int)square;
            Square square1 = (Square)number;
            Console.WriteLine($"Square tu number = {number}");
            Console.WriteLine($"Number to square {square1.ToString()}");
            int number2 = 123456789;
            Console.WriteLine("number two ={0}",number2);
            number2 = number2.ReverseDigits();
            Console.WriteLine("number two ={0}",number2);
            List<int> listOfNumber = new List<int>() {1,2,1,4,1,55,6423,3 };
            listOfNumber.PrintDataAndBeep();
            var myPerson = new { Name = "adam", age = 12 };
            Console.WriteLine(myPerson.ToString());
            var myCar = new { Mark = "mercedes", HorsePower = 122 };
            Console.WriteLine(myCar.ToString());

        }
    }
}
