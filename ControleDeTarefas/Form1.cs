using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private static ProcessoJanela processoAtual;
        private BindingList<ProcessoJanela> processos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processos = new BindingList<ProcessoJanela>();
            processoAtual = new ProcessoJanela(GetForegroundWindow());
            //BindingList<ProcessoJanela> blProcessos = new BindingList<ProcessoJanela>(processos);
            BindingSource source = new BindingSource(processos, null);
            dgvProcessos.DataSource = source;

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
                txtNome.Text = processoAtual.WindowText;
                txtProcId.Text = processoAtual.ProcId.ToString();
                txtProcName.Text = processoAtual.ProcName;
            }

            /*
            if (processos.Count == 3)
            {
                BindingList<ProcessoJanela> blProcessos = new BindingList<ProcessoJanela>(processos);
                BindingSource source = new BindingSource(blProcessos, null);
                dgvProcessos.DataSource = source;
            }*/
        }
    }
}
