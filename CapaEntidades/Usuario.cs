using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
