namespace TemperatureConverter;

public class Fahrenheit : ITemperature
{
    public double ConvertToCelsius(double temperatureValue)
    {
        return (temperatureValue - 32) * 5 / 9;
    }

    public double ConvertToKelvin(double value)
    {
        throw new NotImplementedException();
    }

    public double ConvertToFahrenheit(double value)
    {
        throw new NotImplementedException();
    }
}
