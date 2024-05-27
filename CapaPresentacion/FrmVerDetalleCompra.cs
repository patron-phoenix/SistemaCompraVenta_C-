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
    public partial class FrmVerDetalleCompra : UserControl
    {
        public FrmVerDetalleCompra()
        {
            InitializeComponent();
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible=false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[3].Visible = false;
            DgvListado.Columns[4].Visible = false;
            DgvListado.Columns[5].Visible = false;
            DgvListado.Columns[6].Visible = false;
            DgvListado.Columns[7].Width = 300;
            DgvListado.Columns[8].Width = 300;
            DgvListado.Columns[9].Width = 150;
            DgvListado.Columns[10].Width = 200;
        }

        private void Listar()
        {
            DgvListado.DataSource = NCompra.Listar(txtBuscar.Text);
            lblTotal.Text="Total Registros: "+ DgvListado.Rows.Count.ToString();
            txtFecha.Text = DgvListado.CurrentRow.Cells["FechaRegistro"].Value.ToString();
            txtTipoDocumento.Text = DgvListado.CurrentRow.Cells["TipoDocumento"].Value.ToString();
            txtUsuario.Text = DgvListado.CurrentRow.Cells["NombreCompleto"].Value.ToString();
            txtNumeroDocumento.Text = DgvListado.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
            txtRazonSocial.Text = DgvListado.CurrentRow.Cells["RazonSocial"].Value.ToString();



            this.Formato();
        }

        private void FrmVerDetalleCompra_Load(object sender, EventArgs e)
        {

        }



        private void Seleccionar_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkSeleccionar.Checked == true)
            //{
            //    DgvListado.Columns[0].Visible = true;
            //}
            //else
            //{
            //    DgvListado.Columns[0].Visible = false;
            //}
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == DgvListado.Columns["Eliminar"].Index)
            //{
            //    DialogResult resultado;
            //    resultado = MessageBox.Show("Deseas eliminar el registro de compras ? ","Sistema Ventas",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            //    if (resultado==DialogResult.OK)
            //    {
            //        int codigo =Convert.ToInt32( DgvListado.CurrentRow.Cells[1].Value);
            //        NCompra.Eliminar(codigo);
            //        MessageBox.Show("El registro fue eliminado correctamente","Ventas Sistemas",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Ingrese número de documento ","Sistema Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                this.Listar();
                txtBuscar.Clear();
            }
            
        }

        private void DgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFecha.Text = DgvListado.CurrentRow.Cells["FechaRegistro"].Value.ToString();
            txtMontoTotal.Text = DgvListado.CurrentRow.Cells["SubTotal"].Value.ToString();
        }
    }
}
