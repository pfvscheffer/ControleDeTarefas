using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas
{
    internal class Processo
    {
        private List<Janela> janelas;
        private int procId;
        private string name;
        private TimeSpan duracao;

        internal List<Janela> Janelas { get { return this.janelas; } }
        internal int ProcId { get { return this.procId; } }
        internal string Nome { get { return this.name; } }
        internal TimeSpan Duracao { get { return this.duracao; } }

        internal Processo (uint pid)
        {
            this.janelas = new List<Janela>();
            this.procId = (int)pid;
            Process p = Process.GetProcessById(this.procId);
            this.name = p.ProcessName;
            this.duracao = new TimeSpan(0L);
        }

        /// <summary>
        /// Adiciona instante na janela correspondente deste processo
        /// </summary>
        /// <param name="handle">Handle da janela</param>
        /// <returns>O instante criado</returns>
        internal InstanteJanela AdicionarInstante (IntPtr handle)
        {
            Janela janela = janelas.SingleOrDefault(j => j.Handle == handle);
            if (janela == null)
            {
                janela = new Janela(handle, this);
                this.janelas.Add(janela);
            }

            InstanteJanela instante = new InstanteJanela(janela);
            janela.Instantes.Add(instante);
            return instante;
        }

        internal TimeSpan CalcularDuracao()
        {
            TimeSpan ts = new TimeSpan(0);
            foreach (Janela j in this.janelas)
            {
                ts.Add(j.CalcularDuracao());
            }
            this.duracao = ts;
            return ts;
        }
    }
}
