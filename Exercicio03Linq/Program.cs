/*
Exercício 3: Utilizando o método GroupBy

Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para agrupar as strings por 
tamanho 
*/

// Criando um array de strings
string[] arrayString = new string[] {"marrom", "rato", "pato", "Brasil", "computador","mesa", "ferramenta", "hospital","oficina" };

var grupos = arrayString.GroupBy(s => s.Length);
                    
foreach(var grupo in grupos)
{
    Console.WriteLine($"Strings de tamanho {grupo.Key}");
    foreach (var item in grupo)
    {
        Console.WriteLine($" {item}");
    }
    Console.WriteLine();
}

Console.ReadKey();