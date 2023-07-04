Console.WriteLine("Digite o valor do seu salário:");
int valorS = Convert.ToInt32(Console.ReadLine());

int imposto;

if (valorS <= 2000)
{
    imposto = valorS / 100 * 10;
}
else if (valorS <= 3500)
{
    imposto = valorS / 100 * 13;
}
else
{
    imposto = valorS / 100 * 15;
}

Console.WriteLine($"\nO valor do seu imposto é: {imposto} Reais.");
Console.ReadKey();
