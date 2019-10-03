using System;
using byte_bank.Models;

namespace byte_bank {
    class Program {
        static void Main (string[] args) {
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

            //Conta corrente

            System.Console.WriteLine ("ByteBank - Conta Corrente");
            System.Console.WriteLine ("Agencia: ");
            int agencia = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Número da conta: ");
            int numero = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Nome do titular: ");
            string titular = Console.ReadLine ();

            ContaCorrente contacorrente1 = new ContaCorrente (agencia, numero, titular, saldo);

            bool saldoNegativo = false;
            do {
                System.Console.WriteLine("Digite seu saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if(saldo > 0){
                    System.Console.WriteLine("Parabens, conta corrente criada!");
                }else{
                    System.Console.WriteLine("Seu saldo precisa ser maior que 0");
                }
        }while(!saldoNegativo);

    }
    // public static ContaCorrente TodasContas(){
    //         ContaCorrente = new ContaCorrente();
    //         System.Console.WriteLine ("ByteBank - Conta Corrente");
    //         System.Console.WriteLine ("Agencia: ");
    //         int agencia = int.Parse (Console.ReadLine ());
    //         System.Console.WriteLine ("Número da conta: ");
    //         int numero = int.Parse (Console.ReadLine ());
    //         System.Console.WriteLine ("Nome do titular: ");
    //         string titular = Console.ReadLine ();
    // }
    }
}