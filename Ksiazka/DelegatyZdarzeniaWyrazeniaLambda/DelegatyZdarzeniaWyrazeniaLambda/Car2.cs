using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatyZdarzeniaWyrazeniaLambda
{
    class Car2 : Car
    {
        public Car2()
        {
        }

        public Car2(string Carname, int MaxSpeed, int CurrentSpeed) : base(Carname, MaxSpeed, CurrentSpeed)
        {
        }
        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow;

        public new void Accelerate(int delta)
        {
            if (CarIsDead && Exploded != null)
            {
                Exploded(this,new CarEventArgs("Sorry, this car is dead"));
                return;
            }
            CurrentSpeed += delta;
            /* if (20 >= (MaxSpeed - CurrentSpeed) && AboutToBlow != null)
               AboutToBlow("Careful buddy! Gonna blow!");
            */
            if (20 >= (MaxSpeed - CurrentSpeed))
                AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!"));

            if (CurrentSpeed >= MaxSpeed)
                CarIsDead = true;
            else
                Console.WriteLine("Current Speed = {0}", CurrentSpeed);


        }
    }
}
