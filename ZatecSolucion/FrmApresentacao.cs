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
    public partial class FrmApresentacao : Form
    {
        public FrmApresentacao()
        {
            InitializeComponent();
        }

        private void btn_OkApresentacao_Click(object sender, EventArgs e)
        {
            if (txt_Apresentacao.Text != "")
            {
                txt_Apresentacao.Focus();
                Compras c=new Compras();
                this.Close();
            }
            else { MessageBox.Show("Digite o nome para continuar.", "Mercadinho União",MessageBoxButtons.OK,MessageBoxIcon.Warning); }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o Aplicativo ?", "Mercadinho União", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }
    }
}
