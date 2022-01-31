namespace TemperatureConverter;

public class Kelvin : ITemperature
{
    public string Code => "K";
    public decimal ConvertToCelsius(decimal value)
    {
        return value - 273.15M;
    }

    public decimal ConvertToKelvin(decimal value)
    {
        return value;
    }

    public decimal ConvertToFahrenheit(decimal value)
    {
        return (value - 273.15M) * 1.8M + 32;
    }
}
