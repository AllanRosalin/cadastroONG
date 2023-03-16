using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

            Console.Write("Digite o curso que vc quer: ");
            Console.Write("1-Inglês, 2-Espanhol, 3-Italiano, 4-Mandarim, 5-Japonês");
            int curso = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de alunos: ");
            int QtdeAlunos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a duração do curso: ");
            string DuracaoCurso = Console.ReadLine();

            Console.WriteLine("Digite a descrição do curso: ");
            string Descricao = Console.ReadLine();

            Console.WriteLine("Digite o nome do professor: ");
            string Professor = Console.ReadLine();

            string ModalidadeEscolhida();

            switch(curso)
        }
    }
}
