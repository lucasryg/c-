using System;

namespace byte_bank.Models
{
    public class ContaCorrente
    {
        public string Titular;
        public int Agencia;
        public int Numero;
        public double Saldo;

        //Construtor
        public ContaCorrente(int Agencia, int Numero, string Titular, int Saldo){   
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0;
        }


    }
}