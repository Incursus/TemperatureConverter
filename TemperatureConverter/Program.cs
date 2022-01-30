// See https://aka.ms/new-console-template for more information

// Greta - trys objektai - F, K, C pačioj klasėj keist informaciją.
// User input - [number][K, C, F], pagal tai sumatchina ir konvertuoja į kitas temperatūras
// Temperature class as base 

// Example Farenheit 451

Console.WriteLine("Hello, please enter your temperature in [number][temperature] format!");

var userInput = Console.ReadLine();

// Parse last character of userinput
var userInputTemperatureParsed = userInput.Substring(userInput.Length);