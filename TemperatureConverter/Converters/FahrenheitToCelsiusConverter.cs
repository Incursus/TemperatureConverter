namespace TemperatureConverter;

public class FahrenheitToCelsiusConverter : ITemperatureConverter
{
    public string FromCode => "F";
    
    public string ToCode => "C";
    
    public decimal Convert(decimal value)
    {
        return Math.Round((value - 32) * 5 / 9, 2);
    }
}
