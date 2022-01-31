using System;
using System.Linq;
using TemperatureConverter;

var type = typeof(ITemperature);
var types = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes())
    .Where(p => type.IsAssignableFrom(p) && p.IsClass);
var temperatures = types.Select(Activator.CreateInstance).OfType<ITemperature>().ToList();

Console.WriteLine($"Hello, please enter your temperature type: {string.Join(",", temperatures.Select(x => x.Code))}");
var inputType = Console.ReadLine();

var foundTemperature = temperatures.FirstOrDefault(x => x.Code == inputType);

if (foundTemperature != null)
{
    Console.WriteLine("Please enter value:");
    var userInputDecimal = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine($"{foundTemperature.Code} to C = {foundTemperature.ConvertToCelsius(userInputDecimal)}");
    Console.WriteLine($"{foundTemperature.Code} to K = {foundTemperature.ConvertToKelvin(userInputDecimal)}");
    Console.WriteLine($"{foundTemperature.Code} to F = {foundTemperature.ConvertToFahrenheit(userInputDecimal)}");
}
else
{
    Console.WriteLine("No temperature type found");
}
