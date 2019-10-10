using System;

namespace SENAIzinho {
    public class Sala {
        int capacidadeAtual;
        int capacidadeTotal;
        int numeroSala;
        string[] Alunos;

        //Construtores
        public Sala (int numeroSala, int capacidadeTotal) {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
            this.capacidadeAtual = this.capacidadeTotal;
            this.Alunos = new string[capacidadeTotal];
        }
        //Metodos

        public string AlocarAluno(string NomeAluno)
        {
            int index = 0;

            if(this.capacidadeAtual > 0)
            {
                foreach(string aluno in this.Alunos)
                {
                    if(aluno == "")
                    {
                        this.Alunos[index] = NomeAluno;
                        break;
                    }
                    index++;
                }
                this.capacidadeAtual--;
                return "ok";
            }else
            {
                return "LOTADO";    
            }
        }

        public string RemoverAluno(string nomeAluno)
        {
            int index = 0;

            if(this.capacidadeAtual == this.capacidadeTotal){
                return "SALAVAZIA";
            }

            foreach(string aluno in this.Alunos)
            {
                if(nomeAluno == aluno)
                {
                    this.Alunos[index] = "";
                    return "OK";
                }
                index++;
            }
            return "NAOENCONTRADO";
        }

        public String MostrarAlunos()
        {
            string listaAlunos = "";

            foreach(string aluno in this.Alunos)
            {
                if(aluno != "")
                {
                    listaAlunos = listaAlunos + aluno + " ";
                }
            }
            return listaAlunos;
        }

        #region Meus codigos
        // public string AlocarAluno (string nomeAluno) {
            
        //     System.Console.WriteLine ("Nome do Aluno a ser cadastrado na sala: ");
        //     nomeAluno = Console.ReadLine();
            
        //     int capacidadeAtual = 0;

        //     Alunos[capacidadeAtual] = nomeAluno;

        //     if (capacidadeAtual > 10) {
        //         System.Console.WriteLine ("Nao há vagas nessa sala!");
        //     } else {
        //         System.Console.WriteLine ("Nome do aluno cadastrado com sucesso!");
        //         capacidadeAtual = capacidadeAtual + 1 ;
        //     }
            
        // }
        

        

        // public string RemoverAluno (string removAluno) {
        //     System.Console.WriteLine ("Nome do aluno que você deseja retirar da sala: ");
        //     removAluno = Console.ReadLine ();
            
        //         foreach (string nomeAluno in Alunos) {
        //             if (nomeAluno == removAluno) {
        //                 System.Console.WriteLine ("Aluno foi removido com sucesso!");
        //             } else {
        //                 System.Console.WriteLine ("Nao encontramos o aluno no sistema");
        //             }
        //         }
        //     }
        #endregion 
        }
}

