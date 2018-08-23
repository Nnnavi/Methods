using System;

namespace _5_TemperatureConversion
{
    class Program
    {
        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static void Main(string[] args)
        {
            var fahrenheit = double.Parse(Console.ReadLine());
            var celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("{0:F2}", celsius);
        }
    }
}
