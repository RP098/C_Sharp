using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatyZdarzeniaWyrazeniaLambda
{
    class Event_in_Csharp:Car
    {
        public Event_in_Csharp()
        {
        }

        public Event_in_Csharp(string Carname, int MaxSpeed, int CurrentSpeed) : base(Carname, MaxSpeed, CurrentSpeed)
        {
        }

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
     
        public new void Accelerate(int delta)
        {
            if (CarIsDead && Exploded!=null)
            {
                Exploded("Sorry, this car is dead");
                return;
            }
            CurrentSpeed += delta;
            /* if (20 >= (MaxSpeed - CurrentSpeed) && AboutToBlow != null)
               AboutToBlow("Careful buddy! Gonna blow!");
            */
            if (20 >= (MaxSpeed - CurrentSpeed))
                AboutToBlow?.Invoke("Careful buddy! Gonna blow!");
            
            if (CurrentSpeed >= MaxSpeed)
                CarIsDead = true;
            else
                Console.WriteLine("Current Speed = {0}", CurrentSpeed);


        }
    }
}
