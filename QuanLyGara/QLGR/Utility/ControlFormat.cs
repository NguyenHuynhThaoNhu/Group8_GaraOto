using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGR.Utility
{
    class ControlFormat
    {
        public static void DataGridViewFormat(DataGridView dvg,string[] columns)
        {
            foreach(DataGridViewColumn col in dvg.Columns)
            {
                if (!columns.Contains(col.Name))
                    col.Visible = false;
            }
        }
    }
}
