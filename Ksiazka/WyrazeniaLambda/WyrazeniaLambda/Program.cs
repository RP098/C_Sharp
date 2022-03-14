using System;
using System.Collections.Generic;
namespace WyrazeniaLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Lambdas Expression");
            TraditionalDelegateSyntax();

        }
        public delegate void MathMessage(string message, int resutl);
        MathMessage message1;
        public void SetMathHandler(MathMessage target)
        {
            message1 = target;
        }

        static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 3, 7, 9, 20, 10, 4, 6, 2, 8 });
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);
            Console.WriteLine();
            foreach (var item in evenNumbers)
            {
                Console.WriteLine($"{item} \t");
            }

            List<int> newEvenNumber = list.FindAll(delegate (int i) { return (i % 2 == 0); });
            Console.WriteLine("Here are you even numbers:");

            foreach (var item in newEvenNumber)
            {
                Console.WriteLine($"{item} \t");
            }
            List<int> NextEvenNumber = list.FindAll(i => (i % 2 == 0));
            Console.WriteLine("Here are you even numbers:");

            foreach (var item in newEvenNumber)
            {
                Console.WriteLine($"{item} \t");
            }
            Console.WriteLine("Your number");
            List<int> NextNewEvenNumber = list.FindAll((i) =>
            {
                bool isEven = ((i % 2) == 0);
                string napis = String.Format($"{(i % 2 == 0 ? i : 1)}");
                Console.Write((napis == "1") ? "\0" : napis + " ");
                return isEven;
            });
            Program program = new Program();
            Console.WriteLine("\n\n");
            program.SetMathHandler((msg, i) => {
                Console.WriteLine("Message:{0}, Result {1}",msg, i ) ; });
           
            program.ADD(1, 2);


            Console.WriteLine();
        }
        void ADD(int x, int y)
        {
            message1?.Invoke("\nAdding your element", x + y);
        }
        void Multiplications(int x, int y) => Console.WriteLine(   x * y);
        void Dividing(int x, int y) => Console.WriteLine(   x / y);
        static bool IsEvenNumber(int i)
        {
            return i % 2 == 0;
        }
    }
}
