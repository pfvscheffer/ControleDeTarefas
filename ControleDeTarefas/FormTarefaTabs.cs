using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    public partial class FormTarefaTabs : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        private BindingList<ProcessoJanela> processos;
        private ProcessoJanela processoAtual;
        private BindingSource source;
        Timer timer = new Timer();

        BindingList<ProcessoJanela> Processos { get { return this.processos; } }
        ProcessoJanela ProcessoAtual { get { return this.processoAtual; } }
        BindingSource Source { get { return this.source; } }

        public FormTarefaTabs()
        {
            InitializeComponent();
        }

        private void FormTarefaTabs_Load(object sender, EventArgs e)
        {
            processos = new BindingList<ProcessoJanela>();
            processoAtual = new ProcessoJanela(GetForegroundWindow());
            source = new BindingSource(processos, null);
            controleJanelas.BindDataGridView(source);

            timer.Tick += new EventHandler(AtualizarJanela);
            timer.Interval = 500;
            timer.Start();
        }

        private void AtualizarJanela(object o, EventArgs ea)
        {
            ProcessoJanela pNovo = new ProcessoJanela(GetForegroundWindow());
            if (pNovo.ProcId != processoAtual.ProcId)
            {
                processos.Add(processoAtual);
                processoAtual = pNovo;
                controleJanelas.AtualizarTextBoxes(processoAtual.ProcId.ToString(),
                    processoAtual.ProcName, processoAtual.WindowText);
            }
        }
    }
}
