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
    public class NCompra
    {
        public static DataTable Listar(string valor)
        {
            DComprar datos = new DComprar();
            return datos.Listar(valor);
        }


        public static DataTable Buscar(string valor)
        {
            DComprar datos = new DComprar();
            return datos.Buscar(valor);
        }

        public static string Insertar(int idusuario,int idproveedor,string tipodocumento,string numerodocumento,decimal montototal, DataTable detalle)
        {
            DComprar datos = new DComprar();
            Compra obj = new Compra();
            obj.IdUsuario = idusuario;
            obj.IdProveedor= idproveedor;
            obj.TipoDocumento = tipodocumento;
            obj.NumeroDocumento = numerodocumento;
            obj.MontoTotal = montototal;
            obj.Detalle = detalle;
            return datos.Insertar(obj);
        }

        public static string Eliminar(int id)
        {
            DComprar datos = new DComprar();
            return datos.Eliminar(id);
        }


    }
}
