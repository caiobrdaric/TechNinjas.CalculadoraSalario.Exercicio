double CalculoINSS(double salario)
{
    double faixa1 = 90.90;
    double faixa2 = faixa1+109.38;
    double faixa3 = faixa2 + 145.64;
    double faixa4 = faixa3 + 482.46;

    if (salario <= 1212)
    {
        return salario - (salario * 0.925);
    }
    if (salario > 1212.01 && salario <= 2427.35)
    {
        return faixa1 + ((salario - 1212.01) * 0.09);
    }
    if (salario >= 2427.36 && salario <= 3641.03)
    {
        return faixa2 + ((salario - 2427.36) * 0.12);
    }
    if (salario >= 3641.04 && salario <= 7087.22)
    {
        return faixa3 + ((salario - 3641.04) * 0.14);
    }
    if (salario > 7087.22)
    {
        return faixa4;
    }
    return 0;
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

Console.WriteLine("Digite o salário");
double salario = Convert.ToDouble(Console.ReadLine());

var descontoINSS = CalculoINSS(salario);
var descontoIR = CalculoIR(salario);
double salarioliquido = salario - descontoIR - descontoINSS;

Console.WriteLine($"Desconto do IR: {Math.Round(descontoIR, 2)}");
Console.WriteLine($"Desconto do INSS: {Math.Round(descontoINSS, 2)}");
Console.WriteLine($"Seu salario é {Math.Round(salarioliquido),2 }");
