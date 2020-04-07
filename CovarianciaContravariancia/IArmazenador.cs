using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianciaContravariancia
{
    interface IArmazenador<in T>
    {
        void Armazenar(T item);
    }
}
