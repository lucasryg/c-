using System.Collections.Generic;
using System.IO;

namespace RoleTopMVC.Repositories
{
    public class TiposDeEventoRepository
    {
        public const string PATH = "Database/TiposDeEvento.csv";

        public TiposDeEventoRepository (){
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close();
            }
        }

        public List<string> ObterTodos () {

            List<string> tiposdeEvento = new List<string> ();

            var dados = File.ReadAllLines (PATH);

            foreach (var item in dados) {
                tiposdeEvento.Add (item);
            }
            return tiposdeEvento;
        }
    }
}