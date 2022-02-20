using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 17

            // crie um algoritmo para ler 4 notas, calcular a média, em seguida deve mostrar se o aluno esta de recuperação ou não. Recuperação: se média for maior que 3 e menor que 6.
            // int n1, n2, n3, n4;
            // Console.WriteLine("Informe a primeira nota");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Informe a segunda nota");
            // n2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Informe a terceira nota");
            // n3 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Informe a quarta nota");
            // n4 = int.Parse(Console.ReadLine());
            // int media = (n1 + n2 + n3 + n4) / 4;            
            // bool result = media > 3 && media < 6;
            // Console.WriteLine("Recuperação: " + result);

            // OU
            int n1, n2, n3, n4;
            Console.WriteLine("Informe a primeira nota");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota");
            n4 = int.Parse(Console.ReadLine());
            int media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("Está de recuperação: ");
            Console.WriteLine((media > 3) && (media < 6));
            

    
        } 
        
    }
}