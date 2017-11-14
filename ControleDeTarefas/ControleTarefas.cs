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
    [Designer(typeof(ControleDeTarefasDesigner))]
    public partial class ControleTarefas : UserControl
    {
        public ControleTarefas()
        {
            InitializeComponent();
        }
    }

    public class ControleDeTarefasDesigner : ControlDesigner
    {

    }
}
