using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crediaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cour = false;
            while (!cour)
            {
                Console.WriteLine();
                Console.WriteLine("Qual curso gostaria de ver?");
                Console.WriteLine("1-Inglês, 2-Espanhol, 3- Italiano, 4- Mandarim, 5- Japonês, 6-Encerrar");
                string bools = Console.ReadLine();
                int bos = int.Parse(bools);
                switch (bos)
                {
                    case 1:
                        Ingles English = new Ingles();
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
                        English.constroi(Descricao, DuracaoCurso, Professor, QtdeAlunos, va);
                        English.Info();

                        break;
                    case 2:
                        Espanhol Spanish = new Espanhol();
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
                        Spanish.constroi(Descricao, DuracaoCurso, Professor, QtdeAlunos, va);
                        Spanish.Info();

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

                    default:
                        Console.WriteLine("Nenhuma Opção escolhida");
                        break;
                }

            }
            Console.WriteLine("Leitura de cursos concluida");
            Console.ReadKey();
        }
    }
}
