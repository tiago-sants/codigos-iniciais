using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 16

            // crie um algoritmo para ler 2 numeros e mostrar se eles são iguais
            int n1, n2;
            Console.WriteLine("Informe o primeiro número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            n2 = int.Parse(Console.ReadLine());
            bool result = n1 == n2;
            Console.WriteLine(result);

    
        } 
        
    }
}