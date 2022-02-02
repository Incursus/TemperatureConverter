namespace TemperatureConverter;

public interface ITemperatureConverter
{
    public string FromCode { get; }
    public string ToCode { get; }
    public decimal Convert(decimal value);
}
