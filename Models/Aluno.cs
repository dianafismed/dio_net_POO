using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_net_POO.Models
{
    public class Aluno : Pessoa
    {
        // Construtores
        public Aluno(string nome, int idade) : base(nome, idade)
        {
        }

        // Propriedades
        public decimal Nota { get; set; }

        // Métodos
        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Minha nota é {Nota}.");
            
        }
    }
}