/*
Exercício 2: Utilizando o método OrderBy

Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ para ordenar os valores 
em ordem crescente.
*/

// Gerando um array de inteiros
int[] arrayInteiros = new int[] { 5,2,16,200,7,125,0,82,3,98,1,22};

Console.WriteLine("\nArray antes de ordenar...");

foreach (var item in arrayInteiros)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n\nArray após ordenar...");
OrdenaArrayInteiros(arrayInteiros);

Console.ReadKey();

static void OrdenaArrayInteiros(int[] arrayInteiros)
{
    var arrayOrdenado = arrayInteiros.OrderBy(x => x).ToArray();
    foreach (var item in arrayOrdenado)
    {
        Console.Write(item + " ");
    }
}


