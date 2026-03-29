Console.WriteLine("Par ou ímpar\n");

Console.WriteLine("Informe um número");
int numero = int.Parse(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("0 não é um número aceito");
}
else if(numero % 2 == 0)
{
    Console.WriteLine("O número é par");
}
else
{
    Console.WriteLine("O número é ímpar");
}

Console.ReadKey();