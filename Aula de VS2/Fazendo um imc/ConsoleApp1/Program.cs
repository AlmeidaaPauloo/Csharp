using System;

namespace Aula3VSC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float peso;
            float imc;

            Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            peso = float.Parse(Console.WriteLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é" + imc);
            

        }
    }
}
