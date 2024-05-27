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
    public partial class FrmCategoria : UserControl
    {
        public FrmCategoria()
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
            txtDescripcion.Clear();

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
            DgvListado.Columns[4].HeaderText = "Descripción";
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[5].HeaderText = "Estado";
            DgvListado.Columns[5].Width = 100;


            btnActualizar.Visible = false;
            chkSeleccionar.Checked = false;
            btnInsertar.Visible = true;
        }

        private void Listar()
        {
            DgvListado.DataSource = NCategoria.Listar();
            lblTotal.Text = "Total: " + DgvListado.Rows.Count.ToString();

            BasesDGV.DiseñoEliminarDGV(ref this.DgvListado);
            this.Limpiar();
            this.Formato();
        }

        private void Buscar()
        {
            DgvListado.DataSource = NCategoria.Buscar(txtBuscar.Text);
            lblTotal.Text = "Total: " + DgvListado.Rows.Count.ToString();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
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
                if (txtDescripcion.Text == string.Empty )
                {
                    this.MensajeError("Faltan ingresar otros datos, serán remarcados");
                    ErrorIcon.SetError(txtDescripcion, "Ingrese la descripción de la categoría");


                }
                else
                {
                    NCategoria.Insertar( txtDescripcion.Text.Trim());
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

                txtId.Text = DgvListado.CurrentRow.Cells["IdCategoria"].Value.ToString();
                txtDescripcion.Text = DgvListado.CurrentRow.Cells["Descripcion"].Value.ToString();

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
                resultado = MessageBox.Show("Deseas Desactivar el registro? " + DgvListado.CurrentRow.Cells[4].Value, "Sistema de Ventas y Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                        NCategoria.Desactivar(codigo);
                        MessageBox.Show("El registro de " + DgvListado.CurrentRow.Cells[4].Value + " paso a Inactivo ", "Sistema de Ventas y Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Listar();
                    }

                }
            }
            else if (e.ColumnIndex == DgvListado.Columns["Activar"].Index)
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Deseas activar el registro? " + DgvListado.CurrentRow.Cells[4].Value, "Sistema de Ventas y Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                        NCategoria.Activar(codigo);
                        MessageBox.Show("El registro de " + DgvListado.CurrentRow.Cells[4].Value + " paso a ser Activo", "Sistema de Ventas y Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Listar();
                    }

                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == string.Empty || txtDescripcion.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar otros datos, serán remarcados");
                    ErrorIcon.SetError(txtDescripcion, "Ingrese la descripción de la categoría");

                }
                else
                {
                    NCategoria.Actualizar(Convert.ToInt32( txtId.Text), txtDescripcion.Text.Trim());
                    this.MensajeOk("Se actualizo de forma correcta el registro");
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
