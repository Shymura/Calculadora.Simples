using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadorasimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var n1 = Decimal.Parse(txt1.Text);
            var n2 = Decimal.Parse(txt2.Text);
            var soma = n1 + n2;
            var subtracao = n1 - n2;
            var divisao = n1 / n2;
            var multiplicacao = n1 * n2;

            lblSoma.Text = "SOMA = " + soma;
            lblSubtracao.Text = "SUBTRAÇÃO = " + subtracao;
            lblDivisao.Text = "DIVISÃO = " + divisao;
            lblMultiplicacao.Text = "MULTIPLICAÇÃO = " + multiplicacao;
        }
    }
}
