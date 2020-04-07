﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianciaContravariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            ManipuladorFTP<Nivel2> ftp = new ManipuladorFTP<Nivel2>();

            IArmazenador<Nivel3> armazenador = ftp;
            armazenador.Armazenar(new Nivel3());

            IRecuperador<Nivel1> recuperador = ftp;
            Console.WriteLine(recuperador.Recuperar(0));

            Console.ReadKey();
        }
    }
}