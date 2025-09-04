using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_net_POO.Models
{
    public class Professor : Pessoa
    {
        // Construtores
        public Professor(string nome, int idade) : base(nome, idade)
        {
        }

        // Propriedades
        public decimal Salario { get; set; }

        // Métodos
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário é de R$ {Salario}.");
        }
    }
}