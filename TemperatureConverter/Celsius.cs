using System;

namespace TemperatureConverter;

public class Celsius : ITemperature
{
    public string Code => "C";

    public decimal ConvertToCelsius(decimal value)
    {
        return Convert.ToDecimal(value.ToString("0.00"));
    }

    public decimal ConvertToKelvin(decimal value)
    {
        return Convert.ToDecimal((value + 273.15M).ToString("0.00"));
    }

    public decimal ConvertToFahrenheit(decimal value)
    {
        return Convert.ToDecimal((value * 9 / 5 + 32).ToString("0.00"));
    }
}
