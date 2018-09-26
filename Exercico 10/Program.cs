using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de Pares e a Soma de Impares");
            Console.WriteLine();

            int notas = 0;
            double totalNotas = 0;
            int i = 1;

            Console.Write("informe a quantidade de alunos na sala: ");
            int totalAlunos = Convert.ToInt32(Console.ReadLine());
            while (i <= totalAlunos)
            {

                Console.Write("Digite a nota do " + i + "° aluno: ");
                notas = Convert.ToInt32(Console.ReadLine());

                totalNotas = totalNotas + notas;

                i++;
            }

            double media =  totalNotas/ totalAlunos;
            Console.WriteLine();

            Console.WriteLine("A média das notas dessa sala é: " + media);

            Console.ReadKey();
        }
    }
}
