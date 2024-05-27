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
    public partial class FrmMenuPrincipal : Form
    {

        public int IdUsuario,IdRol;
        public string Nombre, Rol, Estado;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;
            lblUsuario.Text="Usuario: "+ this.Nombre;
            MessageBox.Show("Bienvenido "+this.Nombre,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Information);

            if (this.Rol.Equals("Administrador"))
            {
                menuUsuarios.Visible = true;
                menuMantenedor.Visible = true;
                menuVentas.Visible = true;
                menuCompras.Visible = true;
                menuClientes.Visible = true;
                menuproveedores.Visible = true;
                menuReportes.Visible = true;
                menuAcercaDe.Visible=true;
            }
            else if (this.Rol.Equals("Vendedor"))
            {
                menuUsuarios.Visible = false;
                menuMantenedor.Visible = false;
                menuVentas.Visible = true;
                menuCompras.Visible = false;
                menuClientes.Visible = true;
                menuproveedores.Visible = false;
                menuReportes.Visible = true;
                menuAcercaDe.Visible = true;

            }
            else if (this.Rol.Equals("Almacenero"))
            {
                menuUsuarios.Visible = false;
                menuMantenedor.Visible = false;
                menuVentas.Visible = false;
                menuCompras.Visible = true;
                menuClientes.Visible = false;
                menuproveedores.Visible = true;
                menuReportes.Visible = true;
                menuAcercaDe.Visible = true;
            }
            else
            {
                menuUsuarios.Visible = false;
                menuMantenedor.Visible = false;
                menuVentas.Visible = false;
                menuCompras.Visible = false;
                menuClientes.Visible = false;
                menuproveedores.Visible = false;
                menuReportes.Visible = false;
                menuAcercaDe.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            panelPrincipal.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            panelPrincipal.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            panelPrincipal.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
        }

        private void btnDetalleCompra_Click(object sender, EventArgs e)
        {
            FrmVerDetalleCompra frm = new FrmVerDetalleCompra();
            panelPrincipal.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            panelPrincipal.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
        }

        private void btnDetalleVenta_Click(object sender, EventArgs e)
        {
            FrmVerDetalleVenta frm = new FrmVerDetalleVenta();
            panelPrincipal.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            FrmProveedor frm = new FrmProveedor();
            panelPrincipal.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            panelPrincipal.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            FrmCompras frm = new FrmCompras();
            panelPrincipal.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frm);
           
        }
    }
}
