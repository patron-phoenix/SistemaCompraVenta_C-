using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVistaProducto : Form
    {
        public FrmVistaProducto()
        {
            InitializeComponent();
        }

        private void Formato()
        {

            DgvListado.Columns[0].HeaderText = "ID";
            DgvListado.Columns[0].Visible=false;
            DgvListado.Columns[1].HeaderText = "ID Categoría";
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].HeaderText = "Categoría";
            DgvListado.Columns[2].Width = 150;
            DgvListado.Columns[3].HeaderText = "Código";
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[4].HeaderText = "Nombre";
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[5].HeaderText = "Descripción";
            DgvListado.Columns[5].Visible = false;
            DgvListado.Columns[6].HeaderText = "Stock";
            DgvListado.Columns[6].Visible = false;
            DgvListado.Columns[7].HeaderText = "Precio Compra";
            DgvListado.Columns[7].Visible = false;
            DgvListado.Columns[8].HeaderText = "Precio Venta";
            DgvListado.Columns[8].Visible = false;
        }
        private void Listar()
        {
            DgvListado.DataSource = NProducto.Listar();
            this.Formato();
        }

        private void Buscar()
        {
            DgvListado.DataSource = NProducto.Buscar(txtBuscar.Text);
        }
        private void FrmVistaProducto_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdProducto = Convert.ToInt32( DgvListado.CurrentRow.Cells["IdProducto"].Value);
            Variables.codigoProducto = DgvListado.CurrentRow.Cells["Codigo"].Value.ToString();
            Variables.NombreProducto = DgvListado.CurrentRow.Cells["Nombre"].Value.ToString();
            Variables.PrecioVenta= Convert.ToDecimal( DgvListado.CurrentRow.Cells["PrecioVenta"].Value);
            Variables.Stock = Convert.ToInt32(DgvListado.CurrentRow.Cells["Stock"].Value);
            this.Close();
        }
    }
}
