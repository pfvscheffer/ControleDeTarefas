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
    internal partial class ControleJanelas : UserControl
    {
        internal ControleJanelas()
        {
            InitializeComponent();
            dgvHistorico.AutoGenerateColumns = false;
            GerarColunas();
        }

        internal void AtualizarTextBoxes(string procId, string procName, string windowName)
        {
            txtProcId.Text = procId;
            txtProcName.Text = procName;
            txtWindowName.Text = windowName;
        }

        internal void BindJanelas(BindingSource source)
        {
            dgvHistorico.DataSource = source;
        }

        private void GerarColunas()
        {
            DataGridViewColumn colProcId = Utils.CriarColunaTexto("Proc ID", "colProcId", "ProcID");
            DataGridViewColumn colProcNome = Utils.CriarColunaTexto("Nome Processo", "colProcNome", "ProcNome");
            DataGridViewColumn colInicio = Utils.CriarColunaTexto("Início", "colInicio", "Inicio", "hh:mm:ss");
            DataGridViewColumn colFim = Utils.CriarColunaTexto("Fim", "colFim", "Fim", "hh:mm:ss");
            
            dgvHistorico.Columns.AddRange(new DataGridViewColumn [] { colProcId, colProcNome, colInicio, colFim });
        }
    }

    internal class ControleJanelasDesigner : ControlDesigner
    {

    }
}
