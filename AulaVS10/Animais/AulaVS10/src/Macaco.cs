﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Zoologico.src
    {
        public class Macaco : Animal
        {
            // Construtor sem parametro
            public Macaco() { }

            public Macaco(string nome, string cor, string classificacao) : base(nome, cor, classificacao) { }

            // Método Comunicação
            public override void Comunicar(string comunicacao)
            {
                Console.WriteLine($"{Nome} está falando: {comunicacao}");
            }
        }
    }

   

