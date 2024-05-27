using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class BasesDGV
    {
        public static void DiseñoEliminarDGV(ref DataGridView listado)
        {
            foreach (DataGridViewRow row in listado.Rows)
            {
                string estado;
                estado = row.Cells["Estado"].Value.ToString();
                if (estado == "Inactivo")
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI",11,FontStyle.Strikeout);
                    row.DefaultCellStyle.ForeColor=Color.FromArgb(255,128,128);
                }
            }
        }
    }
}
