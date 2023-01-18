


using System;

namespace Junior
{
  class Program
  {
    enum Menu {Soma = 1, Subtração, Divisão, Multiplicacao, Potencia, Raiz, Sair}
static void Main(string[] args)
{

bool escolheuSair = false;
while(!escolheuSair){
Console.WriteLine("Bem vindo ao Calc, selecione uma das opções:");
Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");





//Convertendo numero para o tipo Menu
Menu opcao = (Menu)int.Parse(Console.ReadLine());
//Mostrando no console a opção que o usuário selecionou
/*Console.WriteLine(opcao);*/

switch (opcao)
{

    case Menu.Soma:
    Soma();
    break;
    
    case Menu.Subtração:
    subtracao();
    break;

    case Menu.Divisão:
    divisao();
    break;

    case Menu.Multiplicacao:
    Mult();
    break;

    case Menu.Potencia:
    Pot();
    break;

    case Menu.Raiz:
    Raiz();
    break;


    case Menu.Sair:
    escolheuSair = true;
    break;
}

Console.Clear();



Console.ReadLine();
}
}

static void Soma(){
Console.WriteLine("Soma de dois numeros: ");
Console.WriteLine("Digite o primeiro numero: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(" Digite o segundo numero:");
int b = int.Parse(Console.ReadLine());
int result = a + b;
Console.WriteLine("o Resultado é " + result);
Console.WriteLine("Aperte o Enter para voltar para o Menu");
Console.ReadLine();

}
static void subtracao ()
{
Console.WriteLine("Subtração de dois numeros: ");
Console.WriteLine("Digite o primeiro numero: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(" Digite o segundo numero:");
int b = int.Parse(Console.ReadLine());
int result = a - b;
Console.WriteLine("o Resultado é " + result);
Console.WriteLine("Aperte o Enter para voltar para o Menu");
Console.ReadLine();
}

static void divisao ()
{
Console.WriteLine("Divisão de dois numeros: ");
Console.WriteLine("Digite o primeiro numero: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(" Digite o segundo numero:");
int b = int.Parse(Console.ReadLine());
float result = (float) a / (float) b;
Console.WriteLine("o Resultado é " + result);
Console.WriteLine("Aperte o Enter para voltar para o Menu");
Console.ReadLine();
}

static void Mult ()
{
Console.WriteLine("Multiplicação de dois numeros: ");
Console.WriteLine("Digite o primeiro numero: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(" Digite o segundo numero:");
int b = int.Parse(Console.ReadLine());
int result =  a * b;
Console.WriteLine("o Resultado é " + result);
Console.WriteLine("Aperte o Enter para voltar para o Menu");
Console.ReadLine();
}
static void Pot ()
{
Console.WriteLine("Potenciação de dois numeros: ");
Console.WriteLine("Digite o numero base: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(" Digite o segundo numero:");
int b = int.Parse(Console.ReadLine());
int result =  (int)Math.Pow(a, b);
Console.WriteLine("o Resultado é " + result);
Console.WriteLine("Aperte o Enter para voltar para o Menu");
Console.ReadLine();
}

static void Raiz ()
{
Console.WriteLine("Raiz de um  numero: ");
Console.WriteLine("Digite o numero: ");
int a = int.Parse(Console.ReadLine());
double result =  (int)Math.Sqrt(a);
Console.WriteLine("o Resultado é " + result);
Console.WriteLine("Aperte o Enter para voltar para o Menu");
Console.ReadLine();
}

   }
}



