using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dio_net_POO.Interfaces;

namespace dio_net_POO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return a / b;
        }   
    }
}