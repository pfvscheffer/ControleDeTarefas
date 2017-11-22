using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;

namespace ControleDeTarefas
{
    internal class ProcessoBindingList : BindingList<Processo>
    {
        internal InstanteJanela AdicionarInstante(IntPtr wHandle)
        {
            NativeMethods.GetWindowThreadProcessId(wHandle, out uint pid);
            int processId = (int)pid;

            Processo proc = this.SingleOrDefault(p => p.ProcId == processId);
            if (proc == null)
            {
                proc = new Processo(pid);
                this.Add(proc);
            }
            return proc.AdicionarInstante(wHandle);
        }

        internal void CalcularDuracoes(object o, EventArgs ea)
        {
            foreach (Processo p in this)
            {
                p.CalcularDuracao();
            }
        }
    }
}