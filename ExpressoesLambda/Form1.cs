using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressoesLambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            Func<string, string, string> concatenador = (s1, s2) => { return s1 +  " " + s2; };
            Action<string> escritor = (s1) =>
            {
                txbResultado.Text = s1;
            };
            escritor(concatenador(txbTexto1.Text, txbTexto2.Text));
        }
    }
}
