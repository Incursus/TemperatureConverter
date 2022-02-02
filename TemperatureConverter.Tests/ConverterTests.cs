using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConverter.Tests;

[TestClass]
public class ConverterTests
{
    [TestMethod]
    public void ConvertsFromCelsiusToKelvin()
    {
        var converter = new CelsiusToKelvinConverter();

        var result = converter.Convert(100);
        
        result.Should().Be(373.15M);
    }
    
    [TestMethod]
    public void ConvertsFromCelsiusToFahrenheit()
    {
        var converter = new CelsiusToFahrenheitConverter();

        var result = converter.Convert(100);
        
        result.Should().Be(212M);
    }
    
    [TestMethod]
    public void ConvertsFromKelvinToCelsius()
    {
        var converter = new KelvinToCelsiusConverter();

        var result = converter.Convert(100);
        
        result.Should().Be(-173.15M);
    }
    
    [TestMethod]
    public void ConvertsFromKelvinToFahrenheit()
    {
        var converter = new KelvinToFahrenheitConverter();

        var result = converter.Convert(100);
        
        result.Should().Be(-279.67M);
    }
    
    [TestMethod]
    public void ConvertsFromFahrenheitToCelsius()
    {
        var converter = new FahrenheitToCelsiusConverter();

        var result = converter.Convert(451);
        
        result.Should().Be(232.78M);
    }
    
    [TestMethod]
    public void ConvertsFromFahrenheitToKelvin()
    {
        var converter = new FahrenheitToKelvinConverter();

        var result = converter.Convert(451);
        
        result.Should().Be(506.28M);
    }
}
