using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas
{
    internal class InstanteJanela
    {
        private string nome;
        private DateTime inicio;
        private DateTime? fim = null;
        private TimeSpan? duracao = null;
        private Janela parent;

        internal string Nome { get { return nome; } }
        public DateTime Inicio { get { return inicio; } }
        public DateTime? Fim { get { return fim; } }
        internal TimeSpan Duracao { get { return duracao ?? TimeSpan.Zero; } }
        internal Janela Parent { get { return parent; } }
        internal IntPtr Handle { get { return parent.Handle; } }
        public int ProcID { get { return parent.Processo.ProcId; } }
        public string ProcNome { get { return parent.Processo.Nome; } }

        internal InstanteJanela(Janela parent) : this(ObterNome(parent.Handle), parent, DateTime.Now)
        {
            this.inicio = DateTime.Now;
            this.nome = ObterNome(parent.Handle);
            this.parent = parent;
        }

        internal InstanteJanela(string nome, Janela parent, DateTime inicio)
        {
            this.inicio = inicio;
            this.nome = nome;
        }

        internal void EncerrarInstante()
        {
            this.fim = DateTime.Now;
            this.duracao = this.fim.Value - this.inicio;
        }

        private static string ObterNome(IntPtr handle)
        {
            StringBuilder sb = new StringBuilder(256);
            if (NativeMethods.GetWindowText(handle, sb, sb.Capacity) >= 0)
            {
                return sb.ToString();
            }
            else
            {
                return "ERRO";
            }
        }
    }
}
