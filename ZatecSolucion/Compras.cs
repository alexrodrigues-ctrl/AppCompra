using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ZatecSolucion
{
    public partial class Compras : Form 
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }
        //metod
        private void AdicionaValorCaixa()
        {
            lb_ValorCaixa.Text = txt_AdicionaCaixa.Text;
            lb_SaldoRestante.Text = lb_ValorCaixa.Text;
            txt_AdicionaCaixa.Clear();
            txt_AdicionaCaixa.Focus();
        }
        //messagem erro
        private void MessagemErro()
        {
            MessageBox.Show("Erro!!");
        }
        //messagem OK
        private void MessagemOk()
        {
            MessageBox.Show("Sucesso!!");
        }

        private void btn_AdicionarCaixa_Click(object sender, EventArgs e)
        {
            AdicionaValorCaixa();
            MessagemOk();
            
        }

        private void btn_ValorItem_Click(object sender, EventArgs e)
        {
            //if (int.Parse(lb_SaldoRestante.Text) >= int.Parse(txt_ValorItem.Text) || int.Parse(txt_ValorItem.Text)< int.Parse(lb_SaldoRestante.Text) )
            Double v = Convert.ToDouble(lb_SaldoRestante.Text);
            Double v1 = Convert.ToDouble(txt_ValorItem.Text);
            if (v >=v1) 
            {
                if(v1 < v)
                //ok
                lb_UltimoItem.Text = Convert.ToString(txt_ValorItem.Text);

                //ok
                lb_SaldoRestante.Text = Convert.ToString(Convert.ToDecimal(lb_SaldoRestante.Text) - Convert.ToDecimal(txt_ValorItem.Text));
                lb_TotalComprado.Text = Convert.ToString(Convert.ToDecimal(lb_ValorCaixa.Text) - Convert.ToDecimal(lb_SaldoRestante.Text));
                txt_ValorItem.Clear();
                txt_ValorItem.Focus();
            }
            else
            {
                MessagemErro();
            }           
            
        }

        private void txt_ValorItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ValorItem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_ExcluirCompra_Click(object sender, EventArgs e)
        {
            Double v = Convert.ToDouble(txt_ExcluirValor.Text);
            Double v1 = Convert.ToDouble(lb_TotalComprado.Text);
            Double s = Convert.ToDouble(lb_SaldoRestante.Text);
            Double s1 = Convert.ToDouble(lb_ValorCaixa.Text);

            //(int.Parse(txt_ExcluirValor.Text) <= int.Parse(lb_TotalComprado.Text))
            if (v <= v1)
            {
                //(int.Parse(lb_SaldoRestante.Text) <= int.Parse(lb_ValorCaixa.Text))
                if (s <= s1)
                {
                    lb_SaldoRestante.Text = Convert.ToString(Convert.ToDecimal(lb_SaldoRestante.Text) + Convert.ToDecimal(txt_ExcluirValor.Text));
                    lb_TotalComprado.Text = Convert.ToString(Convert.ToDecimal(lb_TotalComprado.Text) - Convert.ToDecimal(txt_ExcluirValor.Text));
                    MessagemOk();
                    txt_ExcluirValor.Clear();
                    txt_ExcluirValor.Focus();
                }
               
            }
            else
            {
                MessagemErro();

            }


        }

        private void btn_AdicionarValor_Click(object sender, EventArgs e)
        {
            lb_ValorCaixa.Text = Convert.ToString(Convert.ToDouble(txt_AdicionarValor.Text)+Convert.ToDouble(lb_ValorCaixa.Text));
            lb_SaldoRestante.Text = Convert.ToString(Convert.ToDouble(txt_AdicionarValor.Text) + Convert.ToDouble(lb_SaldoRestante.Text));
            txt_AdicionarValor.Clear();
            txt_AdicionarValor.Focus();

        }
    }
}
