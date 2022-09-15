/* 
* Programa C# para verificar se o número digitado é par ou ímpar
*/ 

using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.Write("Número inserido é um número par");
                Console.Read();
            }
            else
            {
                Console.Write("O número digitado é um número ímpar");
                Console.Read();
            }
        }
    }
}