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
    [Designer(typeof(ControleJanelasDesigner))]
    public partial class ControleJanelas : UserControl
    {
        public ControleJanelas()
        {
            InitializeComponent();
        }
    }

    public class ControleJanelasDesigner : ControlDesigner
    {

    }
}
