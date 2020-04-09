using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesFuncAction
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Func<int, int, int> calculo = p.Somar;
            Action<int> impressao = p.ImprimirResultado;
            impressao(calculo(1, 1));
            Console.ReadKey();
        }

        void ImprimirResultado(int resultado)
        {
            Console.WriteLine(resultado);
        }

        int Somar(int a, int b)
        {
            return a + b;
        }
    }
}
