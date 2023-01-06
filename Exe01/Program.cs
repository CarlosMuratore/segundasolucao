namespace Exe01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //quero cadastrar 2 alunos e suas 2 notas
            //quero calcular a média das notas
            //se média maior que 6 aprovado senão reprovado

            string aluno1 = "Michael";
            string aluno2 = "Andrea";

            double Aluno1Nota1 = 6;
            double Aluno1Nota2 = 7.5;
            double Aluno2Nota1 = 5.5;
            double Aluno2Nota2 = 6.5;

            double mediaAluno1 = (Aluno1Nota1 + Aluno1Nota2) / 2;
            double mediaAluno2 = (Aluno2Nota1 + Aluno2Nota2) / 2;

            double media = 6;

            if ( mediaAluno1 > media)
            {
                Console.WriteLine($"{aluno1} aprovado");
            }
            else
            {
                Console.WriteLine($"{aluno1} reprovado");
            }
            if (mediaAluno2 > media)
            {
                Console.WriteLine($"{aluno2} aprovado");
            }
            else
            {
                Console.WriteLine($"{aluno2} reprovado");
            }
        }
    }
}