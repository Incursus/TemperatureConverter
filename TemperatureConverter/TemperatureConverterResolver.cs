namespace TemperatureConverter;

public class TemperatureConverterResolver
{
    public ITemperatureConverter? Get(List<ITemperatureConverter?> list, string from, string to)
    {
        return list.FirstOrDefault(x => x.FromCode == from && x.ToCode == to);
    }
}
