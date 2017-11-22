using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ControleDeTarefas
{
    // Classe feita usando
    // https://msdn.microsoft.com/en-us/library/ms171823.aspx

    [Designer(typeof(CaixaTextoMensagemDesigner))]
    public partial class CaixaTextoMensagem : TextBox
    {
        public CaixaTextoMensagem()
        {
            InitializeComponent();
        }

        public CaixaTextoMensagem(IContainer container)
        {
            if (container != null)
            {
                container.Add(this);
            }

            InitializeComponent();
        }

        public void MostrarInfo(string mensagem)
        {
            AlterarCor(Color.Black);
            this.Text = mensagem;
        }

        public void MostrarErro(string msg)
        {
            AlterarCor(Color.Red);
            this.Text = msg;
        }

        private void AlterarCor(Color cor)
        {
            this.ForeColor = cor;
            this.BackColor = this.BackColor;
        }
    }

    public class CaixaTextoMensagemDesigner : ControlDesigner
    {
        
    }
}
