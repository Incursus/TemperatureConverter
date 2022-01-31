// See https://aka.ms/new-console-template for more information

// Greta - trys objektai - F, K, C pačioj klasėj keist informaciją.
// User input - [number][K, C, F], pagal tai sumatchina ir konvertuoja į kitas temperatūras
// Temperature class as base 

// Example Farenheit 451

using TemperatureConverter;

Console.WriteLine($"Hello, please enter your temperature type: K C or F");
var temperatureType = Console.ReadLine();

Console.WriteLine($"Please enter your temperature value");
double temperatureValue = Convert.ToDouble(Console.ReadLine());

var celsius = new Celsius();
Console.WriteLine($"C to F = {celsius.ConvertToFahrenheit(temperatureValue)}");
Console.WriteLine($"C to K = {celsius.ConvertToKelvin(temperatureValue)}");