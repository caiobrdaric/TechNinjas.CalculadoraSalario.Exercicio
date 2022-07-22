//Método para calcular imposto de renda
double CalcularImpostoDeRenda (double salario)
{
    if(salario > 1903.99 && salario <= 2829.65)
    {
        double aliquota = 0.925;
        salario = (salario * aliquota) + 142.80;
        return salario;
    }
    if (salario >= 2826.65 && salario <= 3751.05)
    {
        double aliquota = 0.85;
        salario = (salario * aliquota) + 354.80;
        return salario;
    }

    if (salario >= 3751.05 && salario <= 4664.68)
    {
        double aliquota = 0.775;
        salario = (salario * aliquota) + 636.13;
        return salario;
    }

    if (salario >= 4664.68)
    {
        double aliquota = 0.725;
        salario = (salario * aliquota) + 869.36;
        return salario;
    }

    return salario;

}

//Método para calcular INSS
double CalcularINSS(double salario)
{
    double descINSS = 0;
    if (salario <= 1830.29)
    {
        descINSS = ((salario * 8) / 100);
        return descINSS;
    }
    if(salario >= 1830.30 && salario <= 3050.52)
    {
        descINSS = ((salario * 9) / 100);
        return descINSS;
    }
    if(salario >= 3050.53 && salario <= 6101.06)
    {
        descINSS = ((salario * 11) / 100);
        return descINSS;
    }
    return descINSS;
}

Console.WriteLine("Valor do salário:");
var salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Salario com desconto do imposto de renda: {CalcularImpostoDeRenda(salario)}");
Console.WriteLine($"Desconto INSS: {CalcularINSS(salario)}");
//Exemplo de interpolação
Console.WriteLine($"Valor do salário com descontos: {Math.Round(CalcularImpostoDeRenda(salario) - CalcularINSS(salario),2)}");
