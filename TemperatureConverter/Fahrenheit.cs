using System;

namespace TemperatureConverter;

public class Fahrenheit : ITemperature
{
    public string Code => "F";

    public decimal ConvertToCelsius(decimal value)
    {
        return Convert.ToDecimal(((value - 32) * 5 / 9).ToString("0.00"));
    }

    public decimal ConvertToKelvin(decimal value)
    {
        return Convert.ToDecimal((273.5M + (value - 32.0M) * (5.0M / 9.0M)).ToString("0.00"));
    }

    public decimal ConvertToFahrenheit(decimal value)
    {
        return Convert.ToDecimal(value.ToString("0.00"));
    }
}
