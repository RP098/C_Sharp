using System;
using System.Collections;
using System.Collections.Generic;
namespace Interfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Diesel diesel = new Diesel();
            glow_plugs glow_Plugs = new glow_plugs(1,1000,"Bosch");
            glow_plugs glow_Plugs1 = new glow_plugs(1, 1230, "Mayle");
            glow_plugs glow_Plugs2 = new glow_plugs(1, 1133, "Maxger");
            glow_plugs glow_Plugs3 = new glow_plugs(1, 1230, "Delphi");
            glow_plugs glow_Plugs4 = new glow_plugs(1, 1030, "TRW");
            diesel.glow_Plugs= new List<glow_plugs>();
            diesel.glow_Plugs.Add(glow_Plugs);
            diesel.glow_Plugs.Add(glow_Plugs1);
            diesel.glow_Plugs.Add(glow_Plugs2);
            diesel.glow_Plugs.Add(glow_Plugs3);
            diesel.glow_Plugs.Add(glow_Plugs4);
            IHeating heating = diesel as IHeating;
            if(heating==null)
                Console.WriteLine("diesel is not Iheating");
            else
                Console.WriteLine("diesel is Iheating");

            Shapes shapes5 = new Shapes();
            try
            {
               
                for (int i = 0; i < 10; i++)
                {
                    glow_Plugs.temperature = diesel.IncreaseTemperature(100, glow_Plugs.temperature, glow_Plugs.Max_temperature);
                    Console.WriteLine($"Temperatura świec żarowych {glow_Plugs.temperature}");
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ISquare square = new Shapes();
            Console.WriteLine("I 'm square");
            square.draw();
            ICircle circle = new Shapes();
            Console.WriteLine("\nI 'm circle");
            circle.draw();
            Shapes shapes = new Shapes();
            Console.WriteLine("\nI 'm shape??");
            shapes.draw();

            Shapes shapes1 = new Shapes();
            shapes1.name = "Shapes1";
            Console.WriteLine("\nI 'm shape??");
            ((ICircle)shapes1).draw();
            ((ISquare)shapes1).draw();

            Shapes shapes2 = new Shapes();
            foreach (Shapes shapes3 in shapes2)
            {
                Console.WriteLine("Your shapes {0}",shapes3.name);
            }

            Program program = new Program();
            foreach (Shapes item in program.Funkcja())
            {
                Console.WriteLine(item.name);
            }
            shapes1.shapes[0].name = "Shape11";
            Shapes shapes4= (Shapes)shapes1.Clone();
            Console.WriteLine(shapes4.name);
            shapes4.shapes[0].name = "Shapes44";
            Console.WriteLine("Shapes44 = {0} \n Shapes1 = {1}",shapes4.shapes[0].name,shapes1.shapes[0].name);
            shapes4.name = "Shapes44";
            Console.WriteLine("Shapes44 = {0} \n Shapes1 = {1}", shapes4.name, shapes1.name);
            try
            {
                Console.WriteLine(diesel.CompareTo(diesel));
             
            
               

            }
            catch(Exception e)
            {
                Console.WriteLine("Exception !! {0}",e.Message);
            }
            Console.ReadKey();

        }
        IEnumerable Funkcja()
        {
            Shapes shapes2 = new Shapes();
            foreach (Shapes shapes3 in shapes2.shapes)
            {
                yield return shapes3;
            }

        }

    }
}
