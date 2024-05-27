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
    public class NVenta
    {
        public static DataTable Listar(string valor)
        {
            DVentas datos = new DVentas();
            return datos.Listar(valor);
        }


        public static DataTable Buscar(string valor)
        {
            DVentas datos = new DVentas();
            return datos.Buscar(valor);
        }

        public static string Insertar(int idusuario, int idcliente, string tipodocumento,string documentocliente,string nombrecliente, decimal montopago,decimal montocambio,decimal montototal, DataTable detalle)
        {
            DVentas datos = new DVentas();
            Venta obj = new Venta();
            obj.IdUsuario = idusuario;
            obj.IdCliente = idcliente;
            obj.TipoDocumento = tipodocumento;
            //obj.NumeroDocumento = numerodocumento;
            obj.DocumentoCliente = documentocliente;
            obj.NombreCliente = nombrecliente;
            obj.MontoPago = montopago;
            obj.MontoCambio = montocambio;
            obj.MontoTotal = montototal;
            obj.Detalle = detalle;
            return datos.Insertar(obj);
        }

    }
}
