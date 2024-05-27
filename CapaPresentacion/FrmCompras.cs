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
    public partial class FrmCompras : UserControl
    {

        private DataTable dtDetalle= new DataTable();

        public FrmCompras()
        {
            InitializeComponent();
        }

        private void CrearTabla()
        {
            this.dtDetalle.Columns.Add("IdProducto",System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Nombre", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("PrecioCompra", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("PrecioVenta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("SubTotal", System.Type.GetType("System.Decimal"));

            DgvListado.DataSource= this.dtDetalle;

            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 250;
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[6].Width = 150;
  
        }

        private void AgregarDetalle(int idproducto,string nombre, decimal precioCompra,decimal precioVenta, int cantidad, decimal subTotal)
        {
            bool agregar = true;

            foreach (DataRow filatemp in dtDetalle.Rows)
            {
                if (Convert.ToInt32( filatemp["IdProducto"])==idproducto)
                {
                    agregar = false;
                    MessageBox.Show("El producto ya fue agregado","Sistema Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
  
            }
            if (agregar)
            {
                DataRow fila = dtDetalle.NewRow();
                fila["IdProducto"] = idproducto;
                //fila["Codigo"] = codigo;
                fila["Nombre"] = nombre;
                fila["PrecioCompra"] = precioCompra;
                fila["PrecioVenta"] = precioVenta;
                fila["Cantidad"] = cantidad;
                fila["SubTotal"] = subTotal;
                this.dtDetalle.Rows.Add(fila);
            }



        }

        private void CalcularTotales()
        {
            decimal total = 0;

            if (DgvListado.Rows.Count <=0)
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
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            numCantidad.Value = 1;
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.CrearTabla();
            chkSeleccionar.Checked = false;
           
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmVistaProveedor frm=new FrmVistaProveedor();
            frm.ShowDialog();
            txtIdProveedor.Text = Variables.IdProveedor.ToString();
            txtNumeroDocumento.Text=Variables.Documento.ToString();
            txtRazonSocial.Text = Variables.RazonSocial.ToString();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmVistaProducto frm= new FrmVistaProducto();
            frm.ShowDialog();

            txtIdProducto.Text =  Variables.IdProducto.ToString();
            txtCodigoProducto.Text = Variables.codigoProducto.ToString();
            txtNombreProducto.Text=Variables.NombreProducto.ToString();
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable Tabla = new DataTable();
                    Tabla = NProducto.BuscarProductoCodigo(txtCodigoProducto.Text.Trim());
                    if (Tabla.Rows.Count <=0)
                    {
                        MessageBox.Show("No existe producto con ese código","Sistema Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtIdProducto.Text = Tabla.Rows[0][0].ToString();
                        txtNombreProducto.Text = Tabla.Rows[0][2].ToString();
                        txtPrecioCompra.Focus();
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
            if (txtIdProveedor.Text == string.Empty || txtNumeroDocumento.Text == string.Empty || txtRazonSocial.Text==string.Empty || txtIdProducto.Text == string.Empty || txtCodigoProducto.Text == string.Empty || txtNombreProducto.Text == string.Empty || txtPrecioCompra.Text == string.Empty || txtPrecioVenta.Text== string.Empty)
            {
                MessageBox.Show("Falta Ingresar datos, Verifique que todos los campos esten llenos","Sistema Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                decimal subtotal = Convert.ToDecimal(txtPrecioCompra.Text) * Convert.ToDecimal(numCantidad.Value);
                this.AgregarDetalle(Convert.ToInt32(txtIdProducto.Text),txtNombreProducto.Text.Trim().ToString(), Convert.ToDecimal(txtPrecioCompra.Text.Trim()), Convert.ToDecimal(txtPrecioVenta.Text.Trim()), Convert.ToInt32(numCantidad.Value), subtotal);
                this.CalcularTotales();
                this.Limpiar();
            }

        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex== DgvListado.Columns["Eliminar"].Index)
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Deseas eliminar el registro? ","Sistema Ventas",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                if (resultado==DialogResult.OK)
                {
                    int indice = e.RowIndex;
                    DgvListado.Rows.RemoveAt(indice);
                    MessageBox.Show("Se elimino el registro? ", "Sistema Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    this.CalcularTotales();
                    chkSeleccionar.Checked=false;
                }
            }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (txtPrecioCompra.Text.Trim().Length==0 && e.KeyChar.ToString()==".")
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString()==".")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (txtPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnRegistrarDetalle_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado= MessageBox.Show("Los siguientes regitros séran agregados a la vista detalle de compra","Sistema Ventas",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                NCompra.Insertar(Variables.IdUsuario, Convert.ToInt32(txtIdProveedor.Text.Trim()), cboTipoDocumento.Text.ToString(), txtNumeroDocumento.Text.ToString(), Convert.ToDecimal(txtTotalPagar.Text), dtDetalle);
                dtDetalle.Clear();
                txtIdProveedor.Clear();
                txtRazonSocial.Clear();
                txtNumeroDocumento.Clear();
            }
        }
    }
}
