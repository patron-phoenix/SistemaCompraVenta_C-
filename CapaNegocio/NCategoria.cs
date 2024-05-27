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
    public class NCategoria
    {
        public static DataTable Listar()
        {
            DCategoria datos = new DCategoria();
            return datos.Listar();
        }


        public static DataTable Buscar(string valor)
        {
            DCategoria datos = new DCategoria();
            return datos.Buscar(valor);
        }

        public static string Insertar(string descripcion)
        {
            DCategoria datos = new DCategoria();
            Categoria obj = new Categoria();
            obj.Descripcion = descripcion;
            return datos.Insertar(obj);
        }

        public static string Actualizar(int idcategoria,string descripcion)
        {
            DCategoria datos = new DCategoria();
            Categoria obj = new Categoria();
            obj.IdCategoria = idcategoria;
            obj.Descripcion = descripcion;

            return datos.Actualizar(obj);
        }

        public static string Activar(int id)
        {
            DCategoria datos = new DCategoria();
            return datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DCategoria datos = new DCategoria();
            return datos.Desactivar(id);
        }
    }
}
