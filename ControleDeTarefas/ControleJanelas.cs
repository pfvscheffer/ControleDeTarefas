using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ControleDeTarefas
{
    [Designer(typeof(ControleJanelasDesigner))]
    public partial class ControleJanelas : UserControl
    {
        public ControleJanelas()
        {
            InitializeComponent();
        }

        internal void AtualizarTextBoxes(string procId, string procName, string windowName)
        {
            txtProcId.Text = procId;
            txtProcName.Text = procName;
            txtWindowName.Text = windowName;
        }

        internal void BindDataGridView(BindingSource source)
        {
            dgvHistorico.DataSource = source;
        }
    }
    
    public class ControleJanelasDesigner : ControlDesigner
    {

    }
}
