using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class GerenciadorLatidos
    {
        private int _intesidadeLatido;
        public event EventHandler ExcessoDecibeisEvent;

        public GerenciadorLatidos()
        {
            _intesidadeLatido = 0;
        }

        public int Latir()
        {
            _intesidadeLatido += 10;
            if (_intesidadeLatido > 80)
            {
                ExcessoDecibeisEventArgs e = new ExcessoDecibeisEventArgs
                {
                    IntensidadeLatido = _intesidadeLatido
                };
                OnExcessoDecibeis(e);
            }
            return _intesidadeLatido;
        }

        protected virtual void OnExcessoDecibeis(EventArgs e)
        {
            if (ExcessoDecibeisEvent != null)
            {
                ExcessoDecibeisEvent(this, e); 
            }
        }
    }
}
