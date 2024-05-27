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
    public partial class FrmVerDetalleVenta : UserControl
    {
        public FrmVerDetalleVenta()
        {
            InitializeComponent();
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[3].Visible = false;
            DgvListado.Columns[4].Visible = false;
            DgvListado.Columns[5].Visible = false;
            DgvListado.Columns[6].Visible = false;
            DgvListado.Columns[7].Width = 300;
            DgvListado.Columns[8].Width = 300;
            DgvListado.Columns[9].Width = 150;
            DgvListado.Columns[10].Width = 150;

        }

        private void Limpiar()
        {
            txtBuscar.Clear();
            txtFecha.Clear();
            txtTipoDocumento.Clear();
            txtUsuario.Clear();
            txtNumeroDocumento.Clear();
            txtNombreCompleto.Clear();
        }

        private void Listar()
        {

            DgvListado.DataSource = NVenta.Listar(txtBuscar.Text);


            if (DgvListado.Rows.Count <=0)
            {
                MessageBox.Show("No existe registro con ese número de documento ","Sistema Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Limpiar();
            }
            else
            {
                lblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
                txtFecha.Text = DgvListado.CurrentRow.Cells["FechaRegistro"].Value.ToString();
                txtTipoDocumento.Text = DgvListado.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                txtUsuario.Text = DgvListado.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                txtNumeroDocumento.Text = DgvListado.CurrentRow.Cells["DocumentoCliente"].Value.ToString();
                txtNombreCompleto.Text = DgvListado.CurrentRow.Cells["NombreCliente"].Value.ToString();
                this.Formato();
            }

           
        }

        private void FrmVerDetalleVenta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
