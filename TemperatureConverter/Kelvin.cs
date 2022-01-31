namespace TemperatureConverter;

public class Kelvin : ITemperature
{
    public string Code => "K";
    public decimal ConvertToCelsius(decimal value)
    {
        return Math.Round(value - 273.15M, 2);
    }

    public decimal ConvertToKelvin(decimal value)
    {
        return Math.Round(value, 2);
    }

    public decimal ConvertToFahrenheit(decimal value)
    {
        return Math.Round((value - 273.15M) * 1.8M + 32, 2);
    }
}
