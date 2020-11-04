using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    static class TempConverter
    {


        public static double FahrenheittoCelcius(double temp)
        {
            double f = 32;
            double c = 32;

            double answer = f - c * 5 / 9;
            Console.WriteLine($"{temp} degrees celsius is equal to {answer} degrees Fahrenheit");

            return answer;


        }



        public static double CelciustoFahrenheit(double temp)
        {
            double f = 32;
            double c = 0;

            double answer = c * 9 / 5 + 32;
            Console.WriteLine($"{temp} degrees celsius is equal to {answer} degrees Fahrenheit");
            
            return answer;
        }
    }
}
