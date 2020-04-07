using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesGenericos
{
    class Program
    {
        delegate T CalculoMatematico<T>(T a, T b);
        static void Main(string[] args)
        {
            Program p = new Program();
            CalculoMatematico<int> calculo = new CalculoMatematico<int>(p.Somar);
            Console.WriteLine(calculo(1, 1));
            ExibirInformacoesDelegate(calculo);
            Console.ReadKey();
        }

        private static void ExibirInformacoesDelegate<T>(CalculoMatematico<T> calculo)
        {
            Console.WriteLine(calculo.Target);
            Console.WriteLine(calculo.Method);
        }

        int Somar(int a, int b)
        {
            return a + b;
        }

        decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
