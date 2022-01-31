using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConverter.Tests;

[TestClass]
public class KelvinTests
{
    private Kelvin kelvin;

    [TestInitialize]
    public void Initialize()
    {
        kelvin = new Kelvin();
    }
    
    [TestMethod]
    public void ConvertsTo_Kelvin()
    {
        var result = kelvin.ConvertToKelvin(100);

        result.Should().Be(100M);
    }
    
    [TestMethod]
    public void ConvertsTo_Fahrenheit()
    {
        var result = kelvin.ConvertToFahrenheit(100);

        result.Should().Be(-279.67M);
    }
    
    [TestMethod]
    public void ConvertsTo_Celsius()
    {
        var result = kelvin.ConvertToCelsius(100);

        result.Should().Be(-173.15M);
    }
}
