using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroONG
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Animal animal = new Animal();

                Console.WriteLine("Digite o tipo do animal: ");
                animal.Tipo = Console.ReadLine();

                Console.WriteLine("Digite a espécie do animal: ");
                animal.Especie = Console.ReadLine();

                Console.WriteLine("Digite a idade do animal: ");
                animal.Idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a cor do animal: ");
                animal.Cor = Console.ReadLine();

            Console.WriteLine("Há ferimentos? 1 - SIM 2 - NÃO");
            int f = Convert.ToInt32(Console.ReadLine());

            bool ferimentos = f == 1 ? true : false;
            animal.Ferimentos = ferimentos;
            
            /*bool ferimentos;
            if(f == 1)
            {
                ferimentos = true;
            }
            else
            {
                ferimentos = false;
            }*/

            animal.Info();

            Console.ReadKey();
        }
    }
}
