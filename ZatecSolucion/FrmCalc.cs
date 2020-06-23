using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ZatecSolucion
{
    
    public partial class FrmCalc : Form
    {
        string operador="";
        double valor = 0;
        bool operador_press = false;
        public FrmCalc()
        {
            InitializeComponent();
        }
        private void btn_Numerador_Click(object sender, EventArgs e)
        {
            if ((txt_Resultado.Text=="0")|| (operador_press))
                txt_Resultado.Text = "";

            operador_press = false;
            Button bt = (Button)sender;
            if (bt.Text==",")
            {
                if(!txt_Resultado.Text.Contains(","))
                    txt_Resultado.Text = txt_Resultado.Text + bt.Text;
            }
            else
            {
                txt_Resultado.Text = txt_Resultado.Text + bt.Text;
            }

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "0";
        }

        private void Operador_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operador = b.Text;
            valor = double.Parse(txt_Resultado.Text);
            operador_press = true;
            lb_equacao.Text = valor + " " + operador;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            lb_equacao.Text = "";
            switch (operador)
            {
                case "+":
                    txt_Resultado.Text=(valor + double.Parse(txt_Resultado.Text)).ToString();
                    break;
                case "-":
                    txt_Resultado.Text = (valor - double.Parse(txt_Resultado.Text)).ToString();
                    break;
                case "*":
                    txt_Resultado.Text = (valor * double.Parse(txt_Resultado.Text)).ToString();
                    break;
                case "/":
                    txt_Resultado.Text = (valor / double.Parse(txt_Resultado.Text)).ToString();
                    break;
                default:
                    break;

            }//end switch
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "";
            valor = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
