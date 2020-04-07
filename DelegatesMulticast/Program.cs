using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMulticast
{
    class Program
    {
        delegate void VerificacaoIdade(int idade);
        static VerificacaoIdade verificadorIdade;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu sexo: ");
            string sexoUsuario = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idadeUsuario = Convert.ToInt32(Console.ReadLine());

            if (sexoUsuario.Equals("H"))
            {
                verificadorIdade = new VerificacaoIdade(VerificaIdadeHomem);
                verificadorIdade += VerificaCarregamentoPesoHomem;
            }
            else
            {
                verificadorIdade = new VerificacaoIdade(VerificaIdadeMulher);
                verificadorIdade += VerificaCarregamentoPesoMulher;
            }
            verificadorIdade(idadeUsuario);
            Console.ReadKey();
        }

        static void VerificaIdadeHomem(int idade)
        {
            if (idade < 21)
                Console.WriteLine("Você ainda está crescendo");
            else
                Console.WriteLine("Você já cresceu");
        }

        static void VerificaCarregamentoPesoHomem(int idade)
        {
            if (idade > 25)
                Console.WriteLine("Você pode carregar bastante peso");
            else
                Console.WriteLine("Você não pode carregar tanto peso");
        }

        static void VerificaIdadeMulher(int idade)
        {
            if (idade < 18)
                Console.WriteLine("Você ainda está crescendo");
            else
                Console.WriteLine("Você já cresceu");
        }

        static void VerificaCarregamentoPesoMulher(int idade)
        {
            if (idade > 30)
                Console.WriteLine("Você pode carregar bastante peso");
            else
                Console.WriteLine("Você não pode carregar tanto peso");
        }
    }
}
