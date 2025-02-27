﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBankingDV.Front
{
    public partial class Depositar : Form
    {
        public DelegadoHommeStart delegadoHommeStart;
        
        private int elCBU;
        private int monto;
        
        private Banco elBanco;

        public Depositar(Banco _elBanco, int _elCBU)
        {
            elBanco = _elBanco;
            elCBU = _elCBU;
            InitializeComponent();
        }

        private void Depositar_Load(object sender, EventArgs e)
        {
            textCbuDestino.Text = elCBU.ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            elBanco.DepositarDinero(monto, elCBU);
        }

        private void textCuentaOrigen_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMonto_TextChanged(object sender, EventArgs e)
        {
            monto = Int32.Parse(textMonto.Text);
        }

        private void textCbuDestino_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
