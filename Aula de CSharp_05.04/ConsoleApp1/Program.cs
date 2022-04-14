using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você concluiu o curso?: (sim ou não) ");
            string condicaoCursoConcluido = Console.ReadLine();

            Console.WriteLine("Quantos cursos você concluiu?: ");
            int condicaoQuantidadeDeCursosConcluidos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você pagou todo o curso?: (sim ou não) ");
            string condicaoQuitacao = Console.ReadLine();

            Console.WriteLine("Você devolveu todos os livros?: (sim ou não) ");
            string condicaoBiblioteca = Console.ReadLine();


            if (condicaoCursoConcluido == "sim" &&
                condicaoQuantidadeDeCursosConcluidos >= 25 &&
                condicaoQuitacao == "sim" &&
                condicaoBiblioteca == "sim")
            {
                Console.WriteLine("Pode Colar Grau");
            }
            else
            {
                Console.WriteLine("Não pode Colar Grau");
            }
         }
    }
}
