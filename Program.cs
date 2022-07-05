using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double notat, nota1, nota2, final;
           string nome;
           Console.Write("escreva nome do aluno: ");
           nome = Console.ReadLine();
           Console.Write("nota do trabalho: ");
           notat = Convert.ToDouble(Console.ReadLine());
           Console.Write("digite prova 1:  ");
           nota1 = Convert.ToDouble(Console.ReadLine());
           Console.Write("digite prova 2:  ");
           nota2 = Convert.ToDouble(Console.ReadLine());
           final = (notat + nota1 + nota2) / 3;

            if (final >= 8.5)
            {
                Console.Write("Sua nota foi A");
            }
            else if (final >= 7)
            {
                Console.Write("Sua nota foi B ");
            }
            else if (final >= 6)
            {
                Console.Write("Sua nota foi C ");
            }
            else if (final >= 0.1)
            {
                Console.Write("Sua nota foi D ");
            }
            else if (final == 0.0 )
            {
                Console.Write("Sua nota foi E ");
            }
            else 
                Console.Write("Erro digite novamente");
            Console.ReadKey();



        }
    }
}
