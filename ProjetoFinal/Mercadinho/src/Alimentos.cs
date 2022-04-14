using System;

namespace Mercadinho.src
{
    public class Alimentos : Produto
    {
        // Construtor sem parametro
        public Alimentos() {}

        // Construtor com parametro
        public Alimentos(string nome, float preco, string classificacao, string descricao) : base (nome, preco, classificacao, descricao) {}

        public override void Aviso(string aviso)
        {
            Console.WriteLine ($"Lembrete: {aviso}");
        }
    }
}