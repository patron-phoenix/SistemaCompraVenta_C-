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
    public partial class FrmProducto : UserControl
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas y Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas y Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtBuscar.Clear();

            ErrorIcon.Clear();
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[0].Width = 50;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[2].Width = 50;
            DgvListado.Columns[3].HeaderText = "ID";
            DgvListado.Columns[3].Width = 50;
            DgvListado.Columns[4].HeaderText = "ID Categoría";
            DgvListado.Columns[4].Visible = false;
            DgvListado.Columns[5].HeaderText = "Categoría";
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[6].HeaderText = "Código";
            DgvListado.Columns[6].Width = 150;
            DgvListado.Columns[7].HeaderText = "Nombre";
            DgvListado.Columns[7].Width = 150;
            DgvListado.Columns[8].HeaderText = "Descripción";
            DgvListado.Columns[8].Width = 250;
            DgvListado.Columns[9].HeaderText = "Stock";
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].HeaderText = "Precio Compra";
            DgvListado.Columns[10].Width = 100;
            DgvListado.Columns[11].HeaderText = "Precio Venta";
            DgvListado.Columns[11].Width = 100;

            btnActualizar.Visible = false;
            chkSeleccionar.Checked = false;
            btnInsertar.Visible = true;
        }

        private void Listar()
        {
            DgvListado.DataSource = NProducto.Listar();
            lblTotal.Text = "Total: " + DgvListado.Rows.Count.ToString();

            BasesDGV.DiseñoEliminarDGV(ref this.DgvListado);
            this.Limpiar();
            this.Formato();
        }

        private void Buscar()
        {
            DgvListado.DataSource = NProducto.Buscar(txtBuscar.Text);
            lblTotal.Text = "Total: " + DgvListado.Rows.Count.ToString();
        }

        private void ListarCategoria()
        {
            cboCategoria.DataSource = NCategoria.Listar();
            cboCategoria.ValueMember = "idCategoria";
            cboCategoria.DisplayMember = "Descripcion";
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.ListarCategoria();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                DgvListado.Columns[1].Visible = true;
                DgvListado.Columns[2].Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                DgvListado.Columns[1].Visible = false;
                DgvListado.Columns[2].Visible = false;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == string.Empty || txtNombre.Text == string.Empty || txtStock.Text == string.Empty || txtPrecioCompra.Text == string.Empty || txtPrecioVenta.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar otros datos, serán remarcados");
                    ErrorIcon.SetError(txtCodigo, "Ingrese número de código");
                    ErrorIcon.SetError(txtNombre, "Ingrese nombre del producto");
                    ErrorIcon.SetError(txtStock, "Ingrese stock del producto");
                    ErrorIcon.SetError(txtPrecioCompra, "Ingrese precio compra");
                    ErrorIcon.SetError(txtPrecioVenta, "Ingrese precio venta");

                }
                else
                {
                    NProducto.Insertar(Convert.ToInt32(cboCategoria.SelectedValue), txtCodigo.Text.Trim(), txtNombre.Text.Trim(), txtDescripcion.Text.Trim(),Convert.ToInt32( txtStock.Text.Trim()),Convert.ToDecimal( txtPrecioCompra.Text.Trim()),Convert.ToDecimal( txtPrecioVenta.Text.Trim()));
                    this.MensajeOk("Se insertó de forma correcta el registro");
                    this.Listar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Listar();
        }

        private void CargarDatos()
        {
            try
            {
                this.Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;

                txtId.Text = DgvListado.CurrentRow.Cells["IdProducto"].Value.ToString();
                cboCategoria.SelectedValue = DgvListado.CurrentRow.Cells["IdCategoria"].Value.ToString();
                txtCodigo.Text = DgvListado.CurrentRow.Cells["Codigo"].Value.ToString();
                txtNombre.Text = DgvListado.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = DgvListado.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtStock.Text = DgvListado.CurrentRow.Cells["Stock"].Value.ToString();
                txtPrecioCompra.Text = DgvListado.CurrentRow.Cells["PrecioCompra"].Value.ToString();
                txtPrecioVenta.Text = DgvListado.CurrentRow.Cells["PrecioVenta"].Value.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Editar"].Index)
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Deseas actualizar el registro? ", "Sistema de Ventas y Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    string estado = DgvListado.CurrentRow.Cells["Estado"].Value.ToString();
                    if (estado == "Inactivo")
                    {
                        resultado = MessageBox.Show("Habilite el registro para actualizar... ", "Sistema de Ventas y Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CargarDatos();
                    }

                }

            }
            else if (e.ColumnIndex == DgvListado.Columns["Eliminar"].Index)
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Deseas Desactivar el registro? " + DgvListado.CurrentRow.Cells[6].Value, "Sistema de Ventas y Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    int codigo = Convert.ToInt32(DgvListado.CurrentRow.Cells[3].Value);
                    string estado = DgvListado.CurrentRow.Cells["Estado"].Value.ToString();

                    if (estado.Equals("Inactivo"))
                    {
                        MessageBox.Show("El registro ya esta Inactivo ", "Sistema de Ventas y Compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Listar();
                    }
                    else
                    {
                        NProducto.Desactivar(codigo);
                        MessageBox.Show("El registro de " + DgvListado.CurrentRow.Cells[6].Value + " paso a Inactivo ", "Sistema de Ventas y Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Listar();
                    }

                }
            }
            else if (e.ColumnIndex == DgvListado.Columns["Activar"].Index)
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Deseas activar el registro? " + DgvListado.CurrentRow.Cells[6].Value, "Sistema de Ventas y Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    int codigo = Convert.ToInt32(DgvListado.CurrentRow.Cells[3].Value);
                    string estado = DgvListado.CurrentRow.Cells["Estado"].Value.ToString();
                    if (estado.Equals("Activo"))
                    {
                        MessageBox.Show("El registro ya esta Activo ", "Sistema de Ventas y Compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Listar();
                    }
                    else
                    {
                        NProducto.Activar(codigo);
                        MessageBox.Show("El registro de " + DgvListado.CurrentRow.Cells[6].Value + " paso a ser Activo", "Sistema de Ventas y Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Listar();
                    }

                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == string.Empty || txtCodigo.Text == string.Empty || txtNombre.Text == string.Empty || txtStock.Text == string.Empty || txtPrecioCompra.Text == string.Empty || txtPrecioVenta.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar otros datos, serán remarcados");
                    ErrorIcon.SetError(txtCodigo, "Ingrese número de código");
                    ErrorIcon.SetError(txtNombre, "Ingrese nombre del producto");
                    ErrorIcon.SetError(txtStock, "Ingrese stock del producto");
                    ErrorIcon.SetError(txtPrecioCompra, "Ingrese precio compra");
                    ErrorIcon.SetError(txtPrecioVenta, "Ingrese precio venta");

                }
                else
                {
                    NProducto.Actualizar(Convert.ToInt32(txtId.Text), Convert.ToInt32(cboCategoria.SelectedValue), txtCodigo.Text.Trim(), txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), Convert.ToInt32(txtStock.Text.Trim()), Convert.ToDecimal(txtPrecioCompra.Text.Trim()), Convert.ToDecimal(txtPrecioVenta.Text.Trim()));
                    this.MensajeOk("Se insertó de forma correcta el registro");
                    this.Listar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
