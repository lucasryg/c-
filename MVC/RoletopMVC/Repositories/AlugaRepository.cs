using System;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class AlugaRepository : RepositoryBase
    {
        private const string PATH = "Database/Aluga.csv";

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


        //! Refazer tudo do PedidoRepository
        private string PrepararRegistroCSV(Aluga aluga)
        {
            return $"nome={aluga.Cliente.Nome};email={aluga.Cliente.Email};cpf={aluga.Cliente.Cpf};telefone={aluga.Cliente.Telefone};dataEhora={aluga.Cliente.DataNascimento};";      
        }
    }
}
