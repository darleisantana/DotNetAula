using System;

namespace Revisao
{
    class Program
    {
        static async void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUsuario = obterOpcaoUsuario();

            while(opcaoUsuario.ToUpper != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        if(decimal.TryParse(Console.Readline(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal!");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                     break;

                    case "3":
                        //TODO: Calcula a media dos Alunos
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
            
                }

                opcaoUsuario = obterOpcaoUsuario();
            }
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção Desejada: ");
            Console.WriteLine("1 - Inserir novo Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular Media Geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}