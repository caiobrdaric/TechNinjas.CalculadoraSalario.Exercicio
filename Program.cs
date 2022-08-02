double CalculoINSS(double salario)
{
    double c_salario = salario;
    double desconto = 0;

    if (salario <= 1212)
    {
        desconto = c_salario - (c_salario * 0.925);
    }
    if (salario > 1212.01 && salario <= 2427.35)
    {
        desconto = c_salario - (c_salario * 0.91);
    }
    if (salario >= 2427.36 && salario <= 3641.03)
    {
        desconto = c_salario - (c_salario * 0.88);
    }
    if (salario >= 3641.04 && salario <= 7087.22)
    {
        desconto = c_salario - (c_salario * 0.86);
    }
    return desconto;
}
double CalculoIR(double salario)
{
    double c_salario = salario;
    double desconto = 0;

    if (c_salario <= 1903.98)
    {
    }
    if (c_salario >= 1903.99 && c_salario <= 2826.65)
    {
        desconto = ((c_salario - (c_salario * 0.925)) - 142.80);

    }
    if (c_salario >= 2826.66 && c_salario <= 3751.05)
    {
        desconto = (c_salario - (c_salario * 0.85)) - 354.80;

    }
    if (c_salario >= 3751.06 && c_salario <= 4664.68)
    {
        desconto = (c_salario - (c_salario * 0.775)) - 636.13;

    }
    if (c_salario >= 4664.69)
    {
        desconto = (c_salario - (c_salario * 0.725)) - 869.36;

    }
    return desconto;
}

//Método CalculaDescontos tem como objetivo calcular todos os descontos do salário
double CalculaDescontos(double salario)
{
    //Criação da variável
    var salarioComDescontos = 0.0;

    salarioComDescontos = salario - CalculoIR(salario) - CalculoINSS(salario);
    return Math.Round(salarioComDescontos, 2);
}

Console.WriteLine("Digite o salário");
double salario = Convert.ToDouble(Console.ReadLine());

var descontoINSS = CalculoINSS(salario);
var descontoIR = CalculoIR(salario);
double salarioliquido = salario - descontoIR - descontoINSS;
<<<<<<< HEAD

Console.WriteLine($"Desconto do IR: {descontoIR}");
Console.WriteLine($"Desconto do INSS: {descontoINSS}");
Console.WriteLine($"Seu salario é {salarioliquido}");
=======
Console.WriteLine($"Desconto do IR: {Math.Round(descontoIR,2)}");
Console.WriteLine($"Desconto do INSS: {Math.Round(descontoINSS,2)}");
Console.WriteLine($"Seu salario é {salarioliquido}");

Console.WriteLine($"Salario líquido: {CalculaDescontos(salario)}");