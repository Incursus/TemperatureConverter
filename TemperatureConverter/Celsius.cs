namespace TemperatureConverter;

public class Celsius : ITemperature
{
    public string Code => "C";

    public decimal ConvertToCelsius(decimal value)
    {
        return Math.Round(value, 2);
    }

    public decimal ConvertToKelvin(decimal value)
    {
        return Math.Round(value + 273.15M, 2);
    }

    public decimal ConvertToFahrenheit(decimal value)
    {
        return Math.Round(value * 9 / 5 + 32, 2);
    }
}
