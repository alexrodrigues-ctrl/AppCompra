namespace ZatecSolucion
{
    partial class FrmApresentacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Apresentacao = new System.Windows.Forms.TextBox();
            this.btn_OkApresentacao = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbnomeApresentacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Apresentacao
            // 
            this.txt_Apresentacao.Location = new System.Drawing.Point(7, 25);
            this.txt_Apresentacao.Name = "txt_Apresentacao";
            this.txt_Apresentacao.Size = new System.Drawing.Size(199, 20);
            this.txt_Apresentacao.TabIndex = 0;
            // 
            // btn_OkApresentacao
            // 
            this.btn_OkApresentacao.Location = new System.Drawing.Point(7, 51);
            this.btn_OkApresentacao.Name = "btn_OkApresentacao";
            this.btn_OkApresentacao.Size = new System.Drawing.Size(75, 23);
            this.btn_OkApresentacao.TabIndex = 1;
            this.btn_OkApresentacao.Text = "Entrar";
            this.btn_OkApresentacao.UseVisualStyleBackColor = true;
            this.btn_OkApresentacao.Click += new System.EventHandler(this.btn_OkApresentacao_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(131, 51);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbnomeApresentacao
            // 
            this.lbnomeApresentacao.AutoSize = true;
            this.lbnomeApresentacao.Location = new System.Drawing.Point(8, 6);
            this.lbnomeApresentacao.Name = "lbnomeApresentacao";
            this.lbnomeApresentacao.Size = new System.Drawing.Size(86, 13);
            this.lbnomeApresentacao.TabIndex = 3;
            this.lbnomeApresentacao.Text = "Digite seu nome:";
            // 
            // FrmApresentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 80);
            this.Controls.Add(this.lbnomeApresentacao);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_OkApresentacao);
            this.Controls.Add(this.txt_Apresentacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmApresentacao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercadinho União";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_OkApresentacao;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbnomeApresentacao;
        public System.Windows.Forms.TextBox txt_Apresentacao;
    }
}