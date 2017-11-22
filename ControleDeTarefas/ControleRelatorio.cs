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
    [Designer(typeof(ControleRelatorioDesigner))]
    public partial class ControleRelatorio : UserControl
    {
        internal ControleRelatorio()
        {
            InitializeComponent();
            dgvRelatorio.AutoGenerateColumns = false;
            GerarColunas();
        }

        internal void BindProcessos(BindingSource sourceProcessos)
        {
            dgvRelatorio.DataSource = sourceProcessos;
        }

        private void GerarColunas()
        {
            DataGridViewColumn colProcId = Utils.CriarColunaTexto("Proc ID", "colProcId", "ProcId");
            DataGridViewColumn colProcNome = Utils.CriarColunaTexto("Nome Processo", "colProcNome", "Nome");
            DataGridViewColumn colDuracao = Utils.CriarColunaTexto("Duração", "colDuracao", "Duracao", "hh\\:mm\\:ss");

            dgvRelatorio.Columns.AddRange(new DataGridViewColumn[] { colProcId, colProcNome, colDuracao });
        }
    }

    internal class ControleRelatorioDesigner : ControlDesigner
    {

    }
}
