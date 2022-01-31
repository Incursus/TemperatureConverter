using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConverter.Tests;

[TestClass]
public class CelsiusTests
{
    private Celsius celsius;

    [TestInitialize]
    public void Initialize()
    {
        celsius = new Celsius();
    }
    
    [TestMethod]
    public void ConvertsTo_Kelvin()
    {
        var result = celsius.ConvertToKelvin(100);

        result.Should().Be(373.15M);
    }
    
    [TestMethod]
    public void ConvertsTo_Fahrenheit()
    {
        var result = celsius.ConvertToFahrenheit(100);

        result.Should().Be(212M);
    }
    
    [TestMethod]
    public void ConvertsTo_Celsius()
    {
        var result = celsius.ConvertToCelsius(100);

        result.Should().Be(100);
    }
}
