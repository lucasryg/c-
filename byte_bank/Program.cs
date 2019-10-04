using System;
using byte_bank.Models;

namespace byte_bank {
    class Program {
        static void Main (string[] args) {
            #region Cadastro de cliente 
            System.Console.WriteLine ("ByteBank - Cadastro de clientes");
            System.Console.WriteLine ("Nome: ");
            string nome = Console.ReadLine ();
            System.Console.WriteLine ("Cpf: ");
            string cpf = Console.ReadLine ();
            System.Console.WriteLine ("Email: ");
            string email = Console.ReadLine ();


            Cliente cliente1 = new Cliente (nome, cpf, email);

            bool trocouSenha = false;

            do {
                System.Console.WriteLine ("Senha: ");
                string senha = Console.ReadLine ();
                trocouSenha = cliente1.TrocaSenha (senha);
                if (trocouSenha) {
                    System.Console.WriteLine ("Senha alterada com sucesso!");
                } else {
                    System.Console.WriteLine ("Senha invalida");
                }
            } while (!trocouSenha);
            System.Console.WriteLine ();
            #endregion
            //Conta corrente
            
            System.Console.WriteLine ("ByteBank - Conta Corrente");
            System.Console.WriteLine ("Agencia: ");
            int agencia = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Número da conta: ");
            int numero = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Nome do titular: ");
            string titular = Console.ReadLine ();

            ContaCorrente contaCorrente1 = new ContaCorrente (agencia, numero, titular);

            double saldo;
            do {
                System.Console.WriteLine ("Digite seu saldo: ");
                saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    contaCorrente1.Saldo = saldo;
                    System.Console.WriteLine ("Parabens, conta corrente criada!");
                } else {
                    System.Console.WriteLine ("Seu saldo precisa ser maior que 0");
                }
            } while (saldo < 0);
            System.Console.WriteLine();

            Cliente cliente2 = new Cliente("Lusca","123.123.123-00","abc@gmail.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(1231,123321,cliente2);

            #region Depósito.
            Cliente usuario = contaCorrente1.Titular;
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Bem vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Depísito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente1.deposito(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            #endregion

            #region Transferência.
            Cliente usuario = contaCorrente1.Titular;
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Bem vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Depísito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente1.deposito(valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            #endregionsss

        }
    }
}