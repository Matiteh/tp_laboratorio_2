using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        bool flagResult = true;
        public FormCalculadora()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double Operar(string num1, string num2, string operador)
        {
            double result;
            Numero numero1 = new Numero(num1);
            Numero numero2 = new Numero(num2);
            result = Calculadora.operar(numero1, numero2, operador);
            return result;
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string result = "";
            result = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            lblResultado.Text = result;
            flagResult = true;
        }
        private void Limpiar()
        {
            txtNumero1.Text = "";
            cmbOperador.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "")
            {
                lblResultado.Text = "Valor Invalido";
            }
            else if (flagResult == true)
            {
                lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);

            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "")
            {
                lblResultado.Text = "Valor Invalido";
            }
            else if (flagResult == true)
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
