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
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnAbrirRelatorio = new System.Windows.Forms.Button();
            this.txtMensagem = new ControleDeTarefas.CaixaTextoMensagem(this.components);
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabJanelaAtual);
            this.tabControl.Controls.Add(this.tabRelatorio);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(507, 279);
            this.tabControl.TabIndex = 0;
            // 
            // tabJanelaAtual
            // 
            this.tabJanelaAtual.Location = new System.Drawing.Point(4, 22);
            this.tabJanelaAtual.Name = "tabJanelaAtual";
            this.tabJanelaAtual.Padding = new System.Windows.Forms.Padding(3);
            this.tabJanelaAtual.Size = new System.Drawing.Size(499, 253);
            this.tabJanelaAtual.TabIndex = 0;
            this.tabJanelaAtual.Text = "Janelas";
            this.tabJanelaAtual.UseVisualStyleBackColor = true;
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorio.Size = new System.Drawing.Size(499, 253);
            this.tabRelatorio.TabIndex = 1;
            this.tabRelatorio.Text = "Relatório";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(445, 298);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(75, 24);
            this.btnGerarRelatorio.TabIndex = 1;
            this.btnGerarRelatorio.Text = "Gerar";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnAbrirRelatorio
            // 
            this.btnAbrirRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirRelatorio.Location = new System.Drawing.Point(364, 298);
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
            this.txtMensagem.Location = new System.Drawing.Point(13, 300);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(345, 20);
            this.txtMensagem.TabIndex = 3;
            // 
            // FormTarefaTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 332);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnAbrirRelatorio);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.tabControl);
            this.Name = "FormTarefaTabs";
            this.Text = "FormTarefaTabs";
            this.tabControl.ResumeLayout(false);
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
    }
}