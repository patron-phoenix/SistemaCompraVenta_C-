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
    public class NProveedor
    {
        public static DataTable Listar()
        {
            DProveedor datos = new DProveedor();
            return datos.Listar();
        }


        public static DataTable Buscar(string valor)
        {
            DProveedor datos = new DProveedor();
            return datos.Buscar(valor);
        }

        public static string Insertar(string documento, string razonSocial, string correo, string telefono)
        {
            DProveedor datos = new DProveedor();
            Proveedor obj = new Proveedor();
            obj.Documento = documento;
            obj.RazonSocial = razonSocial;
            obj.Correo = correo;
            obj.Telefono = telefono;
            return datos.Insertar(obj);
        }

        public static string Actualizar(int idproveedor, string documento, string razonSocial, string correo, string telefono)
        {
            DProveedor datos = new DProveedor();
            Proveedor obj = new Proveedor();
            obj.IdProveedor = idproveedor;
            obj.Documento = documento;
            obj.RazonSocial = razonSocial;
            obj.Correo = correo;
            obj.Telefono = telefono;

            return datos.Actualizar(obj);
        }

        public static string Activar(int id)
        {
            DProveedor datos = new DProveedor();
            return datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DProveedor datos = new DProveedor();
            return datos.Desactivar(id);
        }
    }
}
