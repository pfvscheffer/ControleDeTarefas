namespace ControleDeTarefas
{
    partial class FormTarefaTabs
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabJanelaAtual = new System.Windows.Forms.TabPage();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.tabTarefas = new System.Windows.Forms.TabPage();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnAbrirRelatorio = new System.Windows.Forms.Button();
            this.txtMensagem = new ControleDeTarefas.CaixaTextoMensagem(this.components);
            this.controleJanelas1 = new ControleDeTarefas.ControleJanelas();
            this.controleRelatorio1 = new ControleDeTarefas.ControleRelatorio();
            this.controleTarefas1 = new ControleDeTarefas.ControleTarefas();
            this.tabControl.SuspendLayout();
            this.tabJanelaAtual.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            this.tabTarefas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabJanelaAtual);
            this.tabControl.Controls.Add(this.tabRelatorio);
            this.tabControl.Controls.Add(this.tabTarefas);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(507, 313);
            this.tabControl.TabIndex = 0;
            // 
            // tabJanelaAtual
            // 
            this.tabJanelaAtual.Controls.Add(this.controleJanelas1);
            this.tabJanelaAtual.Location = new System.Drawing.Point(4, 22);
            this.tabJanelaAtual.Name = "tabJanelaAtual";
            this.tabJanelaAtual.Padding = new System.Windows.Forms.Padding(3);
            this.tabJanelaAtual.Size = new System.Drawing.Size(499, 287);
            this.tabJanelaAtual.TabIndex = 0;
            this.tabJanelaAtual.Text = "Janelas";
            this.tabJanelaAtual.UseVisualStyleBackColor = true;
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.controleRelatorio1);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorio.Size = new System.Drawing.Size(499, 287);
            this.tabRelatorio.TabIndex = 1;
            this.tabRelatorio.Text = "Relatório";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            // 
            // tabTarefas
            // 
            this.tabTarefas.Controls.Add(this.controleTarefas1);
            this.tabTarefas.Location = new System.Drawing.Point(4, 22);
            this.tabTarefas.Name = "tabTarefas";
            this.tabTarefas.Size = new System.Drawing.Size(499, 287);
            this.tabTarefas.TabIndex = 2;
            this.tabTarefas.Text = "Tarefas";
            this.tabTarefas.UseVisualStyleBackColor = true;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(445, 332);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(75, 24);
            this.btnGerarRelatorio.TabIndex = 1;
            this.btnGerarRelatorio.Text = "Gerar";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnAbrirRelatorio
            // 
            this.btnAbrirRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirRelatorio.Location = new System.Drawing.Point(364, 332);
            this.btnAbrirRelatorio.Name = "btnAbrirRelatorio";
            this.btnAbrirRelatorio.Size = new System.Drawing.Size(75, 24);
            this.btnAbrirRelatorio.TabIndex = 2;
            this.btnAbrirRelatorio.Text = "Abrir";
            this.btnAbrirRelatorio.UseVisualStyleBackColor = true;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensagem.Location = new System.Drawing.Point(13, 334);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(345, 20);
            this.txtMensagem.TabIndex = 3;
            // 
            // controleJanelas1
            // 
            this.controleJanelas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controleJanelas1.Location = new System.Drawing.Point(7, 7);
            this.controleJanelas1.Name = "controleJanelas1";
            this.controleJanelas1.Size = new System.Drawing.Size(486, 274);
            this.controleJanelas1.TabIndex = 0;
            // 
            // controleRelatorio1
            // 
            this.controleRelatorio1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controleRelatorio1.Location = new System.Drawing.Point(4, 7);
            this.controleRelatorio1.Name = "controleRelatorio1";
            this.controleRelatorio1.Size = new System.Drawing.Size(489, 274);
            this.controleRelatorio1.TabIndex = 0;
            // 
            // controleTarefas1
            // 
            this.controleTarefas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controleTarefas1.Location = new System.Drawing.Point(4, 4);
            this.controleTarefas1.Name = "controleTarefas1";
            this.controleTarefas1.Size = new System.Drawing.Size(492, 280);
            this.controleTarefas1.TabIndex = 0;
            // 
            // FormTarefaTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 366);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnAbrirRelatorio);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.tabControl);
            this.Name = "FormTarefaTabs";
            this.Text = "FormTarefaTabs";
            this.tabControl.ResumeLayout(false);
            this.tabJanelaAtual.ResumeLayout(false);
            this.tabRelatorio.ResumeLayout(false);
            this.tabTarefas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabJanelaAtual;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnAbrirRelatorio;
        private CaixaTextoMensagem txtMensagem;
        private System.Windows.Forms.TabPage tabTarefas;
        private ControleJanelas controleJanelas1;
        private ControleRelatorio controleRelatorio1;
        private ControleTarefas controleTarefas1;
    }
}