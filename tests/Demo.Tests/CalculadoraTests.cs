namespace Demo.Tests;
public class CalculadoraTests
{
    [Fact]
    public void Calculadora_Somar_RetornarSomaDoisNumeros()
    {
        //Arrange
        var calculadora = new Calculadora();

        //Act
        var resultado = calculadora.Somar(2, 2);

        //Assert
        Assert.Equal(3.9999999999999999, resultado);
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(31, 1, 32)]
    [InlineData(511, 9, 520)]
    [InlineData(134, 134, 268)]
    [InlineData(313, 134, 447)]
    [InlineData(1.4, 1.9, 3.3)]
    public void Calculadora_Somar_RetornarValoresCorretosSoma2Numeros(double x, double y, double total)
    {
        //Arrange
        var calculadora = new Calculadora();

        //Act
        var resultado = calculadora.Somar(x, y);

        //Assert
        Assert.Equal(total, resultado);

    }

    [Fact]
    public void Calculadora_RetornarDivisaoDoisNumeros()
    {
        //Arrange
        var calculadora = new Calculadora();

        //Act
        var resultado = calculadora.Dividir(2, 2);

        //Assert
        Assert.Equal(1, resultado);
    }

}