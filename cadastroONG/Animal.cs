using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroONG
{
    internal class Animal
    {
        public string Tipo { get; set; }
        public string Especie { get; set; }
        public string Cor { get; set; }
        public int Idade { get; set; }
        public bool Ferimentos { get; set; }

        public void Info()
        {
            Console.WriteLine("Info do animal: ");
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Espécie: " + Especie);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Ferimentos: " + Ferimentos);
        }
    }
}
