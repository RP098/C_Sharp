using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SymulatorKaczek;
namespace Strategia
{
    class Program
    {
        List<object> konkretnaKaczkas = new List<object>() {new KaczkaDrewniana(),new KaczkaGumowa(),new KaczkaPlywajaca() };
        static void Main(string[] args)
        {
            Maluch maluch = new Maluch();
            Ford ford = new Ford();
            Porsche porsche = new Porsche();
            Car car = new Car();
            IStrategyCar strategyCar = porsche;
            Console.WriteLine("Maluch max speed {0}", car.MaxSpeed(maluch));
            Console.WriteLine("Ford max speed {0}", car.MaxSpeed(ford));
            Console.WriteLine("Porsche max speed {0}", car.MaxSpeed(porsche));
           
            Car.SpeedDelegate speed = new Car.SpeedDelegate(car.MaxSpeed);
            Console.WriteLine("Ford max speed {0}",speed(new Ford())); 
            speed = new Car.SpeedDelegate(car.MinSpeed);
            Console.WriteLine("Maluch min speed {0}", speed(new Maluch()));

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Symulator kaczek :)");

            Kwakanie kwakanie = new Kwakanie(new Kaczka().Kwakanie);
            Program program = new Program();
            foreach (IKonkretnaKaczkaGadajaca item in from kaczka in  program.konkretnaKaczkas where kaczka is IKonkretnaKaczkaGadajaca select kaczka)
            {
                item.kwakanie();
            }

            Fruwanie fruwanie = new Fruwanie(new Kaczka().Latanie);
            foreach (IKaczkaKonkretnaLatajaca item in from kaczka in  program.konkretnaKaczkas where kaczka is IKaczkaKonkretnaLatajaca select kaczka)
            {
               item.fruwanie();
            }
            Console.ReadKey();


        }
    }
}
