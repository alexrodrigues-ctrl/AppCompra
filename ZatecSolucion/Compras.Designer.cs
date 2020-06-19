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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.lbNome = new System.Windows.Forms.Label();
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
            this.panelItem = new System.Windows.Forms.Panel();
            this.panel_zerado = new System.Windows.Forms.Panel();
            this.lbrs = new System.Windows.Forms.Label();
            this.lbsaldozero = new System.Windows.Forms.Label();
            this.lb_zerado = new System.Windows.Forms.Label();
            this.panelAdicionar = new System.Windows.Forms.Panel();
            this.panelCaixa = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataehora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelItem.SuspendLayout();
            this.panel_zerado.SuspendLayout();
            this.panelAdicionar.SuspendLayout();
            this.panelCaixa.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Navy;
            this.lbNome.Location = new System.Drawing.Point(2, 13);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(178, 15);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Bem Vindo ! Mercadinho União";
            // 
            // lbValorItem
            // 
            this.lbValorItem.AutoSize = true;
            this.lbValorItem.Location = new System.Drawing.Point(7, 14);
            this.lbValorItem.Name = "lbValorItem";
            this.lbValorItem.Size = new System.Drawing.Size(95, 13);
            this.lbValorItem.TabIndex = 2;
            this.lbValorItem.Text = "Valor do Item   R$:";
            // 
            // lbtotalcompra
            // 
            this.lbtotalcompra.AutoSize = true;
            this.lbtotalcompra.Location = new System.Drawing.Point(7, 70);
            this.lbtotalcompra.Name = "lbtotalcompra";
            this.lbtotalcompra.Size = new System.Drawing.Size(105, 13);
            this.lbtotalcompra.TabIndex = 3;
            this.lbtotalcompra.Text = "Total Comprado  R$:";
            // 
            // lb_TotalComprado
            // 
            this.lb_TotalComprado.AutoSize = true;
            this.lb_TotalComprado.Location = new System.Drawing.Point(119, 70);
            this.lb_TotalComprado.Name = "lb_TotalComprado";
            this.lb_TotalComprado.Size = new System.Drawing.Size(13, 13);
            this.lb_TotalComprado.TabIndex = 4;
            this.lb_TotalComprado.Text = "0";
            // 
            // lbsaldorestante
            // 
            this.lbsaldorestante.AutoSize = true;
            this.lbsaldorestante.Location = new System.Drawing.Point(7, 98);
            this.lbsaldorestante.Name = "lbsaldorestante";
            this.lbsaldorestante.Size = new System.Drawing.Size(106, 13);
            this.lbsaldorestante.TabIndex = 5;
            this.lbsaldorestante.Text = "Saldo Restante   R$:";
            // 
            // lb_SaldoRestante
            // 
            this.lb_SaldoRestante.AutoSize = true;
            this.lb_SaldoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SaldoRestante.ForeColor = System.Drawing.Color.Green;
            this.lb_SaldoRestante.Location = new System.Drawing.Point(119, 98);
            this.lb_SaldoRestante.Name = "lb_SaldoRestante";
            this.lb_SaldoRestante.Size = new System.Drawing.Size(16, 16);
            this.lb_SaldoRestante.TabIndex = 6;
            this.lb_SaldoRestante.Text = "0";
            // 
            // lbutimoitem
            // 
            this.lbutimoitem.AutoSize = true;
            this.lbutimoitem.Location = new System.Drawing.Point(7, 43);
            this.lbutimoitem.Name = "lbutimoitem";
            this.lbutimoitem.Size = new System.Drawing.Size(85, 13);
            this.lbutimoitem.TabIndex = 7;
            this.lbutimoitem.Text = "Último Item   R$:";
            // 
            // txt_ValorItem
            // 
            this.txt_ValorItem.Location = new System.Drawing.Point(119, 11);
            this.txt_ValorItem.Name = "txt_ValorItem";
            this.txt_ValorItem.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorItem.TabIndex = 8;
            this.txt_ValorItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorItem_KeyPress);
            // 
            // btn_ValorItem
            // 
            this.btn_ValorItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValorItem.Location = new System.Drawing.Point(225, 8);
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
            this.lbadicioanrcaixa.Location = new System.Drawing.Point(7, 44);
            this.lbadicioanrcaixa.Name = "lbadicioanrcaixa";
            this.lbadicioanrcaixa.Size = new System.Drawing.Size(106, 13);
            this.lbadicioanrcaixa.TabIndex = 10;
            this.lbadicioanrcaixa.Text = "Adicionar Caixa   R$:";
            // 
            // lb_UltimoItem
            // 
            this.lb_UltimoItem.AutoSize = true;
            this.lb_UltimoItem.Location = new System.Drawing.Point(119, 43);
            this.lb_UltimoItem.Name = "lb_UltimoItem";
            this.lb_UltimoItem.Size = new System.Drawing.Size(13, 13);
            this.lb_UltimoItem.TabIndex = 10;
            this.lb_UltimoItem.Text = "0";
            // 
            // lbexcluirvalor
            // 
            this.lbexcluirvalor.AutoSize = true;
            this.lbexcluirvalor.Location = new System.Drawing.Point(7, 14);
            this.lbexcluirvalor.Name = "lbexcluirvalor";
            this.lbexcluirvalor.Size = new System.Drawing.Size(103, 13);
            this.lbexcluirvalor.TabIndex = 10;
            this.lbexcluirvalor.Text = "Devolver Valor   R$:";
            // 
            // lbadicionarvalor
            // 
            this.lbadicionarvalor.AutoSize = true;
            this.lbadicionarvalor.Location = new System.Drawing.Point(7, 43);
            this.lbadicionarvalor.Name = "lbadicionarvalor";
            this.lbadicionarvalor.Size = new System.Drawing.Size(101, 13);
            this.lbadicionarvalor.TabIndex = 10;
            this.lbadicionarvalor.Text = "Adicionar Valor  R$:";
            // 
            // txt_ExcluirValor
            // 
            this.txt_ExcluirValor.Location = new System.Drawing.Point(119, 11);
            this.txt_ExcluirValor.Name = "txt_ExcluirValor";
            this.txt_ExcluirValor.Size = new System.Drawing.Size(100, 20);
            this.txt_ExcluirValor.TabIndex = 11;
            this.txt_ExcluirValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ExcluirValor_KeyPress);
            // 
            // txt_AdicionarValor
            // 
            this.txt_AdicionarValor.Location = new System.Drawing.Point(119, 40);
            this.txt_AdicionarValor.Name = "txt_AdicionarValor";
            this.txt_AdicionarValor.Size = new System.Drawing.Size(100, 20);
            this.txt_AdicionarValor.TabIndex = 12;
            this.txt_AdicionarValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AdicionarValor_KeyPress);
            // 
            // txt_AdicionaCaixa
            // 
            this.txt_AdicionaCaixa.Location = new System.Drawing.Point(119, 41);
            this.txt_AdicionaCaixa.Name = "txt_AdicionaCaixa";
            this.txt_AdicionaCaixa.Size = new System.Drawing.Size(100, 20);
            this.txt_AdicionaCaixa.TabIndex = 13;
            this.txt_AdicionaCaixa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AdicionaCaixa_KeyPress);
            // 
            // lbcaixa
            // 
            this.lbcaixa.AutoSize = true;
            this.lbcaixa.Location = new System.Drawing.Point(7, 7);
            this.lbcaixa.Name = "lbcaixa";
            this.lbcaixa.Size = new System.Drawing.Size(101, 13);
            this.lbcaixa.TabIndex = 14;
            this.lbcaixa.Text = "Valor de Caixa   R$:";
            // 
            // lb_ValorCaixa
            // 
            this.lb_ValorCaixa.AutoSize = true;
            this.lb_ValorCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ValorCaixa.Location = new System.Drawing.Point(116, 7);
            this.lb_ValorCaixa.Name = "lb_ValorCaixa";
            this.lb_ValorCaixa.Size = new System.Drawing.Size(16, 16);
            this.lb_ValorCaixa.TabIndex = 15;
            this.lb_ValorCaixa.Text = "0";
            // 
            // btn_ExcluirCompra
            // 
            this.btn_ExcluirCompra.Location = new System.Drawing.Point(225, 8);
            this.btn_ExcluirCompra.Name = "btn_ExcluirCompra";
            this.btn_ExcluirCompra.Size = new System.Drawing.Size(75, 23);
            this.btn_ExcluirCompra.TabIndex = 16;
            this.btn_ExcluirCompra.Text = "Confirmar";
            this.btn_ExcluirCompra.UseVisualStyleBackColor = true;
            this.btn_ExcluirCompra.Click += new System.EventHandler(this.btn_ExcluirCompra_Click);
            // 
            // btn_AdicionarValor
            // 
            this.btn_AdicionarValor.Location = new System.Drawing.Point(225, 37);
            this.btn_AdicionarValor.Name = "btn_AdicionarValor";
            this.btn_AdicionarValor.Size = new System.Drawing.Size(75, 23);
            this.btn_AdicionarValor.TabIndex = 17;
            this.btn_AdicionarValor.Text = "Confirmar";
            this.btn_AdicionarValor.UseVisualStyleBackColor = true;
            this.btn_AdicionarValor.Click += new System.EventHandler(this.btn_AdicionarValor_Click);
            // 
            // btn_AdicionarCaixa
            // 
            this.btn_AdicionarCaixa.Location = new System.Drawing.Point(225, 39);
            this.btn_AdicionarCaixa.Name = "btn_AdicionarCaixa";
            this.btn_AdicionarCaixa.Size = new System.Drawing.Size(75, 23);
            this.btn_AdicionarCaixa.TabIndex = 18;
            this.btn_AdicionarCaixa.Text = "Confirmar";
            this.btn_AdicionarCaixa.UseVisualStyleBackColor = true;
            this.btn_AdicionarCaixa.Click += new System.EventHandler(this.btn_AdicionarCaixa_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(5, 345);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(308, 23);
            this.btn_Sair.TabIndex = 19;
            this.btn_Sair.Text = "Sair do Aplicativo";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // panelItem
            // 
            this.panelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelItem.Controls.Add(this.panel_zerado);
            this.panelItem.Controls.Add(this.lb_UltimoItem);
            this.panelItem.Controls.Add(this.lbValorItem);
            this.panelItem.Controls.Add(this.lbtotalcompra);
            this.panelItem.Controls.Add(this.lb_TotalComprado);
            this.panelItem.Controls.Add(this.lbsaldorestante);
            this.panelItem.Controls.Add(this.lb_SaldoRestante);
            this.panelItem.Controls.Add(this.lbutimoitem);
            this.panelItem.Controls.Add(this.txt_ValorItem);
            this.panelItem.Controls.Add(this.btn_ValorItem);
            this.panelItem.Enabled = false;
            this.panelItem.Location = new System.Drawing.Point(5, 41);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(308, 127);
            this.panelItem.TabIndex = 20;
            // 
            // panel_zerado
            // 
            this.panel_zerado.Controls.Add(this.lbrs);
            this.panel_zerado.Controls.Add(this.lbsaldozero);
            this.panel_zerado.Controls.Add(this.lb_zerado);
            this.panel_zerado.Location = new System.Drawing.Point(160, 35);
            this.panel_zerado.Name = "panel_zerado";
            this.panel_zerado.Size = new System.Drawing.Size(140, 68);
            this.panel_zerado.TabIndex = 23;
            this.panel_zerado.Visible = false;
            // 
            // lbrs
            // 
            this.lbrs.AutoSize = true;
            this.lbrs.Location = new System.Drawing.Point(5, 33);
            this.lbrs.Name = "lbrs";
            this.lbrs.Size = new System.Drawing.Size(30, 13);
            this.lbrs.TabIndex = 13;
            this.lbrs.Text = "R$ : ";
            // 
            // lbsaldozero
            // 
            this.lbsaldozero.AutoSize = true;
            this.lbsaldozero.Location = new System.Drawing.Point(42, 4);
            this.lbsaldozero.Name = "lbsaldozero";
            this.lbsaldozero.Size = new System.Drawing.Size(83, 13);
            this.lbsaldozero.TabIndex = 12;
            this.lbsaldozero.Text = "Saldo Restante:";
            // 
            // lb_zerado
            // 
            this.lb_zerado.AutoSize = true;
            this.lb_zerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_zerado.ForeColor = System.Drawing.Color.Red;
            this.lb_zerado.Location = new System.Drawing.Point(32, 17);
            this.lb_zerado.Name = "lb_zerado";
            this.lb_zerado.Size = new System.Drawing.Size(103, 37);
            this.lb_zerado.TabIndex = 11;
            this.lb_zerado.Text = "00,00";
            // 
            // panelAdicionar
            // 
            this.panelAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelAdicionar.Controls.Add(this.txt_ExcluirValor);
            this.panelAdicionar.Controls.Add(this.lbexcluirvalor);
            this.panelAdicionar.Controls.Add(this.lbadicionarvalor);
            this.panelAdicionar.Controls.Add(this.txt_AdicionarValor);
            this.panelAdicionar.Controls.Add(this.btn_AdicionarValor);
            this.panelAdicionar.Controls.Add(this.btn_ExcluirCompra);
            this.panelAdicionar.Enabled = false;
            this.panelAdicionar.Location = new System.Drawing.Point(5, 174);
            this.panelAdicionar.Name = "panelAdicionar";
            this.panelAdicionar.Size = new System.Drawing.Size(308, 72);
            this.panelAdicionar.TabIndex = 21;
            // 
            // panelCaixa
            // 
            this.panelCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCaixa.Controls.Add(this.lbcaixa);
            this.panelCaixa.Controls.Add(this.lbadicioanrcaixa);
            this.panelCaixa.Controls.Add(this.txt_AdicionaCaixa);
            this.panelCaixa.Controls.Add(this.lb_ValorCaixa);
            this.panelCaixa.Controls.Add(this.btn_AdicionarCaixa);
            this.panelCaixa.Location = new System.Drawing.Point(5, 252);
            this.panelCaixa.Name = "panelCaixa";
            this.panelCaixa.Size = new System.Drawing.Size(308, 77);
            this.panelCaixa.TabIndex = 22;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.dataehora});
            this.statusStrip.Location = new System.Drawing.Point(0, 373);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(317, 22);
            this.statusStrip.TabIndex = 23;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(144, 17);
            this.toolStripStatusLabel1.Text = ":::  Versão1.0  -  By léo   :::  ";
            // 
            // dataehora
            // 
            this.dataehora.Name = "dataehora";
            this.dataehora.Size = new System.Drawing.Size(65, 17);
            this.dataehora.Text = "31/12/2020";
            this.dataehora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 395);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelCaixa);
            this.Controls.Add(this.panelAdicionar);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Compras";
            this.Text = "Controle de Compra";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            this.panel_zerado.ResumeLayout(false);
            this.panel_zerado.PerformLayout();
            this.panelAdicionar.ResumeLayout(false);
            this.panelAdicionar.PerformLayout();
            this.panelCaixa.ResumeLayout(false);
            this.panelCaixa.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
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
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Panel panelAdicionar;
        private System.Windows.Forms.Panel panelCaixa;
        private System.Windows.Forms.Panel panel_zerado;
        private System.Windows.Forms.Label lbrs;
        private System.Windows.Forms.Label lbsaldozero;
        private System.Windows.Forms.Label lb_zerado;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel dataehora;
        public System.Windows.Forms.Timer timer1;
    }
}

