using System;

namespace Mercadinho.src
{
    public class Produto
    {
        // Atributos
        public string Nome {get; set;}
        public float Preco {get; set;}
        public string Classificacao{get; set;}
        public string Descricao{get; set;}


        // Construtor sem parametro
        public Produto(){}

        // Construtor com parametro
        public Produto(string nome, float preco, string classificacao, string descricao)
        {
            Nome = nome;
            Preco = preco;
            Classificacao = classificacao;
            Descricao = descricao;
        }

        // Métodos
        
        public virtual void Aviso(string aviso)
        {
            Console.WriteLine($"AVISO IMPORTANTE: Não consumir, deixar longe do alcance de crianças {aviso}");
        }

    }
}