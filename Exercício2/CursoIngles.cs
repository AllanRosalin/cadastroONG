using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    internal class CursoIngles : Curso
    {
        public override string[] Modalidade { get; set; } = { "Kids", "Intensivo para adultos" };

        public override void Info()
        {
            Console.WriteLine($"Curso: {Nome}");
            Console.WriteLine($"DuracaoCurso: {DuracaoCurso}");
            Console.WriteLine($"Professor: {Professor}");
            Console.WriteLine($"QtdaAlunos: {QtdeAlunos}");
            Console.WriteLine($"Descricao: {Descricao}");
        }

        public CursoIngles() : base() // Herda do construtor da classe pai
        {
            
        }
    }
}
