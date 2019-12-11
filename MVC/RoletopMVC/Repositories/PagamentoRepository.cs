using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;

namespace RoletopMVC.Repositories
{
    public class PagamentoRepository : RepositoryBase
    {
        private const string PATH = "Database/Aluga.csv";

        public PagamentoRepository()
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
                    aluga.TipoEvento = ExtrairValorDoCampo("tipoEvento" , item);
                    aluga.Publico = ExtrairValorDoCampo("PubPrib" , item);
                    aluga.Iluminacao = ExtrairValorDoCampo("ilumincao" , item);
                    aluga.Som = ExtrairValorDoCampo("som" , item);
                    aluga.FormaPagamento = ExtrairValorDoCampo("formaDePagamento" , item);
                    aluga.NumeroCartao = ExtrairValorDoCampo("numero" , item);
                    aluga.NomeCartao = ExtrairValorDoCampo("nome" , item);
                aluga.DataVencimento = ExtrairValorDoCampo("vencimento" , item);
                    aluga.CVV = ExtrairValorDoCampo("CVV" , item);

                    alugas.Add(aluga);
                            
            }
            return alugas;
        }



        private string PrepararRegistroCSV(Aluga aluga)
        {
            return $"tipoEvento={aluga.TipoEvento};PubPriv={aluga.Publico};iluminacao={aluga.Iluminacao};som={aluga.Som};formaDePagamento={aluga.FormaPagamento};numero={aluga.NumeroCartao};nome={aluga.NomeCartao};vencimento={aluga.DataVencimento};CVV={aluga.CVV}";
        


    }
}
}