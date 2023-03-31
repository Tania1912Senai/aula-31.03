
//Exercicio 2

//Placar de Futebol
Console.WriteLine($"digite gols do time A");
float golTimeA = float.Parse(Console.ReadLine());

Console.WriteLine($"digite gols do timeB");
float golTimeB = float.Parse(Console.ReadLine());


if (golTimeA > golTimeB)
{
    Console.WriteLine($"venceu time A");
}
else if (golTimeB > golTimeA)
{
    Console.WriteLine($"venceu time B");
}
else
{
    Console.WriteLine($"Empate");
}