using System;
using System.Collections.Generic;
using System.Threading;
using System.Collections.ObjectModel;
namespace Kolecje_I_typy_generyczne
{
    class Program
    {
        List<Engine> engines = new List<Engine>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("How many Engines you can create ??");
          
            int numbersOfEngines = Convert.ToInt32(Console.ReadLine().Trim());
            Program program = new Program();
            program.CreateEngine(numbersOfEngines);
            foreach (var item in program.engines)
            {
                Console.WriteLine(item.ToString());
            }
            Stack<Engine> StackEngine = new Stack<Engine>(); //Last in First OUT 
            foreach (var item in program.engines)
            {
                StackEngine.Push(item);
            }
            Console.WriteLine("\n Engines in Stack \n");
            while (StackEngine.Count>0)
            {
                Console.WriteLine(StackEngine.Pop().ToString());
            }
            SortedSet<Engine> enginesSet = new SortedSet<Engine>(new Engine());
            foreach (var item in program.engines)
            {
                enginesSet.Add(item);
            }
            Console.WriteLine("\n Sorted descending Engines by Power HP  \n");
            foreach (var item in enginesSet.Reverse())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n");
            ObservableCollection<Engine> enginesObserwable= new ObservableCollection<Engine>();

            foreach (var item in program.engines)
            {
                enginesObserwable.Add(item);
            }
            enginesObserwable.CollectionChanged += EnginesObserwable_CollectionChanged; ;

            enginesObserwable.Remove(program.engines[1]);
            foreach (var item in enginesObserwable)
            {
                Console.WriteLine(item.ToString());
            }
            enginesObserwable.Add(new Engine());
            foreach (var item in enginesObserwable)
            {
                Console.WriteLine(item.ToString());
            }
            enginesObserwable.Move(2, 3);
            foreach (var item in enginesObserwable)
            {
                Console.WriteLine(item.ToString());
            }
            int args0 = 3;
            int args1 = 4;
            program.Swap<int>(ref args0, ref args1);

            Console.WriteLine("\n");
            GenericClass<int> genericClass = new GenericClass<int>();
            Console.WriteLine(genericClass.xPos + " " + genericClass.yPos);
        }
       private void Swap<T>(ref T objectA, ref T objectB ) where T: struct //must be System.ValueType 
           // where T: class  // not be use with System.ValueType must be reference 
        {
            T temp = objectA;
            objectA = objectB;
            objectB = temp;
        } 
        private static void EnginesObserwable_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    Console.WriteLine($"Add new item this is new item {item.ToString()}");
                }
                 
            }

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                foreach (var item in e.OldItems)
                {
                    Console.WriteLine($"Remove item this is Old item {item.ToString()}");
                }
                
            }

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
            {
                foreach (var item in e.OldItems)
                {
                    Console.WriteLine($"Reset item this is Old item {item.ToString()}");
                }

            }
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Move)
            {
                foreach (var item in e.OldItems)
                {
                    Console.WriteLine($"This item is moved {item.ToString()}");
                }
              
            }


       

        }

        List <Engine> CreateEngine(int numbers_Engines) 
        {
            for (int i = 0; i < numbers_Engines; i++)
            {
                this.engines.Add(new Engine());
                Thread.Sleep(100);
            }

            return engines;
        }


    }
}
