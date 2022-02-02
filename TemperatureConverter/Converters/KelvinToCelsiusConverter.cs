namespace TemperatureConverter;

public class KelvinToCelsiusConverter : ITemperatureConverter
{
    public string FromCode => "K";
    
    public string ToCode => "C";
    
    public decimal Convert(decimal value)
    {
        return Math.Round(value - 273.15M, 2);
    }
}
