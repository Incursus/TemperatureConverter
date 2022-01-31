namespace TemperatureConverter;

public class Fahrenheit : ITemperature
{
    public string Code => "F";

    public decimal ConvertToCelsius(decimal value)
    {
        return (value - 32) * 5 / 9;
    }

    public decimal ConvertToKelvin(decimal value)
    {
        return 273.5M + (value - 32.0M) * (5.0M / 9.0M);
    }

    public decimal ConvertToFahrenheit(decimal value)
    {
        return value;
    }
}
