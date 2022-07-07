using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura
{
    public class SaldoInsuficienteExcepition : Exception
    {

        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteExcepition() { }

        public SaldoInsuficienteExcepition(string mensagem)
            : base(mensagem)
        {

        }

        public SaldoInsuficienteExcepition(double saldo, double valorSaque) 
            : this($"Tentativa de saque do valor de {valorSaque} em uma conta com saldo {saldo}")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;  

        }

    }
}
