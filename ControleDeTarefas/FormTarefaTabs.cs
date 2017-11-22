using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    public partial class FormTarefaTabs : Form
    {
        private ProcessoBindingList processos;
        private BindingList<InstanteJanela> instantes;
        private InstanteJanela instanteAtual;
        private BindingSource sourceInstantes;
        private BindingSource sourceProcessos;
        private EventHandler relatorioHandler;
        Timer timer;

        public FormTarefaTabs()
        {
            InitializeComponent();
        }

        private void FormTarefaTabs_Load(object sender, EventArgs e)
        {
            instantes = new BindingList<InstanteJanela>();
            this.processos = new ProcessoBindingList();
            IntPtr wHandle = NativeMethods.GetForegroundWindow();

            instanteAtual = processos.AdicionarInstante(wHandle);
            this.instantes.Add(instanteAtual);

            sourceInstantes = new BindingSource(instantes, null);
            sourceProcessos = new BindingSource(processos, null);
            controleJanelas.BindJanelas(sourceInstantes);
            controleRelatorio.BindProcessos(sourceProcessos);

            relatorioHandler = new EventHandler(processos.CalcularDuracoes);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += new EventHandler(AtualizarJanela);
            timer.Start();
        }

        private void AtualizarJanela(object o, EventArgs ea)
        {
            IntPtr wHandle = NativeMethods.GetForegroundWindow();
            if (instanteAtual.Handle != wHandle)
            {
                instanteAtual.EncerrarInstante();
                instanteAtual = processos.AdicionarInstante(wHandle);
                this.instantes.Add(instanteAtual);
                controleJanelas.AtualizarTextBoxes(instanteAtual.Parent.Processo.ProcId.ToString(CultureInfo.CurrentCulture),
                    instanteAtual.Parent.Processo.Nome,
                    instanteAtual.Nome);
            }
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedTab == tabRelatorio)
            {
                timer.Tick += relatorioHandler;
            }
            else
            {
                timer.Tick -= relatorioHandler;
            }
        }
    }
}
