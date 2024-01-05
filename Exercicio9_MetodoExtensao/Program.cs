/*
9- Crie um método de extensão para a classe List<int> na linguagem C# que, dado uma lista de inteiros, 
    retorne a soma de todos os elementos da lista que são ímpares.
    Em seguida, crie um programa que instancie uma lista de inteiros com alguns números ímpares e alguns 
    números pares e use o método de extensão criado para obter a soma dos números ímpares da lista. 
*/

List<int> listaInteiros = new List<int>() { 1,2,3};
var resultado = listaInteiros.SomaDeImparesExtension();

Console.WriteLine($"\nSoma de números ímpares de uma lista usando método de extensão\nResultado: {resultado}");

Console.ReadKey();

public static class SomaImparesExtension
{
    public static int SomaDeImparesExtension(this List<int> listaNumeros)
    {
        int soma = 0;
        foreach (var numero in listaNumeros)
        {
            if (numero % 2 != 0)
            {
                soma += numero;
            }
        }
        
        return soma;
    }
}


