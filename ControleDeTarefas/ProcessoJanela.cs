using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas
{
    class ProcessoJanela
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder sb, int maxCount);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        private IntPtr hWnd;
        private int procId;
        private string windowText;
        private string procName;

        public IntPtr HWnd { get { return this.hWnd; } }
        public int ProcId { get { return this.procId; } }
        public string WindowText { get { return this.windowText; } }
        public string ProcName { get { return this.procName; } }

        public ProcessoJanela(IntPtr hWnd)
        {
            this.hWnd = hWnd;
            StringBuilder sb = new StringBuilder(256);
            GetWindowText(hWnd, sb, sb.Capacity);
            this.windowText = sb.ToString();
            uint procId;
            GetWindowThreadProcessId(hWnd, out procId);
            this.procId = (int)procId;
            Process p = Process.GetProcessById(this.procId);
            this.procName = p.ProcessName;
        }
    }
}
