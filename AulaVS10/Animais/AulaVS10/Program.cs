using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico;


namespace Zoologico.src
{
        public class Animal
        {
          public class Program
             { 

            static void Main(string[] args)
            {
                Console.WriteLine("Zoológico");

                List<Animal> animais = new List<Animal>
                (
                    new Animal[]                
                    {
                new Gato("Gato Catel", "Cinza", "Felino"),
                new Cachorro("Cachorro Rodrigo", "Preto", "Canidio"),
                new Cachorro("Cachorro Bueno", "Branco", "Canidio"),
                new Gato("Gato Cavalcanti", "Marrom", "Felino"),
                new Macaco("Macaco Oliveira", "Marrom", "Primata")
                    }
                );

                foreach (Animal animal in animais)
                {
                    if (animal.Classificacao == "Canidio")
                    {
                        Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                        animal.Comunicar("Au Au!");
                    }
                    else if (animal.Classificacao == "Felino")
                    {
                        Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                        animal.Comunicar("Miau!");

                    }
                    else if (animal.Classificacao == "Primata")
                    {
                        Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                        animal.Comunicar("huhu HAHA!");
                    }
                }

             }   

          }

        }

}

