using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um numero da tabuada: ");
            int numero = Convert.ToInt32(Console.ReadLine());
             
            for (int x = 1; x <= 20; x++)
            {
                Console.WriteLine(numero + " * " + x + " = " + numero + x);
            }
        }
    }
}
