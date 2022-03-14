using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy
{
    interface IHeating
    {
        float IncreaseTemperature(float Increase_by_value,float temperature ,float Max_temperature);
        float DecreaseTemperature(float Decrease_by_value, float temperature, float Min_temperature);
    }
}