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
    public partial class FrmProveedor : UserControl
    {
        public FrmProveedor()
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
            txtNumDocumento.Clear();
            txtRazonSocial.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
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
            DgvListado.Columns[4].HeaderText = "Num. Documento";
            DgvListado.Columns[4].Width = 250;
            DgvListado.Columns[5].HeaderText = "Razón Social";
            DgvListado.Columns[5].Width = 250;
            DgvListado.Columns[6].HeaderText = "Correo";
            DgvListado.Columns[6].Width = 250;
            DgvListado.Columns[7].HeaderText = "Telefono";
            DgvListado.Columns[7].Width = 250;
            DgvListado.Columns[8].HeaderText = "Estado";
            DgvListado.Columns[8].Width = 150;

            btnActualizar.Visible = false;
            chkSeleccionar.Checked = false;
            btnInsertar.Visible = true;
        }

        private void Listar()
        {
            DgvListado.DataSource = NProveedor.Listar();
            lblTotal.Text = "Total: " + DgvListado.Rows.Count.ToString();

            BasesDGV.DiseñoEliminarDGV(ref this.DgvListado);
            this.Limpiar();
            this.Formato();
        }

        private void Buscar()
        {
            DgvListado.DataSource = NProveedor.Buscar(txtBuscar.Text);
            lblTotal.Text = "Total: " + DgvListado.Rows.Count.ToString();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            this.Listar();
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
                if (txtNumDocumento.Text == string.Empty || txtRazonSocial.Text == string.Empty || txtCorreo.Text == string.Empty || txtTelefono.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar otros datos, serán remarcados");
                    ErrorIcon.SetError(txtNumDocumento, "Ingrese número de documento");
                    ErrorIcon.SetError(txtRazonSocial, "Ingrese razon social");
                    ErrorIcon.SetError(txtCorreo, "Ingrese correo del cliente");
                    ErrorIcon.SetError(txtTelefono, "Ingrese telefono");

                }
                else
                {
                    NProveedor.Insertar(txtNumDocumento.Text.Trim(), txtRazonSocial.Text.Trim(), txtCorreo.Text.Trim(), txtTelefono.Text.Trim());
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

                txtId.Text = DgvListado.CurrentRow.Cells["IdCliente"].Value.ToString();
                txtNumDocumento.Text = DgvListado.CurrentRow.Cells["Documento"].Value.ToString();
                txtRazonSocial.Text = DgvListado.CurrentRow.Cells["RazonSocial"].Value.ToString();
                txtCorreo.Text = DgvListado.CurrentRow.Cells["Correo"].Value.ToString();
                txtTelefono.Text = DgvListado.CurrentRow.Cells["Telefono"].Value.ToString();

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
                resultado = MessageBox.Show("Deseas Desactivar el registro? " + DgvListado.CurrentRow.Cells[5].Value, "Sistema de Ventas y Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                        NProveedor.Desactivar(codigo);
                        MessageBox.Show("El registro de " + DgvListado.CurrentRow.Cells[5].Value + " paso a Inactivo ", "Sistema de Ventas y Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Listar();
                    }

                }
            }
            else if (e.ColumnIndex == DgvListado.Columns["Activar"].Index)
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Deseas activar el registro? " + DgvListado.CurrentRow.Cells[5].Value, "Sistema de Ventas y Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                        NProveedor.Activar(codigo);
                        MessageBox.Show("El registro de " + DgvListado.CurrentRow.Cells[5].Value + " paso a ser Activo", "Sistema de Ventas y Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Listar();
                    }

                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == string.Empty || txtNumDocumento.Text == string.Empty || txtRazonSocial.Text == string.Empty || txtCorreo.Text == string.Empty || txtTelefono.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar otros datos, serán remarcados");
                    ErrorIcon.SetError(txtNumDocumento, "Ingrese número de documento");
                    ErrorIcon.SetError(txtRazonSocial, "Ingrese razón social");
                    ErrorIcon.SetError(txtCorreo, "Ingrese correo del usuario");
                    ErrorIcon.SetError(txtTelefono, "Ingrese clave");

                }
                else
                {
                    NProveedor.Actualizar(Convert.ToInt32(txtId.Text), txtNumDocumento.Text.Trim(), txtRazonSocial.Text.Trim(), txtCorreo.Text.Trim(), txtTelefono.Text.Trim());
                    this.MensajeOk("Se actualizó de forma correcta el registro");
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
