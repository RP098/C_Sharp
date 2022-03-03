using System;
using static System.DateTime;
namespace Hermetyzacja
{
   public class Car
    {

        public static int year_of_production;
        private string carName;
        private int carSpeed;
        private int meter_status;
        private string carVin=CarVin();
        public readonly int numberWheels=4;
        static Random random = new Random();
        public static int numberOfCarProduced { get; set; }
        static Car()
        {
            year_of_production = Now.Year;
            Console.WriteLine("\nStatic car constructor");
        }
        public Car() //ctor 2x Tab
        {
            SpeedCar = 0;
            Name = "Pojazd";
        }
        public Car(string carName):this(carName,0)
        {
      
        }
        public Car(string carName,int carSpeed):this(carName,carSpeed,0)
        {
      
        }
        public Car(string carName,int carSpeed, int meter_status)
        {
            Name = carName;
            SpeedCar = carSpeed;
            mileage=meter_status;
        }

        public static string CarVin()
        {
            
            
            return "v"+ Now.Year + Now.Month + Now.Day+Now.Hour+Now.Minute+Now.Second +12+random.Next(10,99);
        }

       /* public void SetcarName(string carName)
        {
            if (carName.Length < 20)
                this.carName = carName;
            else
                Console.WriteLine("Car name is too long");

        }
        public void SetcarSpeed(int carSpeed)
        {
            this.carSpeed = carSpeed;
        }
        public string GetcarName()
        {
            return carName;
        }
        public int GetcarSpeed()
        {
            return carSpeed;
        }*/

        public string Name
        {
            get { return carName; }
            set
            {
                if (value.Length < 20)
                    this.carName = value;
                else
                    Console.WriteLine("Car name is too long");
            }

        }
        public int mileage{
            get { return meter_status; }

            set
            {
                meter_status = value;
            }

        }
        public int SpeedCar
        {
            get { return carSpeed; }

            set
            {
                if(value<250)
                    carSpeed = value;
                else
                    Console.WriteLine($"Speed equal = {value} is too big for your car");
            }
                
        }

        public string Vin
        {
            get { return carVin; }
        }



    }
}
