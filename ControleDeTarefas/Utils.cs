using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    internal static class Utils
    {
        internal static DataGridViewTextBoxColumn CriarColunaTexto(string header, string name, string dataPropertyName)
        {
            return CriarColunaTexto(header, name, dataPropertyName, string.Empty);
        }

        internal static DataGridViewTextBoxColumn CriarColunaTexto(string header, string name, string dataPropertyName, string dateTimeFormat)
        {
            DataGridViewColumn col = new DataGridViewTextBoxColumn
            {
                HeaderText = header,
                Name = name,
                DataPropertyName = dataPropertyName
            };
            if (!String.IsNullOrEmpty(dateTimeFormat))
            {
                col.DefaultCellStyle.Format = dateTimeFormat;
            }
            return col as DataGridViewTextBoxColumn;
        }
    }
}
