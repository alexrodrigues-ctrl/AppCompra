using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZatecSolucion
{
    class Cmetodos : Compras
    {

        public Cmetodos()
        {

        }

        //metodo adicionar valor caixa
        public void ValorCaixa()
        {
            lb_ValorCaixa.Text = txt_AdicionaCaixa.Text;
            txt_AdicionaCaixa.Clear();
            txt_AdicionaCaixa.Focus();
        }
    }
}
