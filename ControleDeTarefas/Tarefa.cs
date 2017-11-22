using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas
{
    internal class Tarefa
    {
        private string nome;
        private List<Processo> processos;

        internal string Nome { get { return nome; } }
        internal List<Processo> Processos { get { return processos; } }

        internal Tarefa(string nome)
        {
            this.nome = nome;
            this.processos = new List<Processo>();
        }

    }
}
