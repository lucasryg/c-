using System;

namespace byte_bank.Models {
    public class ContaCorrente {
        public ContaCorrente (string _Titular, int _Agencia, int _Numero, double _Saldo) {
            this._Titular = _Titular;
            this._Agencia = _Agencia;
            this._Numero = _Numero;
            this._Saldo = _Saldo;

        }
        public string _Titular { get; set; }
        public int _Agencia { get; set; }
        public int _Numero { get; set; }
        private double _Saldo { get; set; }

        public double Saldo {
            get { return _Saldo; }
        }

        //Construtor
        public ContaCorrente (int Agencia, int Numero, string Titular) {
            this._Agencia = Agencia;
            this._Numero = Numero;
            this._Titular = Titular;
            this._Saldo = 0.0;
        }

        public double deposito (double valor) {
            if (valor < 0) {
                System.Console.WriteLine ("O seu deposito precisa ser maior que ZERO.");
            } else {
                return this._Saldo += valor;
            }
        }
        public bool saque (double valor) {
            if (valor >= 0) {

                if (this._Saldo >= valor) {
                    this._Saldo = Saldo - valor;
                    return true;
                } else {
                    return false;
                }
            }
            return false;
        }

        public bool transferencia (ContaCorrente contaDestino, double valor) {
            if (this.saque (valor)) {
                contaDestino.deposito (valor);
                return true;
            } else {
                return false;
            }
        }
    }
}