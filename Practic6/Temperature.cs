using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic6
{
    public class Temperature
    {
        public double temp;

        public Temperature()
        {
            temp = default;
        }

        public Temperature(double temperature)
        {
            temp = temperature;
        }

        public virtual double ConvertTemp()
        {
            if (this.GetType() == typeof(Farenheit))
            {
                return (temp - 32) * 5 / 9;
            }
            else if (this.GetType() == typeof(Celsius))
            {
                return (temp * 9 / 5) + 32;
            }
            else
            {
                return temp;
            }
        }
    }
}
