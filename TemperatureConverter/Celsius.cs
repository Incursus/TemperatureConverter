namespace TemperatureConverter;

public class Celsius : ITemperature
{
    public string Code => "C";

    public decimal ConvertToCelsius(decimal value)
    {
        return value;
    }

    public decimal ConvertToKelvin(decimal value)
    {
        return value + 273.15M;
    }

    public decimal ConvertToFahrenheit(decimal value)
    {
        return value * 9 / 5 + 32;
    }
}
