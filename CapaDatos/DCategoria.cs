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
    public class DCategoria
    {
        public DataTable Listar()
        {
            try
            {
                ConexionM.abrir();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("categoria_listar", ConexionM.conectar);
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
                SqlDataAdapter da = new SqlDataAdapter("categoria_buscar", ConexionM.conectar);
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

        public string Insertar(Categoria obj)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("categoria_insertar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", obj.Descripcion);
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

        public string Actualizar(Categoria obj)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("categoria_actualizar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoria", obj.IdCategoria);
                cmd.Parameters.AddWithValue("@descripcion", obj.Descripcion);
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
                SqlCommand cmd = new SqlCommand("categoria_activar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoria", id);
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
                SqlCommand cmd = new SqlCommand("categoria_desactivar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoria", id);
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
