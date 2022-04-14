using System;
using System.Collections.Generic;
using Mercadinho.src;

namespace Mercadinho
{
    class Program
    {
        static void Main(string[] args)
        {
            float aux = 0;
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao nosso mercadinho!\n");
            Console.WriteLine("Seu carrinho:\n");

        List<Produto> produtos = new List<Produto>
            (
                new Produto[]                {
                    new Alimentos("Bolacha",3.5f, "Alimento", "sabor chocolate, recheio de baunilha"),
                    new Alimentos("Nescau", 10.50f, "Alimento", "Nescau cereal, aquele achocolato pior que o toddy"),
                    new Cosmeticos("Esmalte", 8.99f, "Cosmetico", "cor vinho, brilhante cheio de glitter"),
                    new Cosmeticos("Gel de cabelo", 5.50f, "Cosmetico", "deixa o cabelo radical e em pé, beleza garantida"),
                    new Higiene("Papel Higienico", 15.00f, "Higiene", "folha dupla, uma folha já é o suficinte, macio e suave"),
                    new Higiene("Sabonete", 4.35f, "Higiene", "limpa tudo, te deixa cherosinho e com a pele hidratada")
                }
            );

        foreach (Produto produto in produtos)
            {
                aux = aux + produto.Preco;
                if (produto.Classificacao == "Alimento")
                {
                    Console.WriteLine($"{produto.Nome} é um {produto.Classificacao} e custa: R${produto.Preco}\nDescrição: {produto.Descricao}");
                    produto.Aviso("Deve ser consumido dentro do prazo de validade\n");
                } 
                else if (produto.Classificacao == "Cosmetico")
                {
                    Console.WriteLine($"{produto.Nome} é um {produto.Classificacao} e custa: R${produto.Preco}\nDescrição: {produto.Descricao}");
                    produto.Aviso("e vê se voce consegue ficar bonito\n");

                }
                else if (produto.Classificacao == "Higiene")
                {
                    Console.WriteLine($"{produto.Nome} é um produto de {produto.Classificacao} e custa: R${produto.Preco}\nDescrição: {produto.Descricao}");
                    produto.Aviso("e leia o modo de utilizar\n");
                }
            }
            Calc resultado = new Calc();
            Console.WriteLine($"O valor da sua compra é: R${aux}");
        }
    }
}
