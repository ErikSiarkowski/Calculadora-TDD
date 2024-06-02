using Calculadora.Services;

namespace CalculadoraTestes;
public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveDividirPor0RetornarErro()
    {
        // Arrange
        int num1 = 1;
        int num2 = 0;
        // Act && Assert
        Assert.Throws<DivideByZeroException>(()=> _calc.Dividir(num1,num2));

    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;
        // Act
        int resultado = _calc.Somar(num1,num2);
        // Assert
        Assert.Equal(15, resultado);
    }
    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;
        // Act
        int resultado = _calc.Somar(num1,num2);
        // Assert
        Assert.Equal(20, resultado);
    }
    [Theory]
    [InlineData(new int [] {2,4,6,8,10})]
    public void DeveVerificarSeListaTemNumerosParesERetornarVerdadeiro(int[] numero)
        {
            // Assert
            Assert.All(numero, num => Assert.True(_calc.EhPar(num)));
        }
}