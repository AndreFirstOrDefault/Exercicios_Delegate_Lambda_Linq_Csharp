/*
Exercício 4: Utilizando o método FirstOrDefault

Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ para obter o primeiro 
número par do array. 
*/

int[] arrayInteiros = new int[] {15,89,33,5,77,200,204,9,10 };

var primeiroPar = arrayInteiros.FirstOrDefault(x => x%2 == 0);

Console.WriteLine($"\nPrimeiro número par encontrado no array: {primeiroPar}");

Console.ReadKey();