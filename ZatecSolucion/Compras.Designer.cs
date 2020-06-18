namespace ZatecSolucion
{
    partial class Compras
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNome = new System.Windows.Forms.Label();
            this.lb_NomeUsuario = new System.Windows.Forms.Label();
            this.lbValorItem = new System.Windows.Forms.Label();
            this.lbtotalcompra = new System.Windows.Forms.Label();
            this.lb_TotalComprado = new System.Windows.Forms.Label();
            this.lbsaldorestante = new System.Windows.Forms.Label();
            this.lb_SaldoRestante = new System.Windows.Forms.Label();
            this.lbutimoitem = new System.Windows.Forms.Label();
            this.txt_ValorItem = new System.Windows.Forms.TextBox();
            this.btn_ValorItem = new System.Windows.Forms.Button();
            this.lbadicioanrcaixa = new System.Windows.Forms.Label();
            this.lb_UltimoItem = new System.Windows.Forms.Label();
            this.lbexcluirvalor = new System.Windows.Forms.Label();
            this.lbadicionarvalor = new System.Windows.Forms.Label();
            this.txt_ExcluirValor = new System.Windows.Forms.TextBox();
            this.txt_AdicionarValor = new System.Windows.Forms.TextBox();
            this.txt_AdicionaCaixa = new System.Windows.Forms.TextBox();
            this.lbcaixa = new System.Windows.Forms.Label();
            this.lb_ValorCaixa = new System.Windows.Forms.Label();
            this.btn_ExcluirCompra = new System.Windows.Forms.Button();
            this.btn_AdicionarValor = new System.Windows.Forms.Button();
            this.btn_AdicionarCaixa = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Navy;
            this.lbNome.Location = new System.Drawing.Point(13, 13);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(80, 15);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Bem Vindo,";
            // 
            // lb_NomeUsuario
            // 
            this.lb_NomeUsuario.AutoSize = true;
            this.lb_NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeUsuario.ForeColor = System.Drawing.Color.Navy;
            this.lb_NomeUsuario.Location = new System.Drawing.Point(125, 13);
            this.lb_NomeUsuario.Name = "lb_NomeUsuario";
            this.lb_NomeUsuario.Size = new System.Drawing.Size(77, 15);
            this.lb_NomeUsuario.TabIndex = 1;
            this.lb_NomeUsuario.Text = "Meu Nome";
            // 
            // lbValorItem
            // 
            this.lbValorItem.AutoSize = true;
            this.lbValorItem.Location = new System.Drawing.Point(13, 51);
            this.lbValorItem.Name = "lbValorItem";
            this.lbValorItem.Size = new System.Drawing.Size(95, 13);
            this.lbValorItem.TabIndex = 2;
            this.lbValorItem.Text = "Valor do Item   R$:";
            // 
            // lbtotalcompra
            // 
            this.lbtotalcompra.AutoSize = true;
            this.lbtotalcompra.Location = new System.Drawing.Point(13, 107);
            this.lbtotalcompra.Name = "lbtotalcompra";
            this.lbtotalcompra.Size = new System.Drawing.Size(105, 13);
            this.lbtotalcompra.TabIndex = 3;
            this.lbtotalcompra.Text = "Total Comprado  R$:";
            // 
            // lb_TotalComprado
            // 
            this.lb_TotalComprado.AutoSize = true;
            this.lb_TotalComprado.Location = new System.Drawing.Point(125, 107);
            this.lb_TotalComprado.Name = "lb_TotalComprado";
            this.lb_TotalComprado.Size = new System.Drawing.Size(13, 13);
            this.lb_TotalComprado.TabIndex = 4;
            this.lb_TotalComprado.Text = "0";
            // 
            // lbsaldorestante
            // 
            this.lbsaldorestante.AutoSize = true;
            this.lbsaldorestante.Location = new System.Drawing.Point(13, 135);
            this.lbsaldorestante.Name = "lbsaldorestante";
            this.lbsaldorestante.Size = new System.Drawing.Size(106, 13);
            this.lbsaldorestante.TabIndex = 5;
            this.lbsaldorestante.Text = "Saldo Restante   R$:";
            // 
            // lb_SaldoRestante
            // 
            this.lb_SaldoRestante.AutoSize = true;
            this.lb_SaldoRestante.Location = new System.Drawing.Point(125, 135);
            this.lb_SaldoRestante.Name = "lb_SaldoRestante";
            this.lb_SaldoRestante.Size = new System.Drawing.Size(13, 13);
            this.lb_SaldoRestante.TabIndex = 6;
            this.lb_SaldoRestante.Text = "0";
            // 
            // lbutimoitem
            // 
            this.lbutimoitem.AutoSize = true;
            this.lbutimoitem.Location = new System.Drawing.Point(13, 80);
            this.lbutimoitem.Name = "lbutimoitem";
            this.lbutimoitem.Size = new System.Drawing.Size(85, 13);
            this.lbutimoitem.TabIndex = 7;
            this.lbutimoitem.Text = "Último Item   R$:";
            // 
            // txt_ValorItem
            // 
            this.txt_ValorItem.Location = new System.Drawing.Point(125, 48);
            this.txt_ValorItem.Name = "txt_ValorItem";
            this.txt_ValorItem.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorItem.TabIndex = 8;
            this.txt_ValorItem.TextChanged += new System.EventHandler(this.txt_ValorItem_TextChanged);
            this.txt_ValorItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorItem_KeyPress);
            // 
            // btn_ValorItem
            // 
            this.btn_ValorItem.Location = new System.Drawing.Point(231, 45);
            this.btn_ValorItem.Name = "btn_ValorItem";
            this.btn_ValorItem.Size = new System.Drawing.Size(75, 23);
            this.btn_ValorItem.TabIndex = 9;
            this.btn_ValorItem.Text = "Confirmar";
            this.btn_ValorItem.UseVisualStyleBackColor = true;
            this.btn_ValorItem.Click += new System.EventHandler(this.btn_ValorItem_Click);
            // 
            // lbadicioanrcaixa
            // 
            this.lbadicioanrcaixa.AutoSize = true;
            this.lbadicioanrcaixa.Location = new System.Drawing.Point(13, 328);
            this.lbadicioanrcaixa.Name = "lbadicioanrcaixa";
            this.lbadicioanrcaixa.Size = new System.Drawing.Size(148, 13);
            this.lbadicioanrcaixa.TabIndex = 10;
            this.lbadicioanrcaixa.Text = "Adicionar Valor de Caixa   R$:";
            // 
            // lb_UltimoItem
            // 
            this.lb_UltimoItem.AutoSize = true;
            this.lb_UltimoItem.Location = new System.Drawing.Point(125, 80);
            this.lb_UltimoItem.Name = "lb_UltimoItem";
            this.lb_UltimoItem.Size = new System.Drawing.Size(13, 13);
            this.lb_UltimoItem.TabIndex = 10;
            this.lb_UltimoItem.Text = "0";
            // 
            // lbexcluirvalor
            // 
            this.lbexcluirvalor.AutoSize = true;
            this.lbexcluirvalor.Location = new System.Drawing.Point(13, 195);
            this.lbexcluirvalor.Name = "lbexcluirvalor";
            this.lbexcluirvalor.Size = new System.Drawing.Size(103, 13);
            this.lbexcluirvalor.TabIndex = 10;
            this.lbexcluirvalor.Text = "Devolver Valor   R$:";
            // 
            // lbadicionarvalor
            // 
            this.lbadicionarvalor.AutoSize = true;
            this.lbadicionarvalor.Location = new System.Drawing.Point(13, 224);
            this.lbadicionarvalor.Name = "lbadicionarvalor";
            this.lbadicionarvalor.Size = new System.Drawing.Size(101, 13);
            this.lbadicionarvalor.TabIndex = 10;
            this.lbadicionarvalor.Text = "Adicionar Valor  R$:";
            // 
            // txt_ExcluirValor
            // 
            this.txt_ExcluirValor.Location = new System.Drawing.Point(125, 192);
            this.txt_ExcluirValor.Name = "txt_ExcluirValor";
            this.txt_ExcluirValor.Size = new System.Drawing.Size(100, 20);
            this.txt_ExcluirValor.TabIndex = 11;
            // 
            // txt_AdicionarValor
            // 
            this.txt_AdicionarValor.Location = new System.Drawing.Point(152, 221);
            this.txt_AdicionarValor.Name = "txt_AdicionarValor";
            this.txt_AdicionarValor.Size = new System.Drawing.Size(73, 20);
            this.txt_AdicionarValor.TabIndex = 12;
            // 
            // txt_AdicionaCaixa
            // 
            this.txt_AdicionaCaixa.Location = new System.Drawing.Point(160, 325);
            this.txt_AdicionaCaixa.Name = "txt_AdicionaCaixa";
            this.txt_AdicionaCaixa.Size = new System.Drawing.Size(142, 20);
            this.txt_AdicionaCaixa.TabIndex = 13;
            // 
            // lbcaixa
            // 
            this.lbcaixa.AutoSize = true;
            this.lbcaixa.Location = new System.Drawing.Point(13, 291);
            this.lbcaixa.Name = "lbcaixa";
            this.lbcaixa.Size = new System.Drawing.Size(101, 13);
            this.lbcaixa.TabIndex = 14;
            this.lbcaixa.Text = "Valor de Caixa   R$:";
            // 
            // lb_ValorCaixa
            // 
            this.lb_ValorCaixa.AutoSize = true;
            this.lb_ValorCaixa.Location = new System.Drawing.Point(122, 291);
            this.lb_ValorCaixa.Name = "lb_ValorCaixa";
            this.lb_ValorCaixa.Size = new System.Drawing.Size(13, 13);
            this.lb_ValorCaixa.TabIndex = 15;
            this.lb_ValorCaixa.Text = "0";
            // 
            // btn_ExcluirCompra
            // 
            this.btn_ExcluirCompra.Location = new System.Drawing.Point(231, 189);
            this.btn_ExcluirCompra.Name = "btn_ExcluirCompra";
            this.btn_ExcluirCompra.Size = new System.Drawing.Size(75, 23);
            this.btn_ExcluirCompra.TabIndex = 16;
            this.btn_ExcluirCompra.Text = "Confirmar";
            this.btn_ExcluirCompra.UseVisualStyleBackColor = true;
            this.btn_ExcluirCompra.Click += new System.EventHandler(this.btn_ExcluirCompra_Click);
            // 
            // btn_AdicionarValor
            // 
            this.btn_AdicionarValor.Location = new System.Drawing.Point(231, 218);
            this.btn_AdicionarValor.Name = "btn_AdicionarValor";
            this.btn_AdicionarValor.Size = new System.Drawing.Size(75, 23);
            this.btn_AdicionarValor.TabIndex = 17;
            this.btn_AdicionarValor.Text = "Confirmar";
            this.btn_AdicionarValor.UseVisualStyleBackColor = true;
            this.btn_AdicionarValor.Click += new System.EventHandler(this.btn_AdicionarValor_Click);
            // 
            // btn_AdicionarCaixa
            // 
            this.btn_AdicionarCaixa.Location = new System.Drawing.Point(227, 350);
            this.btn_AdicionarCaixa.Name = "btn_AdicionarCaixa";
            this.btn_AdicionarCaixa.Size = new System.Drawing.Size(75, 23);
            this.btn_AdicionarCaixa.TabIndex = 18;
            this.btn_AdicionarCaixa.Text = "Confirmar";
            this.btn_AdicionarCaixa.UseVisualStyleBackColor = true;
            this.btn_AdicionarCaixa.Click += new System.EventHandler(this.btn_AdicionarCaixa_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(16, 379);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(290, 23);
            this.btn_Sair.TabIndex = 19;
            this.btn_Sair.Text = "Sair do Aplicativo";
            this.btn_Sair.UseVisualStyleBackColor = true;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 414);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_AdicionarCaixa);
            this.Controls.Add(this.btn_AdicionarValor);
            this.Controls.Add(this.btn_ExcluirCompra);
            this.Controls.Add(this.lb_ValorCaixa);
            this.Controls.Add(this.lbcaixa);
            this.Controls.Add(this.txt_AdicionaCaixa);
            this.Controls.Add(this.txt_AdicionarValor);
            this.Controls.Add(this.txt_ExcluirValor);
            this.Controls.Add(this.lb_UltimoItem);
            this.Controls.Add(this.lbadicionarvalor);
            this.Controls.Add(this.lbexcluirvalor);
            this.Controls.Add(this.lbadicioanrcaixa);
            this.Controls.Add(this.btn_ValorItem);
            this.Controls.Add(this.txt_ValorItem);
            this.Controls.Add(this.lbutimoitem);
            this.Controls.Add(this.lb_SaldoRestante);
            this.Controls.Add(this.lbsaldorestante);
            this.Controls.Add(this.lb_TotalComprado);
            this.Controls.Add(this.lbtotalcompra);
            this.Controls.Add(this.lbValorItem);
            this.Controls.Add(this.lb_NomeUsuario);
            this.Controls.Add(this.lbNome);
            this.Name = "Compras";
            this.Text = "Controle de Compra";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lb_NomeUsuario;
        private System.Windows.Forms.Label lbValorItem;
        private System.Windows.Forms.Label lbtotalcompra;
        private System.Windows.Forms.Label lb_TotalComprado;
        private System.Windows.Forms.Label lbsaldorestante;
        private System.Windows.Forms.Label lb_SaldoRestante;
        private System.Windows.Forms.Label lbutimoitem;
        private System.Windows.Forms.TextBox txt_ValorItem;
        private System.Windows.Forms.Button btn_ValorItem;
        private System.Windows.Forms.Label lbadicioanrcaixa;
        private System.Windows.Forms.Label lb_UltimoItem;
        private System.Windows.Forms.Label lbexcluirvalor;
        private System.Windows.Forms.Label lbadicionarvalor;
        private System.Windows.Forms.TextBox txt_ExcluirValor;
        private System.Windows.Forms.TextBox txt_AdicionarValor;
        private System.Windows.Forms.Label lbcaixa;
        private System.Windows.Forms.Button btn_ExcluirCompra;
        private System.Windows.Forms.Button btn_AdicionarValor;
        private System.Windows.Forms.Button btn_AdicionarCaixa;
        private System.Windows.Forms.Button btn_Sair;
        public System.Windows.Forms.Label lb_ValorCaixa;
        public System.Windows.Forms.TextBox txt_AdicionaCaixa;
    }
}

