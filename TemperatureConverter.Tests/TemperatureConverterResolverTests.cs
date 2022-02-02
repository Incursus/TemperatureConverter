using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConverter.Tests;

[TestClass]
public class TemperatureConverterResolverTests
{
    [TestMethod]
    public void GetsMatchedConverterWhenFound()
    {
        var resolver = new TemperatureConverterResolver();

        var result = resolver.Get(new List<ITemperatureConverter?>() {new FahrenheitToKelvinConverter(), new CelsiusToFahrenheitConverter()}, "C", "F");

        result.Should().NotBeNull();
        result.Should().BeOfType<CelsiusToFahrenheitConverter>();
    }
    
    [TestMethod]
    public void GetsNullConverterWhenNotFound()
    {
        var resolver = new TemperatureConverterResolver();

        var result = resolver.Get(new List<ITemperatureConverter?>() {new CelsiusToFahrenheitConverter()}, "Z", "Z");

        result.Should().BeNull();
    }
}
