namespace TemperatureConverter;

public class Fahrenheit : ITemperature
{
    public string Code => "F";

    public decimal ConvertToCelsius(decimal value)
    {
        return Math.Round((value - 32) * 5 / 9, 2);
    }

    public decimal ConvertToKelvin(decimal value)
    {
        return Math.Round(273.5M + (value - 32.0M) * (5.0M / 9.0M), 2);
    }

    public decimal ConvertToFahrenheit(decimal value)
    {
        return Math.Round(value, 2);
    }
}
