using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy
{
    class Diesel:Engine,IHeating,IComparer
    {
        public List<glow_plugs> glow_Plugs { get; set; }
        public double capacity { get; set; }
        public int numbersOfcylinders { get; set; }
        public Diesel():this(1,1,10)
        {

        }
        public Diesel(int power_hp, int torque, double efficiency) : base(power_hp, torque, efficiency)
        {

        }

        public Diesel(int power_hp, int torque, double efficiency,double capacity,int numbersOfcylinders)
        {
            this.power_hp = power_hp;
            this.torque = torque;
            this.efficiency = efficiency;
            this.capacity = capacity;
            this.numbersOfcylinders = numbersOfcylinders;
        }

        public override bool Switch_OFF()
        {
            engine_on_of = engine_on_of == true ? false : engine_on_of;
            return engine_on_of;
        }

        public override bool Switch_ON()
        {
            engine_on_of = engine_on_of == true ? engine_on_of : false;
            return engine_on_of;
        }

        public float IncreaseTemperature(float Increase_by_value =1,float temperature=2, float Max_temperature=3)
        {
            Exception exception = new Exception("Glow plugs has achieved max temperature"); 
            temperature = (temperature + Increase_by_value) >= Max_temperature ? throw exception : temperature + Increase_by_value;
            return temperature;
        }

        public float DecreaseTemperature(float Decrease_by_value, float temperature, float Min_temperature)
        {
            throw new NotImplementedException();
        }

        public override int CompareTo(object obj)
        {
            Exception exception = new Exception();
            Diesel diesel = obj as Diesel;
            if (diesel == null)
                throw exception;
            if (diesel.power_hp > this.power_hp)
                return 1;
            else if (diesel.power_hp < this.power_hp)
                return -1;
            else
                return 0;
        }

        public int Compare(object x, object y)
        {
            return ((new CaseInsensitiveComparer()).Compare(y, x));
        }
    }
}
