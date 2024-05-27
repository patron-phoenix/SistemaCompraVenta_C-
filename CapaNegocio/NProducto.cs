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
    public class NProducto
    {
        public static DataTable Listar()
        {
            DProducto datos = new DProducto();
            return datos.Listar();
        }


        public static DataTable Buscar(string valor)
        {
            DProducto datos = new DProducto();
            return datos.Buscar(valor);
        }

        public static DataTable BuscarProductoCodigo(string valor)
        {
            DProducto datos = new DProducto();
            return datos.BuscarProductoCodigo(valor);
        }

        public static string Insertar(int idcategoria, string codigo,string nombre, string descripcion,int stock,decimal precioCompra,decimal precioVenta)
        {
            DProducto datos = new DProducto();
            Producto obj = new Producto();
            obj.IdCategoria = idcategoria;
            obj.Codigo = codigo;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            obj.Stock = stock;
            obj.PrecioCompra = precioCompra;
            obj.PrecioVenta = precioVenta;
            return datos.Insertar(obj);
        }

        public static string Actualizar(int idproducto, int idcategoria, string codigo, string nombre, string descripcion, int stock, decimal precioCompra, decimal precioVenta)
        {
            DProducto datos = new DProducto();
            Producto obj = new Producto();
            obj.IdProducto = idproducto;
            obj.IdCategoria = idcategoria;
            obj.Codigo = codigo;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            obj.Stock = stock;
            obj.PrecioCompra = precioCompra;
            obj.PrecioVenta = precioVenta;

            return datos.Actualizar(obj);
        }

        public static string Activar(int id)
        {
            DProducto datos = new DProducto();
            return datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DProducto datos = new DProducto();
            return datos.Desactivar(id);
        }
    }
}
