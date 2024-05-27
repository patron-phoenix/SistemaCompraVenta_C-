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
    public partial class FrmVistaCliente : Form
    {
        public FrmVistaCliente()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            DgvListado.DataSource = NCliente.Listar();
        }

        private void Buscar()
        {
            DgvListado.DataSource = NCliente.Buscar(txtBuscar.Text);
        }

        private void FrmVistaCliente_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void DgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdCliente = Convert.ToInt32( DgvListado.CurrentRow.Cells["IdCliente"].Value);
            Variables.NombreCliente = DgvListado.CurrentRow.Cells["NombreCompleto"].Value.ToString();
            Variables.NumeroDocumento = DgvListado.CurrentRow.Cells["Documento"].Value.ToString();
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}
