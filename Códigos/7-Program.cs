using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            // crie um algoritmo onde o usuario deve informar dois numeros e o sistema tem que dizer qual é o maior

            // Console.WriteLine("Informe o primeiro número");
            // float n1 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Informe o segundo número");
            // float n2 = float.Parse(Console.ReadLine());
            // if(n1 > n2)
            // {
            //     Console.WriteLine("O primeiro é maior");
            // }
            // else
            // {
            //     Console.WriteLine("O segundo é maior");
            // }          

            // leia 4 notas, calcule a média, em seguida deve mostrar a mensagem aprovado caso o aluno tenha média maior ou igual a 7, senão deve mostrar a mensagem reprovado.
            // Console.WriteLine("Informe a primeira nota");
            // float n1 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Informe a segunda nota");
            // float n2 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Informe a terceira nota");
            // float n3 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Informe a quarta nota");
            // float n4 = float.Parse(Console.ReadLine());
            // double media = (n1+n2+n3+n4)/4;
            // if(media >= 7)
            // {
            //     Console.WriteLine("Parabéns, você foi aprovado!");
            // }
            // else
            // {
            //     Console.WriteLine("Lamento, você não foi aprovado!");
            // }


            // Desafio do algoritmo do caixa eletronico
            // double saldo = 1000;
            // Console.WriteLine("Informe o valor do saque");
            // double saque = double.Parse(Console.ReadLine());
            // if(saldo >= saque)
            // {
            //     saldo = saldo-saque;
            //     Console.WriteLine("Saque efetuado, novo valor disponível é: " + saldo);
            // }       
            // else
            // {
            //     Console.WriteLine("Saldo insuficiente, é possível sacar no máximo: " + saldo);
            // }


            // Le 4 notas, calcular média e mostrar: reprovado se for menor que 4, aprovado se for maior que 7, recuperação se for menor que 7 e maior que 4
            // Console.WriteLine("Informe a primeira nota");
            // float n1 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Informe a segunda nota");
            // float n2 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Informe a terceira nota");
            // float n3 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Informe a quarta nota");
            // float n4 = float.Parse(Console.ReadLine());
            // double media = (n1 + n2 + n3 + n4) / 4;
            // if (media >= 7)
            // {
            //     Console.WriteLine("APROVADO!");
            // }
            // else
            // {
            //     if (media < 4)
            //     {
            //         Console.WriteLine("REPROVADO!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("RECUPERAÇÃO!");
            //     }
            // }

            // construa um algoritmo que leia um número inteiro e exiba a informação se este numero é ou não divisivel por 5.
            // Console.WriteLine("Informe um número inteiro");
            // int n1 = int.Parse(Console.ReadLine());
            // if ((n1 % 5) == 0)
            // {
            //     Console.WriteLine("Sim!");            
            // }
            // else
            // {
            //     Console.WriteLine("Não!");
            // }

            // construa um algoritmo que leia 3 numeros inteiros distintos e exiba o menor deles
            // Console.WriteLine("Informe a primeiro número");
            // float n1 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Informe a segundo número");
            // float n2 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Informe a terceiro número");
            // float n3 = float.Parse(Console.ReadLine());
            // if (n1 < n2 && n1 < n3)
            // {
            //     Console.WriteLine(n1 + " é o menor");
            // }
            // else
            // {
            //     if (n2 < n3)
            //     {
            //         Console.WriteLine(n2 + " é o menor");
            //     }
            //     else
            //     {
            //         Console.WriteLine(n3 + " é o menor");
            //     }
            // }


            // faça um algoritmo que leia o valor do salário bruto de um funcionário e se o salário for menor ou igual a 500, o algoritmo deve aplicar um aumento de 10%.
            // Console.WriteLine("Informe o valor bruto do seu salário");
            // double salariobruto = double.Parse(Console.ReadLine());
            // if (salariobruto <= 500)
            // {
            //     double aumento = salariobruto * 0.1;
            //     Console.WriteLine("Você receberá um aumento de 10% no seu salário, que é de: " + aumento);
            //     salariobruto = (salariobruto * 0.1) + salariobruto;
            //     Console.WriteLine("Valor do seu salário atual agora é: " + salariobruto);
            // }
            // else
            // {
            //     Console.WriteLine("Seu salário não teve ajuste e continua sendo: " + salariobruto);
            // }
        }

    }
}