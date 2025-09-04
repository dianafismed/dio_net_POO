using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_net_POO.Models
{
    public class ContaCorrente
    {
        // Construtores
        public ContaCorrente(string numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        // Propriedades
        public string NumeroConta { get; set; }
        private decimal Saldo;


        // Métodos
        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Novo saldo: {Saldo:C}");
            }
        }
    }
}