/*
5- Imagine que você precisa criar um método que imprima na tela os números pares de uma lista de inteiros 
de 1 a 20.

Para isso, você deve utilizar um delegate Action<int> que receba um número inteiro como parâmetro e 
imprima na tela apenas os números pares. 
*/
Console.Title = "Delegate Action";

// Opção, inserindo números de forma manual
int[] numerosInteiros1 = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };

// Usando for para adicionar numeros na lista
int[] numerosInteiros2 = new int[20];
for (int i = 0; i < 20; i++)
{
    numerosInteiros2[i] = i + 1;
}

// Usando outra forma
var listaNumeros = Enumerable.Range(1, 20).ToList();

Action<int> exibirNumerosPares = numero =>
{
    if (numero % 2 == 0)
    {
        Console.Write(numero + " ");
    }
};

Array.ForEach(numerosInteiros1, exibirNumerosPares);

Console.ReadKey();

