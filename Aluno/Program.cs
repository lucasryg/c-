using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Lucas","123.456.789.11","Dev");
            Console.WriteLine("Nome: " + aluno1.Nome);
            Console.WriteLine("Cpf: " + aluno1.Cpf);
            Console.WriteLine("Curso: " + aluno1.Curso);

            Aluno aluno2 = new Aluno("Joao","543.213.532.33","Dev");
            Console.WriteLine("Nome: " + aluno2.Nome);
            Console.WriteLine("Cpf: " + aluno2.Cpf);
            Console.WriteLine("Curso: " + aluno2.Curso);

            Console.Write("Entre com o nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Entre com o CPF: ");
            string Cpf = Console.ReadLine();
            Console.Write("Entre com o Curso: ");
            string Curso = Console.ReadLine();
            Console.WriteLine("Entre com a Notas: ");
            double Notas = double.Parse(Console.ReadLine());
            int nota = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com p bimestre: ");
            int bimestres = int.Parse(Console.ReadLine());

            Aluno aluno3 = new Aluno(Nome,Cpf,Curso);
            aluno3.setNotas(bimestres,nota);

            Console.WriteLine("Nome: " + aluno3.Nome);
            Console.WriteLine("Cpf: " + aluno3.Cpf);
            Console.WriteLine("Curso: " + aluno3.Curso);
            Console.WriteLine("Notas: ");

            foreach(int nba in aluno3.getNotas()){
                // Console.Write( nba = " "); //Dando erro sem erro
            }
            Console.WriteLine();


            
            
        }
    }
}
