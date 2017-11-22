using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas
{
    internal class Janela
    {
        private IntPtr handle;
        private Processo processo;
        private List<InstanteJanela> instantes;

        internal IntPtr Handle { get { return this.handle; } }
        internal Processo Processo { get { return this.processo; } }
        internal List<InstanteJanela> Instantes { get { return this.instantes; } }

        internal Janela (IntPtr handle, Processo processo)
        {
            this.instantes = new List<InstanteJanela>();
            this.handle = handle;
            this.processo = processo;
        }

        internal TimeSpan CalcularDuracao()
        {
            TimeSpan ts = new TimeSpan(0);
            foreach (InstanteJanela i in instantes)
            {
                ts += i.Duracao;
            }
            return ts;
        }

        internal bool MesmaJanela(Janela janela)
        {
            return this.handle.Equals(janela.Handle);
        }
    }
}
