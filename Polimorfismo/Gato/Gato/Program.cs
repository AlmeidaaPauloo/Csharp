using AulaVS8.src;
using System;

namespace AulaVS8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Gato Garfield = new Gato("Garfield", "Laranja", 8);
            Gato Tomas = new Gato("Tomas", "Cinza", 5);
            Gato Frajola = new Gato("Frajola", "Preto", 3);


            Console.WriteLine($"Gato1: é o {Garfield.Nome} de cor {Garfield.Cor} e tem o tamanho{Garfield.Tamanho} ");
            Console.WriteLine($"Gato1: é o {Tomas.Nome} de cor {Tomas.Cor} e tem o tamanho{Tomas.Tamanho} ");
            Console.WriteLine($"Gato1: é o {Frajola.Nome} de cor {Frajola.Cor} e tem o tamanho{Frajola.Tamanho} ");

            Garfield.Comer("Lasanha");
            Tomas.Dormir();
            Frajola.Ronronar();
        }
    }
}
