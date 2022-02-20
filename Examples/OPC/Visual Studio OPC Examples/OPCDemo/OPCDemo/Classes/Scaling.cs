using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tuc.LabWork
{
    public class Scaling
    {

        public double CelciusToFahrenheit(double tempCelcius)
        {

            double tempFahrenheit;

            tempFahrenheit = (9 / 5) * tempCelcius + 32;

            return tempFahrenheit;

        }


        public double FahrenheitToCelcius(double tempFahrenheit)
        {

            double tempCelcius;

            tempCelcius = (5 / 9) * (tempFahrenheit -32);

            return tempCelcius;

        }

    }
}
