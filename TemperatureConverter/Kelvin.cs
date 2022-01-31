using System;

namespace TemperatureConverter;

public class Kelvin : ITemperature
{
    public string Code => "K";
    public decimal ConvertToCelsius(decimal value)
    {
        return Convert.ToDecimal((value - 273.15M).ToString("0.00"));
    }

    public decimal ConvertToKelvin(decimal value)
    {
        return Convert.ToDecimal(value.ToString("0.00"));
    }

    public decimal ConvertToFahrenheit(decimal value)
    {
        return Convert.ToDecimal(((value - 273.15M) * 1.8M + 32).ToString("0.00"));
    }
}
