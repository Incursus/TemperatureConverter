using TemperatureConverter;

var converterBuilder = new TemperatureConverterBuilder();
var converters = converterBuilder.GetAll();

Console.WriteLine($"Hello, please enter your FROM temperature type: {string.Join(",", converters.Select(x => x.FromCode).ToHashSet())}");
var inputTypeFrom = Console.ReadLine();

Console.WriteLine($"Enter your TO temperature type: {string.Join(",", converters.Select(x => x.FromCode).ToHashSet())}");
var inputTypeTo = Console.ReadLine();

var temperaturePrinter = new TemperatureConverterResolver();
var converter = temperaturePrinter.Get(converters, inputTypeFrom, inputTypeTo);

if (converter != null)
{
    Console.WriteLine("Please enter value:");
    var userInputDecimal = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine($"{converter.FromCode} to {converter.ToCode} = {converter.Convert(userInputDecimal)}");
}
else
{
    Console.WriteLine("No temperature type found");
}
