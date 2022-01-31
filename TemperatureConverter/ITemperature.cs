namespace TemperatureConverter;

public interface ITemperature
{
    public double ConvertToCelsius(double temperatureValue);
    public double ConvertToKelvin(double value);
    public double ConvertToFahrenheit(double value);
}
