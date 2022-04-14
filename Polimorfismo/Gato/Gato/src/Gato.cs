using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaVS8.src
{
    internal class Gato
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public int Tamanho { get; set; }

        public Gato()
        {

        }

        public Gato(string _name, string _cor, int _tamanho)
        {
            Nome = _name;
            Cor = _cor;
            Tamanho = _tamanho;
        }
        public void Dormir()
        {
            Console.WriteLine("ZzzzZZzzzz");
        }

        public void Comer(string comida)
        {
            Console.WriteLine($"Estou comendo{comida}");
        }

        public string Ronronar()
        {
            return "Ronroneando ... RrRRRrrrRRRrr"
        }    
    }

}
