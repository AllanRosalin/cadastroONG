using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    internal abstract class Curso
    {
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string Professor { get; set; }
        public virtual string DuracaoCurso { get; set; }
        public virtual int QtdeAlunos { get; set; }
        public virtual string[] Modalidade { get; set; }

        public abstract void Info();

        public Curso()
        {
        }
    }
}


