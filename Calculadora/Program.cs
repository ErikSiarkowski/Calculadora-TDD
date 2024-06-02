

using Calculadora.Services;

CalculadoraImp calculadora= new CalculadoraImp();


calculadora.Somar(1,2);
calculadora.Somar(1,2);
calculadora.Somar(1,2);
var lista = calculadora.Historico();
foreach (var item in lista)
{
    Console.WriteLine(item);
}