using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value to be converted");
            Console.WriteLine("1. Convert Celsius To Fahrenheit: Press C");
                Console.WriteLine("2. Convert Fahrenheit To Celsius: Press F");
                Console.WriteLine("3. Convert Celsius To Kelvin: Press K");
                Console.WriteLine("4. Convert Kelvin To Celcius: Press H");
                Console.WriteLine("5. Convert Fahrenheit To Kelvin: Press J");
                Console.WriteLine("6. Convert Kelvin To Fahrenheit: Press L");
                Console.WriteLine("7. For Exit from progarm: Press E");
            
           string selection = string.Empty;
            Conversion conversion;
            while (selection != "E" && selection != "e")
            {
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Please provide celsius temp:");
                        int celsiusValue = Convert.ToInt32(Console.ReadLine());
                        conversion = new Conversion(celsiusValue);
                        double fahrenheitResult = conversion.CelsiusToFahrenheit();
                        Console.WriteLine($"fahrenheit temperature: {fahrenheitResult}°F");
                        break;
                    case "F":
                    case "f":
                        Console.Write("Please provide fahrenheit temp:");
                        int fahrenheitValue = Convert.ToInt32(Console.ReadLine());
                        conversion = new Conversion(fahrenheitValue);
                        double celsiusResult = conversion.FahrenheitToCelsius();
                        Console.WriteLine($"celsius temperature: {celsiusResult}°C");
                        break;
                    case "K":
                    case "k":
                        Console.Write("Please provide celsius temp:");
                        celsiusValue = Convert.ToInt32(Console.ReadLine());
                        conversion = new Conversion(celsiusValue);
                        double kelvinResult = conversion.CelsiusToKelvin();
                        Console.WriteLine($"kelvin temperature: {kelvinResult}°K");
                        break;


                    case "H":
                    case "h":
                        Console.Write("Please provide kelvin temp:");
                        int kelvinValue = Convert.ToInt32(Console.ReadLine());
                        conversion = new Conversion(kelvinValue);
                        double result = conversion.KelvinToCelsius();
                        Console.WriteLine($"Celsius temperature: {result}°C");
                        break;
                    case "J":
                    case "j":
                        Console.Write("Please provide fahrenheit temp:");
                        fahrenheitValue = Convert.ToInt32(Console.ReadLine());
                        conversion = new Conversion(fahrenheitValue);
                        result = conversion.FahrenheitToKelvin();
                        Console.WriteLine($"kelvin temperature: {result}°K");
                        break;
                    case "L":
                    case "l":
                        Console.Write("Please provide kelvin temp:");
                        kelvinValue = Convert.ToInt32(Console.ReadLine());
                        conversion = new Conversion(kelvinValue);
                        result = conversion.KelvinToFahrenheit();
                        Console.WriteLine($"fahrenheit temperature: {result}°F");
                        break;


                    default:
                        Console.WriteLine($"{selection}");
                        Console.WriteLine("Please enter the value again");
                        break;

                }
            }
        }
    }
}
