using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06TaskWeather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherManager weatherManager = new WeatherManager();

            Console.WriteLine("Provide City Name: ");
            var cityEntered = Console.ReadLine();

            Console.WriteLine("Choose temperature unit - Type: 1 for Celsius, 2 for Fahrenheit, 3 for Kelvin and hit ENTER");
            var op = Console.ReadLine();
            string tempEntered = "Celsius";

            if (op.Equals("1"))
            {
                tempEntered = "Celsius";
            }
            if (op.Equals("2"))
            {
                tempEntered = "Fahrenheit";
            }
            if (op.Equals("3"))
            {
                tempEntered = "Kelvin";
            }

            double temp = weatherManager.GetTemperature(cityEntered, tempEntered);
            Console.WriteLine("Current temperature for " + cityEntered + " is " + temp + "*" + tempEntered);
            Console.ReadKey();
        }
    }
}
