//Exercicio 3

Console.WriteLine($"Poligono com 3 lados A,B,C");

Console.WriteLine($"digite valor de A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine($"digite valor de B");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"digite valor de C");
int C = int.Parse(Console.ReadLine());

//Triangulo 
//A menor que B + C
//B menor que A + C
//C igual A + B

if ((A == B) && (B == C))
{
    Console.Write("triangulo equilatero");
}
else if ((A == B) && (B != C))
{
    Console.Write("triangulo isosceles");
}
else
{
    Console.Write("triangulo isosceles");

}
