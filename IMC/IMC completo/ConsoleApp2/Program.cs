using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float peso;
            double imc;

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é" + imc);
                        
            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }
        }
    }
}