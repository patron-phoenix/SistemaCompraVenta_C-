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
    public partial class FrmVistaProveedor : Form
    {
        public FrmVistaProveedor()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            DgvListado.DataSource = NProveedor.Listar();

        }

        private void Buscar()
        {
            DgvListado.DataSource = NProveedor.Buscar(txtBuscar.Text);

        }

        private void FrmVistaProveedor_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdProveedor =Convert.ToInt32( DgvListado.CurrentRow.Cells["IdProveedor"].Value);
            Variables.RazonSocial = DgvListado.CurrentRow.Cells["RazonSocial"].Value.ToString();
            Variables.Documento = DgvListado.CurrentRow.Cells["Documento"].Value.ToString();
            this.Close();
        }
    }
}
