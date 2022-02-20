using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {     
            // //whlie estrutura
            // while(true)
            // {
            //     //instrução
            // }

            // Ex1 do while
            // int resultado = 0;
            // Console.WriteLine("Informe um número");
            // int numero = int.Parse(Console.ReadLine());
            // while(numero != 0)
            // {
            //     resultado = resultado + numero;
            //     Console.WriteLine("Resultado parcial:" + resultado);
            //     Console.WriteLine("Informe um número");
            //     numero = int.Parse(Console.ReadLine());

            // }

            // Console.WriteLine("Resultado final = " + resultado);


            //Ex2 While
            // Console.WriteLine("Informe um número válido");
            // int num = int.Parse(Console.ReadLine());
            // while(num < 100)
            // {
            //     Console.WriteLine("Número inválido, informe um número válido");                
            //     num = int.Parse(Console.ReadLine());                
            // }
            // Console.WriteLine("numero informado corretamente");


            // Ex3 while
            // Console.WriteLine("Desafiante, informe um número de 0 a 9");
            // int numd = int.Parse(Console.ReadLine());
            // Console.Clear();
            // Console.WriteLine("Jogador, tente acertar o número do desafiante de 0 a 9");
            // int numj = int.Parse(Console.ReadLine());
            // while (numj != numd)
            // {
            //     Console.WriteLine("Infelizmente você errou, tente novamente");
            //     numj = int.Parse(Console.ReadLine());
            // }
            // Console.WriteLine("Parabéns, você acertou o número do desafiante");

            // Tentar filtrar se o desafiante e o jogador colocou número de 0 a 9
            Console.WriteLine("Desafiante, informe um número de 0 a 9");
            int numd = int.Parse(Console.ReadLine());
            while (!(numd >= 0 && numd <= 9))
            {
                Console.WriteLine("Informe apenas números de de 0 a 9");
                numd = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Jogador, tente acertar o número do desafiante de 0 a 9");
            int numj = int.Parse(Console.ReadLine());
            while (numj < 0 || numj > 9)
            {
                Console.WriteLine("Informe apenas números de de 0 a 9");
                numj = int.Parse(Console.ReadLine());
            }
            while (numj != numd)
            {
                Console.WriteLine("Infelizmente você errou, tente novamente");
                numj = int.Parse(Console.ReadLine());
                while (numj < 0 || numj > 9)
                {
                    Console.WriteLine("Informe apenas números de de 0 a 9");
                    numj = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Parabéns, você acertou o número do desafiante");

        }

    }
}