Console.WriteLine("Valor do salário:");
var salario = Convert.ToDouble(Console.ReadLine());

double aliquota = 0;

if (salario <= 1903.98)
{
    salario = salarioliquido;
}

if (salario > 1903.98 && salario <= 2826.65)
{
    aliquota = 0.925;
    salarioliquido = (salario * aliquota) + 142.80; 
}

if (salario >= 2826.65 &&  salario <= 3751.05 )
{
    aliquota = 0.85;
    salarioliquido = (salario * aliquota) + 354.80; 
}

if (salario >= 3751.05 && salario <= 4664.68)
{
    aliquota = 0.775;
    salarioliquido = (salario * aliquota) + 636.13;
}

if (salario >= 4664.68)
{
    aliquota = 0.725;
    salarioliquido = (salario * aliquota) + 869.36; 
}

Console.WriteLine($"Salário liquido de: {Math.Round(salarioliquido, 2)}");