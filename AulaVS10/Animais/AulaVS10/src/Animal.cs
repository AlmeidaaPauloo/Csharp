using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaVS10;

namespace Zoologico.src
{
    
          
        public class Animal
        {
            // Atributos
            public string Nome { get; set; }
            public string Cor { get; set; }
            public string Classificacao { get; set; }

            // Construtor sem parametro
            public Animal() { }

            // Construtor com parametro
            public Animal(string nome, string cor, string classificacao)
            {
                Nome = nome;
                Cor = cor;
                Classificacao = classificacao;
            }

            // Método
            public virtual void Comunicar(string comunicacao)
            {
                Console.WriteLine($"{Nome} está falando: {comunicacao}");
            }
        }
    
}

