using System;

namespace DelegatyZdarzeniaWyrazeniaLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Simply Delagete Example");
            BinaryOperation<int> binary = new BinaryOperation<int>(SimpleMath.Add);
            SimpleMath simple = new SimpleMath();
            Console.WriteLine("15 + 15 is {0}", binary(15,15));
            Program.DisplayDelegateInfo(binary);
            binary= new BinaryOperation<int>(simple.Multiplication);
            Program.DisplayDelegateInfo(binary);
            Console.WriteLine("15 * 15 is {0}", binary(15, 15));

            Car car = new Car("Mercedes-Benz", 250, 60); 
            car.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));
            car.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            car.UnRegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));
            //car.UnRegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            
            Action<string, ConsoleColor, int> action = new Action<string, ConsoleColor, int>(ActionAndFuncDelegate.DisplayMessage) ;
            action("Speeding Up",ConsoleColor.Red,1);
            
            for (int i = 0; i < 11; i++)
            {
                car.Accelerate(20);
                Console.WriteLine();
            }

            Func<int, int,int> func = new Func<int, int, int>(SimpleMath.Add);//the last <...element> is return value
            Console.WriteLine( func(20, 20));

            Func<int, int, int> func2 = SimpleMath.Add;
            Console.WriteLine(func2(10, 10));

            Event_in_Csharp event_In_ = new Event_in_Csharp("Opel", 180, 50);
            event_In_.AboutToBlow += new Car.CarEngineHandler(CarIsAlmostDoomed);
            event_In_.AboutToBlow += new Car.CarEngineHandler(CarAboutBlow);
            event_In_.Exploded += new Car.CarEngineHandler(CarExploded);
            Console.WriteLine("Car speeding Up");
            for (int i = 0; i < 10; i++)
            {
                event_In_.Accelerate(20);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Car2 car2 = new Car2("Opel", 180, 50);
            int aboutToBloow = 0;

            car2.AboutToBlow += delegate
             {
                 aboutToBloow++;
                 Console.WriteLine("Going too fast");
             };
            car2.AboutToBlow += delegate (object sender, CarEventArgs e)
             {
                 aboutToBloow++;
                 Console.WriteLine("Message from your car{0}",e.message);
             };
            car2.Exploded += delegate (object sender, CarEventArgs e) {

                Console.WriteLine($"{e.message}");
            };
            for (int i = 0; i < 10; i++)
            {
                car2.Accelerate(20);
            }
            Console.WriteLine($"About to blow was fired {aboutToBloow} times.");




        }


        public static void CarAboutBlow(string message)
        {
            Console.WriteLine($"{message}");
        }

        public static void CarIsAlmostDoomed(string message)
        {
            Console.WriteLine($"Critical message from your car {message}");
        }
        public static void CarExploded(string message)
        {
            Console.WriteLine($"{message}");
        }

        public static void OnCarEngineEvent(string message)
        {
            Console.WriteLine("\n Message From Car object");
            Console.WriteLine($"{message}");
            Console.WriteLine("**************************");
        }
        public static void OnCarEngineEvent2(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
       
        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (var item in delObj.GetInvocationList())
            {
                Console.WriteLine($"Method name {delObj.Method}");
                Console.WriteLine($"Type name {delObj.Target}");
            }
        }
    }
}
