using System;

namespace Aluno
{
    public class Aluno
    {
        // Propriedades
        public string Nome{get;set;}
        public string Cpf{get;set;}
        public string Curso{get;set;}
        public int[] Notas;

        //Construtor
        public Aluno(string Nome, string Cpf, string Curso){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Curso = Curso;
        }

        //Metedos de Acessos
        public int[] getNotas(){return Notas;}
        public void setNotas(int bi, int nota){
            int i = bi - 1;
            if((i < 0) || (i > 3)){
                //Condição de Erro;
                throw new ArgumentOutOfRangeException($"{nameof(value)} mus");
            }
        }
    }
}