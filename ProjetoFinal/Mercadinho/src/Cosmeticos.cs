using System;

namespace Mercadinho.src
{
    public class Cosmeticos : Produto
    {
        // Construtor sem parametro
        public Cosmeticos() {}

        // Construtor com parametro
        public Cosmeticos(string nome, float preco, string classificacao, string descricao) : base (nome, preco, classificacao, descricao) {}
    }
}