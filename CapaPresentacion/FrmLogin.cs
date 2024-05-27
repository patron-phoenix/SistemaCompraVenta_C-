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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresarLogin1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NUsuario.Login(txtNumeroDocumento.Text,txtPassword.Text);
            
                if (Tabla.Rows.Count <=0)
                {
                    MessageBox.Show("documento o clave incorrecto, ingrese datos válidos", "Acceso al Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToString(Tabla.Rows[0][4])== "Inactivo")
                    {
                        MessageBox.Show("El usuario esta inactivo", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Variables.IdUsuario= Convert.ToInt32(Tabla.Rows[0][0]);
                        FrmMenuPrincipal frm = new FrmMenuPrincipal();
                        frm.IdUsuario =Convert.ToInt32( Tabla.Rows[0][0]);
                        frm.IdRol = Convert.ToInt32(Tabla.Rows[0][1]);
                        frm.Rol = Convert.ToString(Tabla.Rows[0][2]);
                        frm.Nombre = Convert.ToString(Tabla.Rows[0][3]);
                        frm.Estado = Convert.ToString(Tabla.Rows[0][4]);
                        frm.Show();
                        this.Hide();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
