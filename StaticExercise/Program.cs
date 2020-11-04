using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Human! I am the Tempreture Conversion System or TCS.\n If you would like to convert Farenheit to Celsius, type in f,\n if you would wish to convert Celsius to farenheit, type in c.");
            string userinput = Console.ReadLine().ToLower();
            Console.WriteLine("And the value You would like to convert?");
            string value = Console.ReadLine();
            double convertedvalue = Double.Parse(value);

           if(userinput == "f")
            {
                 TempConverter.FahrenheittoCelcius(convertedvalue);
            }

           if(userinput == "c")
            {
                TempConverter.CelciustoFahrenheit(convertedvalue);
            }
        }
    }
}
