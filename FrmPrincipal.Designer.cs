namespace Trabalho
{
    partial class FrmPrincipal
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
            this.lblValor = new System.Windows.Forms.Label();
            this.BtnEmpilhar = new System.Windows.Forms.Button();
            this.BtnDesempilhar = new System.Windows.Forms.Button();
            this.BtnTamanhoPilha = new System.Windows.Forms.Button();
            this.BtnMostrarTopo = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.TextStack = new System.Windows.Forms.TextBox();
            this.lblPilha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(16, 151);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(247, 18);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Informe um valor para empilhar:";
            // 
            // BtnEmpilhar
            // 
            this.BtnEmpilhar.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnEmpilhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpilhar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEmpilhar.Location = new System.Drawing.Point(19, 322);
            this.BtnEmpilhar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEmpilhar.Name = "BtnEmpilhar";
            this.BtnEmpilhar.Size = new System.Drawing.Size(139, 47);
            this.BtnEmpilhar.TabIndex = 2;
            this.BtnEmpilhar.Text = "Empilhar";
            this.BtnEmpilhar.UseVisualStyleBackColor = false;
            this.BtnEmpilhar.Click += new System.EventHandler(this.btEmpilhar_Click);
            // 
            // BtnDesempilhar
            // 
            this.BtnDesempilhar.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnDesempilhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesempilhar.Location = new System.Drawing.Point(166, 322);
            this.BtnDesempilhar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDesempilhar.Name = "BtnDesempilhar";
            this.BtnDesempilhar.Size = new System.Drawing.Size(139, 47);
            this.BtnDesempilhar.TabIndex = 3;
            this.BtnDesempilhar.Text = "Desempilhar";
            this.BtnDesempilhar.UseVisualStyleBackColor = false;
            this.BtnDesempilhar.Click += new System.EventHandler(this.btDesempilhar_Click);
            // 
            // BtnTamanhoPilha
            // 
            this.BtnTamanhoPilha.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnTamanhoPilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTamanhoPilha.Location = new System.Drawing.Point(460, 322);
            this.BtnTamanhoPilha.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTamanhoPilha.Name = "BtnTamanhoPilha";
            this.BtnTamanhoPilha.Size = new System.Drawing.Size(139, 47);
            this.BtnTamanhoPilha.TabIndex = 5;
            this.BtnTamanhoPilha.Text = "Tamanho da pilha";
            this.BtnTamanhoPilha.UseVisualStyleBackColor = false;
            this.BtnTamanhoPilha.Click += new System.EventHandler(this.btTamanhoPilha_Click);
            // 
            // BtnMostrarTopo
            // 
            this.BtnMostrarTopo.BackColor = System.Drawing.Color.Teal;
            this.BtnMostrarTopo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarTopo.Location = new System.Drawing.Point(313, 322);
            this.BtnMostrarTopo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMostrarTopo.Name = "BtnMostrarTopo";
            this.BtnMostrarTopo.Size = new System.Drawing.Size(139, 47);
            this.BtnMostrarTopo.TabIndex = 4;
            this.BtnMostrarTopo.Text = "Mostrar Topo";
            this.BtnMostrarTopo.UseVisualStyleBackColor = false;
            this.BtnMostrarTopo.Click += new System.EventHandler(this.btMostrarTopo_Click);
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(648, 50);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(136, 292);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // TextStack
            // 
            this.TextStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextStack.Location = new System.Drawing.Point(300, 147);
            this.TextStack.Name = "TextStack";
            this.TextStack.Size = new System.Drawing.Size(299, 24);
            this.TextStack.TabIndex = 1;
            // 
            // lblPilha
            // 
            this.lblPilha.AutoSize = true;
            this.lblPilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPilha.Location = new System.Drawing.Point(680, 17);
            this.lblPilha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPilha.Name = "lblPilha";
            this.lblPilha.Size = new System.Drawing.Size(74, 25);
            this.lblPilha.TabIndex = 8;
            this.lblPilha.Text = "PILHA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ALGORITMO DE PILHA";
            // 
            // btnDestroy
            // 
            this.btnDestroy.BackColor = System.Drawing.Color.Black;
            this.btnDestroy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestroy.ForeColor = System.Drawing.Color.Snow;
            this.btnDestroy.Location = new System.Drawing.Point(648, 358);
            this.btnDestroy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(139, 36);
            this.btnDestroy.TabIndex = 6;
            this.btnDestroy.Text = "Destruir pilha";
            this.btnDestroy.UseVisualStyleBackColor = false;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 398);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPilha);
            this.Controls.Add(this.TextStack);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.BtnMostrarTopo);
            this.Controls.Add(this.BtnTamanhoPilha);
            this.Controls.Add(this.BtnDesempilhar);
            this.Controls.Add(this.BtnEmpilhar);
            this.Controls.Add(this.lblValor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALGORITMO DE PILHA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button BtnEmpilhar;
        private System.Windows.Forms.Button BtnDesempilhar;
        private System.Windows.Forms.Button BtnTamanhoPilha;
        private System.Windows.Forms.Button BtnMostrarTopo;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox TextStack;
        private System.Windows.Forms.Label lblPilha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDestroy;
    }
}

