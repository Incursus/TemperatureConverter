namespace TemperatureConverter;

public class CelsiusToFahrenheitConverter : ITemperatureConverter
{
    public string FromCode => "C";
    
    public string ToCode => "F";
    public decimal Convert(decimal value)
    {
        return Math.Round(value * 9 / 5 + 32, 2);
    }
}
