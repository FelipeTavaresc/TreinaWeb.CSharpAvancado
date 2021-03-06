﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class frmGerenciadorLatidosCachorros : Form
    {
        private GerenciadorLatidos _gerenciadorLatidos;

        public frmGerenciadorLatidosCachorros()
        {
            InitializeComponent();
            _gerenciadorLatidos = new GerenciadorLatidos();
            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) =>
            {
                ExcessoDecibeisEventArgs eventArgs = (ExcessoDecibeisEventArgs)args;
                MessageBox.Show(string.Format("O animal passou dos limites, com {0} decibéis. ", eventArgs.IntensidadeLatido), "Excesso de decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) => 
            {
                MessageBox.Show("Você receberá uma multa", "Excesso de decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }

        private void frmGerenciadorLatidosCachorros_Load(object sender, EventArgs e)
        {
            pgbIntensidadeLatido.Value = 0;
        }

        private void btnLatir_Click(object sender, EventArgs e)
        {
            pgbIntensidadeLatido.Value = _gerenciadorLatidos.Latir(); 
        }
        
    }
}
