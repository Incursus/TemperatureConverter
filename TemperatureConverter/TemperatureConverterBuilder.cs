namespace TemperatureConverter;

public class TemperatureConverterBuilder
{
    public List<ITemperatureConverter?> GetAll()
    {
        var type = typeof(ITemperatureConverter);
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => type.IsAssignableFrom(p) && p.IsClass);
        List<ITemperatureConverter?> converters = types.Select(Activator.CreateInstance).OfType<ITemperatureConverter>().ToList();

        return converters;
    }
}
