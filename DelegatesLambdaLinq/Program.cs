/*
2- Implemente um programa que use delegates para somar dois números inteiros. O programa deve seguir 
as seguintes especificações:

 a-Defina um delegate chamado OperacaoMatematica que recebe dois inteiros como parâmetros e retorna 
    um inteiro.
 b-Defina um método que implementam a operação de soma: que recebe os dois inteiros como parâmetros 
 c-Crie um objeto delegate do tipo OperacaoMatematica e atribua a ele ao método definido.
 d-Chame o delegate passando os parâmetros necessários e exiba o resultado da operação na tela.
  
 */

Console.Title = "02 - Delegate";

// b
static int Somar(int x, int y)
{
    return x + y;
}

// c
OperacaoMatematica operacaoSoma = Somar;

// d
Console.WriteLine($"Resultado da operação com delegate: {operacaoSoma(50,30)}");
Console.WriteLine($"Resultado da operação com delegate: {operacaoSoma.Invoke(30,70)}");

Console.ReadKey();

// a
public delegate int OperacaoMatematica(int numero1, int numero2);
