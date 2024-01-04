#region Exercicio 02
/*

2- Implemente um programa que use delegates para somar dois números inteiros. O programa deve seguir 
as seguintes especificações:

 a-Defina um delegate chamado OperacaoMatematica que recebe dois inteiros como parâmetros e retorna 
    um inteiro.
 b-Defina um método que implementam a operação de soma: que recebe os dois inteiros como parâmetros 
 c-Crie um objeto delegate do tipo OperacaoMatematica e atribua a ele ao método definido.
 d-Chame o delegate passando os parâmetros necessários e exiba o resultado da operação na tela.
  

*/

/* 
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
*/
#endregion

#region Exercicio 03

/*
3- Implemente um programa em C# que use multicast delegates para exibir uma mensagem de boas-vindas 
ao usuário. O programa deve seguir as seguintes especificações:

a-) Defina um multicast delegate chamado MensagemBoasVindas que não recebe parâmetros e não retorna 
nenhum valor.

b-) Defina duas funções que exibem uma mensagem de boas-vindas: uma em português e outra em inglês.

c-) Crie um objeto delegate do tipo MensagemBoasVindas e adicione as duas funções criadas a ele usando o 
operador +=.

d-) Chame o delegate para executar as duas funções e exibir as mensagens de boas-vindas.
*/

/*
Console.Title = "Delegate Multicast";

// c
MensagensBoasVindas mBV = BoasVindas;
mBV += Welcome;

// d
mBV.Invoke();

// b
static void BoasVindas()
{
    Console.WriteLine("\nBoas vindas ao delegate multicast!");
}

static void Welcome()
{
    Console.WriteLine("\nWelcome to multicast delegate");
}

Console.ReadKey();

//a
public delegate void MensagensBoasVindas();

*/
#endregion

#region Exercicio 05

/*
5- Imagine que você precisa criar um método que imprima na tela os números pares de uma lista de inteiros 
de 1 a 20.

Para isso, você deve utilizar um delegate Action<int> que receba um número inteiro como parâmetro e 
imprima na tela apenas os números pares. 
*/
Console.Title = "Delegate Action";



Console.ReadKey();


#endregion