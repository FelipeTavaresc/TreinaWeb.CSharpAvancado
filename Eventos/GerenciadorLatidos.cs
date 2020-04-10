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
        public delegate void ExcessoDecibeisHandler(object sender, EventArgs e);
        public event ExcessoDecibeisHandler ExcessoDecibeisEvent;

        public GerenciadorLatidos()
        {
            _intesidadeLatido = 0;
        }

        public int Latir()
        {
            _intesidadeLatido += 10;
            if (_intesidadeLatido > 80)
            {
                OnExcessoDecibeis(new EventArgs());
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
