using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel.Design.Serialization;


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
            FrmApresentacao frmApresentacao = new FrmApresentacao();
            frmApresentacao.ShowDialog();
            lb_Nome.Text = frmApresentacao.txt_Apresentacao.Text;
            txt_AdicionaCaixa.Focus();
        }
        //metod
        public void AdicionaValorCaixa()
        {
            if (txt_AdicionaCaixa.Text !="" && txt_AdicionaCaixa.Text!=",")
            {
                lb_ValorCaixa.Text = txt_AdicionaCaixa.Text;
                lb_SaldoRestante.Text = lb_ValorCaixa.Text;
                lb_SaldoPositivo.Text = lb_SaldoRestante.Text;
                txt_AdicionaCaixa.Clear();
                txt_ValorItem.Focus();
                MessagemOk();
            }
            else
            {
                MessageBox.Show("Preencha o valor do Caixa !","Mercadinho União",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_AdicionaCaixa.Clear();
                txt_AdicionaCaixa.Focus();
            }
            
            //
            if (Convert.ToDouble(lb_ValorCaixa.Text) > 0)
            {
                panelItem.Enabled = true;
                panelAdicionar.Enabled = true;
            }
            //
            if (Convert.ToDouble(lb_SaldoRestante.Text) > 0)
            {
                panelCaixa.Enabled = false;
            }
            //painel saldo positivo:
            if (Convert.ToDouble(lb_SaldoRestante.Text) > 0)
            {
                panel_SaldoPositivo.Visible = true;
                panelItem.Enabled = true;
                panel_zerado.Visible = false;
                panelCaixa.Enabled = false;
                //lb_SaldoPositivo.Text =Convert.ToString(Convert.ToDouble( lb_SaldoRestante.Text));
            }
        }
        //metodo tratar TextBox
        private void TratarTextBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente uma virgula");
            }
        }
        //messagem erro
        private void MessagemErro()
        {
            MessageBox.Show("Valor do campo inválido.","Mercadinho União", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //messagem OK
        private void MessagemOk()
        {
            MessageBox.Show("Preenchido com Sucesso!!", "Mercadinho União", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_AdicionarCaixa_Click(object sender, EventArgs e)
        {
            AdicionaValorCaixa();
        }

        private void btn_ValorItem_Click(object sender, EventArgs e)
        {
            if (txt_ValorItem.Text != "" && txt_ValorItem.Text != ",")
            {
                //if (int.Parse(lb_SaldoRestante.Text) >= int.Parse(txt_ValorItem.Text) || int.Parse(txt_ValorItem.Text)< int.Parse(lb_SaldoRestante.Text) )
                Double v = Convert.ToDouble(lb_SaldoRestante.Text);
                Double v1 = Convert.ToDouble(txt_ValorItem.Text);
                if (v >= v1)
                {
                    if (v1 < v)
                        //ok
                        lb_UltimoItem.Text = Convert.ToString(txt_ValorItem.Text);

                    //ok
                    lb_SaldoRestante.Text = Convert.ToString(Convert.ToDouble(lb_SaldoRestante.Text) - Convert.ToDouble(txt_ValorItem.Text));
                    lb_TotalComprado.Text = Convert.ToString(Convert.ToDouble(lb_ValorCaixa.Text) - Convert.ToDouble(lb_SaldoRestante.Text));
                    lb_SaldoPositivo.Text = Convert.ToString(Convert.ToDouble(lb_SaldoRestante.Text));
                }
                else
                {
                    MessagemErro();
                }
                //
                //int saldo = (Convert.ToDouble(lb_ValorCaixa.Text)/2);
                if (Convert.ToDouble(lb_SaldoRestante.Text) <= Convert.ToDouble(lb_ValorCaixa.Text) / 2)
                {
                    lb_SaldoRestante.ForeColor = Color.Red;
                    if (Convert.ToDouble(lb_SaldoRestante.Text) <= (Convert.ToDouble(lb_ValorCaixa.Text) / 2))
                    {
                        lb_SaldoRestante.BackColor = Color.Black;
                    }
                }
                if (Convert.ToDouble(lb_SaldoRestante.Text) <= 0)
                {
                    panelItem.Enabled = false;
                    panel_zerado.Visible = true;
                    panelCaixa.Enabled = false;
                    panel_SaldoPositivo.Visible = false;
                }
                
            }
            else { MessagemErro(); }
            //
            txt_ValorItem.Clear();
            txt_ValorItem.Focus();
        }
        private void btn_ExcluirCompra_Click(object sender, EventArgs e)
        {
            if (txt_ExcluirValor.Text!="" && txt_ExcluirValor.Text != ",")
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
                        lb_SaldoRestante.Text = Convert.ToString(Convert.ToDouble(lb_SaldoRestante.Text) + Convert.ToDouble(txt_ExcluirValor.Text));
                        lb_TotalComprado.Text = Convert.ToString(Convert.ToDouble(lb_TotalComprado.Text) - Convert.ToDouble(txt_ExcluirValor.Text));
                        MessagemOk();
                        //
                    }
                }
                else
                {
                    MessagemErro();
                }
                //
                if (Convert.ToDouble(lb_SaldoRestante.Text) > 0)
                {
                    panelItem.Enabled = true;
                    panel_zerado.Visible = false;
                    panel_SaldoPositivo.Visible = true;
                    lb_SaldoPositivo.Text = Convert.ToString(Convert.ToDouble(lb_SaldoRestante.Text));
                }
                //
                if (Convert.ToDouble(lb_SaldoRestante.Text) <= 0)
                {
                    panel_zerado.Visible = true;
                }
            }
            else { MessagemErro(); }
            //
            txt_ExcluirValor.Clear();
            txt_ExcluirValor.Focus();
        }

        private void btn_AdicionarValor_Click(object sender, EventArgs e)
        {
            if(txt_AdicionarValor.Text!="" && txt_AdicionarValor.Text != ",")
            {
                lb_ValorCaixa.Text = Convert.ToString(Convert.ToDouble(txt_AdicionarValor.Text) + Convert.ToDouble(lb_ValorCaixa.Text));
                lb_SaldoRestante.Text = Convert.ToString(Convert.ToDouble(txt_AdicionarValor.Text) + Convert.ToDouble(lb_SaldoRestante.Text));
                MessagemOk();
               
                //
                if (Convert.ToDouble(lb_SaldoRestante.Text) > 0)
                {
                    panelItem.Enabled = true;
                    panel_zerado.Visible = false;
                    panel_SaldoPositivo.Visible = true;
                    lb_SaldoPositivo.Text = Convert.ToString(Convert.ToDouble(lb_SaldoRestante.Text));
                }
                //
                if (Convert.ToDouble(lb_SaldoRestante.Text) <= 0)
                {
                    panel_zerado.Visible = true;
                }
                //
            }
            else
            {
                MessagemErro();               
            }
            txt_AdicionarValor.Clear();
            txt_AdicionarValor.Focus();

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja fechar o Aplicativo ?", "Mercadinho União", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataehora.Text= DateTime.Now.ToString();
        }

        private void txt_ValorItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratarTextBox(sender, e);
        }

        private void txt_AdicionaCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratarTextBox(sender, e);
        }

        private void txt_ExcluirValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratarTextBox(sender, e);
        }

        private void txt_AdicionarValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratarTextBox(sender, e);
        }

        private void btn_calculadora_Click(object sender, EventArgs e)
        {
            FrmCalc calc=new FrmCalc();
            calc.Show();
        }
    }
}