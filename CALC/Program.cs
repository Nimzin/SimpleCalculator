using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        Console.WriteLine("bem vindo a calculadora do Nim");
        Console.Write("Digite um numero: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Numero invalido");
            return;
        }
        Console.Write("Digite o segundo numero: ");
        if (!double.TryParse(Console.ReadLine(),out double num2))
        {
            Console.WriteLine("Numero invalido");
            return;
        }
        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.Write("Opção: ");

        if (!int .TryParse(Console.ReadLine(),out int opcao) || opcao < 1 || opcao > 4)
        {
            Console.WriteLine("Opção inválida");
            return;
        }
        double resultado = 0;
        switch(opcao)
        {
            case 1: resultado = num1 + num2; break;
            case 2: resultado = num1 - num2; break;
            case 3: resultado = num1 * num2; break;
            case 4: if (num2 == 0)
                {
                    Console.WriteLine("Impossivel dividir por 0");
                    return;
                }
                resultado = num1 / num2; break;
            
        }
        Console.WriteLine(resultado);
        Thread.Sleep(5000);
        Console.Clear();
        Main();

    }


}