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
    public partial class FrmVentas : UserControl
    {

        private DataTable dtDetalle = new DataTable();

        public FrmVentas()
        {
            InitializeComponent();
        }

        private void CrearTabla()
        {
            this.dtDetalle.Columns.Add("IdProducto", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Nombre", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("PrecioVenta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("SubTotal", System.Type.GetType("System.Decimal"));

            DgvListado.DataSource = this.dtDetalle;

            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 250;
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[5].Width = 150;

        }

        private void AgregarDetalle(int idproducto, string nombre, decimal precioVenta, int cantidad, decimal subTotal)
        {
            bool agregar = true;

            foreach (DataRow filatemp in dtDetalle.Rows)
            {
                if (Convert.ToInt32(filatemp["IdProducto"]) == idproducto)
                {
                    agregar = false;
                    MessageBox.Show("El producto ya fue agregado", "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (agregar)
            {
                DataRow fila = dtDetalle.NewRow();
                fila["IdProducto"] = idproducto;
                fila["Nombre"] = nombre;
                fila["PrecioVenta"] = precioVenta;
                fila["Cantidad"] = cantidad;
                fila["SubTotal"] = subTotal;
                this.dtDetalle.Rows.Add(fila);
            }



        }

        private void CalcularTotales()
        {
            decimal total = 0;

            if (DgvListado.Rows.Count <= 0)
            {
                txtTotalPagar.Clear();
                chkSeleccionar.Checked = false;
            }
            else
            {
                foreach (DataRow filatemp in dtDetalle.Rows)
                {

                    total += Convert.ToDecimal(filatemp["SubTotal"]);
                    txtTotalPagar.Text = total.ToString("#0.00#");
                }
            }


        }

        private void Limpiar()
        {

            txtIdProducto.Clear();
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
            numCantidad.Value = 1;
        }

        private void CalcularCambio()
        {
            if (txtTotalPagar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No existen Productos en Venta","Sistema Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            decimal pagaCon;
            decimal total = Convert.ToDecimal(txtTotalPagar.Text);
            if (txtPagaCon.Text.Trim() == string.Empty)
            {
                txtPagaCon.Text = "0";
            }
            if (decimal.TryParse(txtPagaCon.Text.Trim(),out pagaCon))
            {
                if (pagaCon < total)
                {
                    txtCambio.Text = "0.00";

                }
                else
                {
                    decimal cambio = pagaCon - total;
                    txtCambio.Text=cambio.ToString("0.00");
                }
            }

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            chkSeleccionar.Checked = false;
            btnBuscarCliente.Enabled = true;
            this.CrearTabla();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmVistaCliente frm= new FrmVistaCliente();
            frm.ShowDialog();
            txtIdCiente.Text = Variables.IdCliente.ToString();
            txtNumeroDocumento.Text=Variables.NumeroDocumento.ToString();
            txtNombreCompleto.Text=Variables.NombreCliente.ToString();
            btnBuscarCliente.Enabled=false;
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmVistaProducto frm = new FrmVistaProducto();
            frm.ShowDialog();

            txtIdProducto.Text = Variables.IdProducto.ToString();
            txtCodigoProducto.Text = Variables.codigoProducto.ToString();
            txtNombreProducto.Text = Variables.NombreProducto.ToString();
            txtPrecioVenta.Text = Variables.PrecioVenta.ToString();
            txtStock.Text=Variables.Stock.ToString();
            
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable Tabla = new DataTable();
                    Tabla = NProducto.BuscarProductoCodigo(txtCodigoProducto.Text.Trim());
                    if (Tabla.Rows.Count <= 0)
                    {
                        MessageBox.Show("No existe producto con ese código", "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtIdProducto.Text = Tabla.Rows[0][0].ToString();
                        txtNombreProducto.Text = Tabla.Rows[0][2].ToString();
                        numCantidad.Focus();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked == true)
            {
                DgvListado.Columns[0].Visible = true;

            }
            else
            {
                DgvListado.Columns[0].Visible = false;

            }
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (txtIdCiente.Text == string.Empty || txtNumeroDocumento.Text == string.Empty || txtNombreCompleto.Text == string.Empty || txtIdProducto.Text == string.Empty || txtCodigoProducto.Text == string.Empty || txtNombreProducto.Text == string.Empty || txtStock.Text == string.Empty || txtPrecioVenta.Text == string.Empty)
            {
                MessageBox.Show("Falta Ingresar datos, Verifique que todos los campos esten llenos", "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal subtotal = Convert.ToDecimal(txtPrecioVenta.Text) * Convert.ToDecimal(numCantidad.Value);
                this.AgregarDetalle(Convert.ToInt32(txtIdProducto.Text), txtNombreProducto.Text.Trim().ToString(), Convert.ToDecimal(txtPrecioVenta.Text.Trim()), Convert.ToInt32(numCantidad.Value), subtotal);
                this.CalcularTotales();
                this.Limpiar();
            }
        }

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData ==Keys.Enter)
            {
                this.CalcularCambio();
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Eliminar"].Index)
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Deseas eliminar el registro? ", "Sistema Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.OK)
                {
                    int indice = e.RowIndex;
                    DgvListado.Rows.RemoveAt(indice);
                    MessageBox.Show("Se elimino el registro? ", "Sistema Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    this.CalcularTotales();
                    this.CalcularCambio();
                    txtIdCiente.Clear();
                    txtNumeroDocumento.Clear();
                    txtNombreCompleto.Clear();
                    txtPagaCon.Clear();
                    txtCambio.Clear();
                    chkSeleccionar.Checked = false;
                }
            }
        }

        private void btnRegistrarDetalle_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Los siguientes regitros séran agregados a la vista detalle de compra", "Sistema Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                NVenta.Insertar(Variables.IdUsuario, Convert.ToInt32(txtIdCiente.Text.Trim()), cboTipoDocumento.Text.ToString(), txtNumeroDocumento.Text.ToString(),txtNombreCompleto.Text.Trim(), Convert.ToDecimal(txtPagaCon.Text.Trim()),Convert.ToDecimal(txtCambio.Text.Trim()),Convert.ToDecimal(txtTotalPagar.Text.Trim()), dtDetalle);
                dtDetalle.Clear();
                txtIdCiente.Clear();
                txtNombreCompleto.Clear();
                txtNumeroDocumento.Clear();
                txtTotalPagar.Clear();
                txtPagaCon.Clear();
                txtCambio.Clear();
                btnBuscarCliente.Enabled = true;
            }
        }
    }
}
