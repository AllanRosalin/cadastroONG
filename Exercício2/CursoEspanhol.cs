using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    internal class CursoEspanhol : Curso
    {
        public override string[] Modalidade { get; set; } = { "Básico", "Espanhol para estudantes", "Normal" };

        public override void Info()
        {
            Console.WriteLine($"Curso: {Nome}");
            Console.WriteLine($"DuracaoCurso: {DuracaoCurso}");
            Console.WriteLine($"Professor: {Professor}");
            Console.WriteLine($"QtdaAlunos: {QtdeAlunos}");
            Console.WriteLine($"Descricao: {Descricao}");
        }

        public CursoEspanhol() : base()
        {

        }
    }
}
