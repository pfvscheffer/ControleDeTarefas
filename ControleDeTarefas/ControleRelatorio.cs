﻿using System;
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
    [Designer(typeof(ControleRelatorioDesigner))]
    public partial class ControleRelatorio : UserControl
    {
        public ControleRelatorio()
        {
            InitializeComponent();
        }
    }

    public class ControleRelatorioDesigner : ControlDesigner
    {

    }
}
