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
    public class NCliente
    {
        public static DataTable Listar()
        {
            DCliente datos = new DCliente();
            return datos.Listar();
        }


        public static DataTable Buscar(string valor)
        {
            DCliente datos = new DCliente();
            return datos.Buscar(valor);
        }

        public static string Insertar(string documento,string nombre,string correo,string telefono)
        {
            DCliente datos = new DCliente();
            Cliente obj = new Cliente();
            obj.Documento = documento;
            obj.NombreCompleto = nombre;
            obj.Correo = correo;
            obj.Telefono = telefono;
            return datos.Insertar(obj);
        }

        public static string Actualizar(int idcliente, string documento, string nombre, string correo, string telefono)
        {
            DCliente datos = new DCliente();
            Cliente obj = new Cliente();
            obj.IdCliente= idcliente;
            obj.Documento = documento;
            obj.NombreCompleto = nombre;
            obj.Correo = correo;
            obj.Telefono = telefono;

            return datos.Actualizar(obj);
        }

        public static string Activar(int id)
        {
            DCliente datos = new DCliente();
            return datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DCliente datos = new DCliente();
            return datos.Desactivar(id);
        }
    }
}
