using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DProducto
    {
        public DataTable Listar()
        {
            try
            {
                ConexionM.abrir();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("producto_listar", ConexionM.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ConexionM.cerrar();
            }
        }


        public DataTable Buscar(string valor)
        {
            try
            {
                ConexionM.abrir();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("producto_buscar", ConexionM.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@valor", valor);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ConexionM.cerrar();
            }
        }

        public DataTable BuscarProductoCodigo(string valor)
        {
            try
            {
                ConexionM.abrir();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("producto_buscar_codigo", ConexionM.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@valor", valor);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ConexionM.cerrar();
            }
        }

        public string Insertar(Producto obj)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("producto_insertar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoria", obj.IdCategoria);
                cmd.Parameters.AddWithValue("@codigo", obj.Codigo);
                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", obj.Descripcion);
                cmd.Parameters.AddWithValue("@stock", obj.Stock);
                cmd.Parameters.AddWithValue("@precioCompra", obj.PrecioCompra);
                cmd.Parameters.AddWithValue("@precioVenta", obj.PrecioVenta);
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ConexionM.cerrar();
            }
        }

        public string Actualizar(Producto obj)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("producto_actualizar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", obj.IdProducto);
                cmd.Parameters.AddWithValue("@idCategoria", obj.IdCategoria);
                cmd.Parameters.AddWithValue("@codigo", obj.Codigo);
                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", obj.Descripcion);
                cmd.Parameters.AddWithValue("@stock", obj.Stock);
                cmd.Parameters.AddWithValue("@precioCompra", obj.PrecioCompra);
                cmd.Parameters.AddWithValue("@precioVenta", obj.PrecioVenta);
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ConexionM.cerrar();
            }
        }

        public string Activar(int id)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("producto_activar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", id);
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ConexionM.cerrar();
            }
        }

        public string Desactivar(int id)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("producto_desactivar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", id);
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ConexionM.cerrar();
            }
        }
    }
}
