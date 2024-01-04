/*
6- Crie um programa onde um método que receba dois números inteiros e retorne o resultado da operação 
de adição ou subtração desses números, a ser definida em tempo de execução por um delegate Func<int, int, 
int>.
*/

Func<int, int, int> adicaoOuSubtracao;
Random random = new Random();
int opcao = random.Next(2);

if(opcao == 0)
{
    adicaoOuSubtracao = Somar;
}
else
{
    adicaoOuSubtracao = Subtrair;
}

var resultado = adicaoOuSubtracao.Invoke(120, 20);

Console.WriteLine($"Resultado da operação de adição ou subtração : {resultado}");

static int Somar(int x, int y)
{
    return x + y;
}

static int Subtrair(int x, int y)
{
    return x - y;
}

Console.ReadKey();