using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1b
{
    class Program
    {
        static void Main(string[] args)
        {
           Pessoa aluno = new Pessoa();
           Pessoa professor = new Pessoa();
           aluno.nome = "stivem";
           professor.nome = "prof.jeferson";

           Console.WriteLine(aluno.nome);
           Console.WriteLine(professor.nome);

            Console.ReadKey();

            
        }
    }
}
