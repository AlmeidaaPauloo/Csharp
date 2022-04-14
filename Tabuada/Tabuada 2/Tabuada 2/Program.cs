using System;

namespace Tabuada_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite um numero da tabuada: ");

            for (int x = 1; x <= 20; x++)
            {
                Console.WriteLine($"\nTabuada do: {x}");
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine(x + "x" + y + " = " + (x * y));
                }
            }
        }
    }
}
