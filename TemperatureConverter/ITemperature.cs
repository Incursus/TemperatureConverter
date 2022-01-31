namespace TemperatureConverter;

public interface ITemperature
{
    public string Code { get; }
    public decimal ConvertToCelsius(decimal value);
    public decimal ConvertToKelvin(decimal value);
    public decimal ConvertToFahrenheit(decimal value);
}
