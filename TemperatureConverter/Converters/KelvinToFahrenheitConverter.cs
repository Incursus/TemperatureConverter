namespace TemperatureConverter;

public class KelvinToFahrenheitConverter : ITemperatureConverter
{
    public string FromCode => "K";
    
    public string ToCode => "F";
    
    public decimal Convert(decimal value)
    {
        return Math.Round((value - 273.15M) * 1.8M + 32, 2);
    }
}
