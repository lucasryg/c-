namespace SENAIzinho {
    public class Sala {
        int capacidadeAtual { get; set; }
        int capacidadeTotal { get; set; }
        int numeroSala { get; set; }
        string[] Alunos { get; set; }

        //Cosntrutores
        public Sala (int numeroSala, int capacidadeTotal) {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
        }
        public string AlocarAluno (string Alunos) {
            this.Alunos = Alunos;
        }
        public string RemoverAluno (string Alunos) {
            this.Alunos = Alunos;
        }

        //Metodos

        public string AlocarAluno(string nomeAluno){
            System.Console.WriteLine("Nome do Aluno a ser cadastrado na sala: " );
            nomeAluno = Console.ReadLine();

            int capacidadeAtual = 0;

            Alunos[capacidadeAtual] = nomeAluno;

            if(capacidadeAtual > 10){
                System.Console.WriteLine("Nao há vagas nessa sala!");
            } else{
                System.Console.WriteLine("Nome do aluno cadastrado com sucesso!");
                capacidadeAtual++;
            }

        }

        public string RemoverAluno(string removAluno){
            System.Console.WriteLine("Nome do aluno que você deseja retirar da sala: ");
            removAluno = Console.ReadLine();
            for(Alunos[0];Aluno[99];Alunos++)
            
            foreach(string nomeAluno in Alunos){
            if(nomeAluno == removAluno){
                System.Console.WriteLine("Aluno foi removido com sucesso!");
            } else{
                System.Console.WriteLine("Nao encontramos o aluno no sistema");
            }
            }
        }
    }
}
