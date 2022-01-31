namespace TemperatureConverter;

public class Celsius : ITemperature
{
    public double ConvertToCelsius(double temperatureValue)
    {
        return temperatureValue;
    }

    public double ConvertToKelvin(double value)
    {
        return value + 273.15;
    }

    public double ConvertToFahrenheit(double value)
    {
        return value * 9 / 5 + 32;
    }
}
