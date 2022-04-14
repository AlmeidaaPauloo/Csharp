using System;

namespace Mercadinho.src
{
    public class Higiene : Produto
    {
        // Construtor sem parametro
        public Higiene() {}

        // Construtor com parametro
        public Higiene(string nome, float preco, string classificacao, string descricao) : base (nome, preco, classificacao, descricao) {}
    }
}