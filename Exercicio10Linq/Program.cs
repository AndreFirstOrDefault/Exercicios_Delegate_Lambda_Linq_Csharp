/*
Exercício 1: Utilizando o método Where

Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para obter somente as 
strings que contenham a letra 'a'.
*/

// Declarando um array de strings
string[] arrayString = new string[] { "casa", "carro", "árvore", "flor", "livro", "computador", "mesa", "cadeira", "janela", "porta", "lápis", "caneta", "telefone", "garrafa", "prato", "sapato", "relógio", "chave", "bolsa", "óculos" };

SomenteComA(arrayString);
Console.ReadKey();

// Método linq para retornar somente palavras com a
static void SomenteComA(string[] arrayString)
{
    Console.WriteLine("\nRetornando somente strings com A...\n");
    var stringsComA = arrayString.Where(s => s.Contains('a'));
    foreach (var s in stringsComA)
    {
        Console.WriteLine(s);
    }
}
