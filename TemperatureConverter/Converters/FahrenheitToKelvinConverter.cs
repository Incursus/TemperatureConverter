namespace TemperatureConverter;

public class FahrenheitToKelvinConverter : ITemperatureConverter
{
    public string FromCode => "F";
    
    public string ToCode => "K";
    
    public decimal Convert(decimal value)
    {
        return Math.Round(273.5M + (value - 32.0M) * (5.0M / 9.0M), 2);
    }
}
