using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConverter.Tests;

[TestClass]
public class FahrenheitTests
{
    private Fahrenheit fahrenheit;

    [TestInitialize]
    public void Initialize()
    {
        fahrenheit = new Fahrenheit();
    }
    
    [TestMethod]
    public void ConvertsTo_Kelvin()
    {
        var result = fahrenheit.ConvertToKelvin(451);

        result.Should().Be(506.27777777777777777777777780M);
    }
    
    [TestMethod]
    public void ConvertsTo_Fahrenheit()
    {
        var result = fahrenheit.ConvertToFahrenheit(451);

        result.Should().Be(451);
    }
    
    [TestMethod]
    public void ConvertsTo_Celsius()
    {
        var result = fahrenheit.ConvertToCelsius(451);

        result.Should().Be(232.77777777777777777777777778M);
    }
}
