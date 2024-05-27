using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NUsuario
    {
        public static DataTable Listar()
        {
            DUsuario datos = new DUsuario();
            return datos.Listar();
        }

        public static DataTable ListarRol()
        {
            DUsuario datos = new DUsuario();
            return datos.ListarRol();
        }

        public static DataTable Buscar( string valor)
        {
            DUsuario datos = new DUsuario();
            return datos.Buscar(valor);
        }

        public static DataTable Login(string documento, string clave)
        {
            DUsuario datos = new DUsuario();
            return datos.Login(documento,clave);
        }

        public static string Insertar(int idrol,string documento,string nombreCompleto,string correo,string clave)
        {
            DUsuario datos = new DUsuario();
            Usuario obj = new Usuario();
            obj.IdRol = idrol;
            obj.Documento = documento;
            obj.NombreCompleto = nombreCompleto;
            obj.Correo = correo;
            obj.Clave = clave;
            return datos.Insertar(obj);
        }

        public static string Actualizar(int idusuario, int idrol, string documento, string nombreCompleto, string correo, string clave)
        {
            DUsuario datos = new DUsuario();
            Usuario obj = new Usuario();
            obj.IdUsuario = idusuario;
            obj.IdRol = idrol;
            obj.Documento = documento;
            obj.NombreCompleto = nombreCompleto;
            obj.Correo = correo;
            obj.Clave = clave;
            return datos.Actualizar(obj);
        }

        public static string Activar(int id)
        {
            DUsuario datos = new DUsuario();
            return datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DUsuario datos = new DUsuario();
            return datos.Desactivar(id);
        }
    }
}
