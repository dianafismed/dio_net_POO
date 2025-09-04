using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_net_POO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base(nome, idade)
        {
        }

        public decimal Nota { get; set; }
    }
}