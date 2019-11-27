using System.Collections.Generic;
using McBonaldsMVC.Models;
using System.IO;
namespace McBonaldsMVC.Repositories
{
    public class ShakeRepository
    {
        private const string PATH = "Database/Shake.csv";
 public double ObterPrecoDe(string nomeShake)
        {

            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeShake))
                {
                    preco = item.preco;
                    break;

                }
            }

            return preco;
        }
    public List <Shake> ObterTodos()
    {
        List<Shake> shakes = new List<Shake>();
        var linhas = File.ReadAllLines(PATH);
        foreach(var linha in linhas)
        {
            Shake s = new Shake();
            string[] dados = linha.Split(";");
            s.Nome = dados[0];
            s.preco = double.Parse(dados[1]);
            shakes.Add(s);



        }
        return shakes;

    }
  }
}