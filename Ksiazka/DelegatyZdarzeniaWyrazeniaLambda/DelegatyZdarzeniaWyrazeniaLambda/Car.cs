using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatyZdarzeniaWyrazeniaLambda
{
    class Car
    {

        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string CarName { get; set; }
        protected bool CarIsDead;
        public Car()
        {

        }
        public Car(string Carname,int MaxSpeed,int CurrentSpeed)
        {
            this.CurrentSpeed = CurrentSpeed;
            this.MaxSpeed = MaxSpeed;
            this.CarName = CarName;
        }
        public delegate void CarEngineHandler(string messageForCaller);
        protected CarEngineHandler ListOfHandler;
        /*  public void RegisterWithCarEngine(CarEngineHandler methodToCall)
          {
              this.ListOfHandler = methodToCall;
          }
        */

        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            this.ListOfHandler += methodToCall; //multicast
           
        }
        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            this.ListOfHandler -= methodToCall;
        }
        public  void Accelerate(int delta)
        {
            if(CarIsDead && ListOfHandler!=null)
            {
                ListOfHandler("Sorry, your car is dead...");
                return;
            }
            CurrentSpeed += delta;
            if(20>=(MaxSpeed-CurrentSpeed)&&ListOfHandler!=null)
            {
                ListOfHandler("Careful buddy! Gonna blow!");

            }
            if (CurrentSpeed >= MaxSpeed)
                CarIsDead = true;
            else
                Console.WriteLine("Current Speed = {0}",CurrentSpeed);
        }

    }
}
