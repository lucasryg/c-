using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class AlugaRepository : RepositoryBase
    {
        private const string PATH = "Database/DadosParaAlugar.csv";

        public AlugaRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Aluga aluga)
        {
            var linha = new string[] { PrepararRegistroCSV(aluga) };
            File.AppendAllLines(PATH, linha);

            return true;            
        }

        public List<Aluga> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Aluga> alugas = new List<Aluga>();

            foreach (var item in linhas)
            {
                    Aluga aluga = new Aluga();
                    aluga.Cliente.Nome = ExtrairValorDoCampo("Nome" , item);
                    aluga.Cliente.Email = ExtrairValorDoCampo("Email", item);
                    aluga.Cliente.Cpf = ExtrairValorDoCampo("CpfCnpj", item);
                    aluga.Cliente.Telefone = ExtrairValorDoCampo("Telefone", item);
                    aluga.Cliente.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("dataEhora" , item));
                    
                    alugas.Add(aluga);
                            
            }
            return alugas;
        }
        //! Refazer tudo do PedidoRepository
        private string PrepararRegistroCSV(Aluga aluga)
        {
            return $"id={aluga.Id};nome={aluga.Cliente.Nome};email={aluga.Cliente.Email};CpfCnpj={aluga.Cliente.Cpf};telefone={aluga.Cliente.Telefone};dataEhora={aluga.Cliente.DataNascimento};";      
        }

        public Aluga ObterPor(ulong id)
        {
            var alugueisTotais = ObterTodos();
            foreach (var item in alugueisTotais)
            {
                if (id.Equals(item.Id))
                {
                    return item;
                }
            }
            return null;
        }

        public bool Atualizar(Aluga aluga)
        {
            var alugueisTotais = File.ReadAllLines(PATH);
            var alugaCSV = PrepararRegistroCSV(aluga);
            var linhaPedido = -1;
            var resultado = false;
            
            for (int i = 0; i < alugueisTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", alugueisTotais[i]));
                if(aluga.Id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                alugueisTotais[linhaPedido] = alugaCSV;
                File.WriteAllLines(PATH, alugueisTotais);
            }

            return resultado;
        }

        public List<Aluga> ObterTodosPorCliente (string emailCliente) {
            List<Aluga> alugas = new List<Aluga> ();
            foreach (var aluga in ObterTodos ()) {
                if (aluga.Cliente.Email.Equals (emailCliente)) {
                    alugas.Add (aluga);
                }
            }
            return alugas;
        }


    }
}
