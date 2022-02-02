namespace TemperatureConverter;

public class CelsiusToKelvinConverter : ITemperatureConverter
{
    public string FromCode => "C";
    
    public string ToCode => "K";
    
    public decimal Convert(decimal value)
    {
        return Math.Round(value + 273.15M, 2);
    }
}
