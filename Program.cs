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
    if (salario <= 1212.00)
    {
        descINSS = ((salario * 7.5) / 100);
        return descINSS;
    }
    if(salario >= 1212.01 && salario <= 2427.35)
    {
        descINSS = ((salario * 9) / 100);
        return descINSS;
    }
    if(salario >= 2427.36 && salario <= 3641.03)
    {
        descINSS = ((salario * 12) / 100);
        return descINSS;
    }
    if (salario >= 3641.04 && salario <= 7087.22)
    {
        descINSS = ((salario * 12) / 100);
        return descINSS;
    }
    return descINSS;
}

//Método calculaDescontos tem como objetivo calcular todos os descontos a partir de um salário
double CalculaDescontos(double salario)
{
    var salarioComDesconto = 0.0;

    salarioComDesconto = Math.Round(CalcularImpostoDeRenda(salario) - CalcularINSS(salario), 2);
    return salarioComDesconto;
}

Console.WriteLine("Valor do salário:");
var salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Salario com desconto do imposto de renda: {CalcularImpostoDeRenda(salario)}");
Console.WriteLine($"Desconto INSS: {CalcularINSS(salario)}");
//Exemplo de interpolação
//Função Math.Round() -> Utilizada para formatação do valor
Console.WriteLine($"Valor do salário com descontos: {Math.Round(CalcularImpostoDeRenda(salario) - CalcularINSS(salario),2)}");

//Imprimindo a função CalculaDescontos
Console.WriteLine($"Salario com os descontos: {CalculaDescontos(salario)}");
