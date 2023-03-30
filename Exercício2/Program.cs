using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crediaria
{
    internal class Program
    {
        public static object Nome { get; private set; }

        static void Main(string[] args)
        {
            Console.Write("Digite o curso que você deseja: ");
            Console.Write("1-Inglês, 2-Espanhol, 3-Italiano, 4-Mandarim, 5-Japonês: ");
            int curso = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 3:
                        Italiano Italian = new Italiano();
                        Console.WriteLine();
                        Console.WriteLine("Descrição: ");
                        string Descricao = Console.ReadLine();
                        Console.WriteLine("Duração: ");
                        string DuracaoCurso = Console.ReadLine();
                        Console.WriteLine("Professor: ");
                        string Professor = Console.ReadLine();
                        Console.WriteLine("Quantidade de Alunos: ");
                        int QtdeAlunos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Modalidade: ");
                        string Modalidade = Console.ReadLine();
                        Italian.constroi(Descricao, DuracaoCurso, Professor, QtdeAlunos, va);
                        Italian.Info();
                        break;
                    case 4:
                        Japao Japan = new Japao();
                        Console.WriteLine();
                        Console.WriteLine("Descrição: ");
                        string Descricao = Console.ReadLine();
                        Console.WriteLine("Duração: ");
                        string DuracaoCurso = Console.ReadLine();
                        Console.WriteLine("Professor: ");
                        string Professor = Console.ReadLine();
                        Console.WriteLine("Quantidade de Alunos: ");
                        int QtdeAlunos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Modalidade: ");
                        string Modalidade = Console.ReadLine();
                        Japan.constroi(Descricao, DuracaoCurso, Professor, QtdeAlunos, va);
                        Japan.Info();
                        break;

                    case 5:
                        Mandarim Mandariam = new Mandarim();
                        Console.WriteLine();
                        Console.WriteLine("Descrição: ");
                        string Descricao = Console.ReadLine();
                        Console.WriteLine("Duração: ");
                        string DuracaoCurso = Console.ReadLine();
                        Console.WriteLine("Professor: ");
                        string Professor = Console.ReadLine();
                        Console.WriteLine("Quantidade de Alunos: ");
                        int QtdeAlunos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Modalidade: ");
                        string Modalidade = Console.ReadLine();
                        Mandariam.constroi(Descricao, DuracaoCurso, Professor, QtdeAlunos, va);
                        Mandariam.Info();
                        break;

                    case 6:
                        cur = true;
                        break;

            int modalidade;

            switch (curso)
            {
                case 1:
                    Console.WriteLine("Digite a modalidade do curso: 1 - Kids, 2 - Itensivo para adultos");
                    modalidade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\nInformações:\n");
                    CursoIngles cursoIngles = new CursoIngles()
                    {
                        Nome = "Inglês",
                        Descricao = Descricao,
                        Professor = Professor,
                        QtdeAlunos = QtdeAlunos,
                        DuracaoCurso = DuracaoCurso
                    };

                    cursoIngles.Info(modalidade);
                    break;

                case 2:
                    Console.WriteLine("Digite a modalidade do curso: 1 - Básico, 2 - Espanhol para estudantes, 3 - Normal");
                    modalidade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\nInformações:\n");
                    CursoEspanhol cursoEspanhol = new CursoEspanhol()
                    {
                        Nome = "Espanhol",
                        Descricao = Descricao,
                        Professor = Professor,
                        QtdeAlunos = QtdeAlunos,
                        DuracaoCurso = DuracaoCurso
                    };

                    cursoEspanhol.Info(modalidade);
                    break;

                case 3:
                    Console.WriteLine("Digite a modalidade do curso: 1 - Básico, 2 - Intermediário, 3 - Avançado");
                    modalidade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\nInformações:\n");
                    CursoItaliano cursoItaliano = new CursoItaliano()
                    {
                        Nome = "Italiano",
                        Descricao = Descricao,
                        Professor = Professor,
                        QtdeAlunos = QtdeAlunos,
                        DuracaoCurso = DuracaoCurso
                    };

                    cursoItaliano.Info(modalidade);
                    break;

                case 4:
                    Console.WriteLine("Digite a modalidade do curso: 1 - Completo");
                    modalidade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\nInformações:\n");
                    CursoMandarim cursoMandarim = new CursoMandarim()
                    {
                        Nome = "Mandarim",
                        Descricao = Descricao,
                        Professor = Professor,
                        QtdeAlunos = QtdeAlunos,
                        DuracaoCurso = DuracaoCurso
                    };

                    cursoMandarim.Info(modalidade);
                    break;

                case 5:
                    Console.WriteLine("Digite a modalidade do curso: 1 - Completo");
                    modalidade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\nInformações:\n");
                    CursoJapones cursoJapones = new CursoJapones()
                    {
                        Nome = "Japones",
                        Descricao = Descricao,
                        Professor = Professor,
                        QtdeAlunos = QtdeAlunos,
                        DuracaoCurso = DuracaoCurso
                    };

                    cursoJapones.Info(modalidade);
                    break;
            }

            Console.ReadKey();
        }
    }
}
