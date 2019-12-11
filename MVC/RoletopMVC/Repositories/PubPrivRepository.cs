using System.Collections.Generic;
using System.IO;

namespace RoletopMVC.Repositories
{
    public class PubPrivRepository
    {
        public const string PATH = "Database/PublicoPrivado.csv";

        public PubPrivRepository (){
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close();
            }
        }

        public List<string> ObterTodos () {

            List<string> TipoDeEvento = new List<string> ();

            var dados = File.ReadAllLines (PATH);

            foreach (var item in dados) {
                TipoDeEvento.Add (item);
            }
            return TipoDeEvento;
        }
    }
}