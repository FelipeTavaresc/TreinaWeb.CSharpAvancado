using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type what you want to invert: ");
            string phrase = Console.ReadLine();
            Console.WriteLine("Your new phase is {0} ", phrase.InverterCaixas(false));
            Console.ReadKey();
        }
    }
}
