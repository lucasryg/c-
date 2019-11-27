using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories {
    public class HamburguerRepository {
        private const string PATH = "Database/Hamburguer.csv";

        public double ObterPrecoDe(string nomeHamburguer)
        {

            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeHamburguer))
                {
                    preco = item.preco;
                    break;

                }
            }

            return preco;
        }
        public List<Hamburguer> ObterTodos () {
            List<Hamburguer> hamburgueres = new List<Hamburguer>();
            string[] linhas = File.ReadAllLines (PATH);
            foreach (var linha in linhas)
            {
                Hamburguer h = new Hamburguer();
                 string[] dados = linha.Split(";"); //! Split: Quebra as linhas quando vê um ponto e virgula como mostra no caso do parametro
                 h.Nome = dados[0];
                 h.preco = double.Parse(dados[1]);
                hamburgueres.Add(h);


            }
            return hamburgueres;

        }
    }
}