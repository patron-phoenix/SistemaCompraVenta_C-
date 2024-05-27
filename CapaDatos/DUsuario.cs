using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DUsuario
    {
        public DataTable Listar()
        {
            try
            {
                ConexionM.abrir();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("usuario_listar",ConexionM.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {

                throw ;
            }
            finally 
            {
                ConexionM.cerrar();
            }
        }

        public DataTable ListarRol()
        {
            try
            {
                ConexionM.abrir();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("rol_listar", ConexionM.conectar);
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
                SqlDataAdapter da = new SqlDataAdapter("usuario_buscar", ConexionM.conectar);
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

        public DataTable Login(string documento, string clave)
        {
            try
            {
                ConexionM.abrir();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("usuario_login", ConexionM.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@documento", documento);
                da.SelectCommand.Parameters.AddWithValue("@clave", clave);
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

        public string Insertar(Usuario obj)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("usuario_insertar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRol", obj.IdRol);
                cmd.Parameters.AddWithValue("@documento", obj.Documento);
                cmd.Parameters.AddWithValue("@nombreCompleto", obj.NombreCompleto);
                cmd.Parameters.AddWithValue("@correo", obj.Correo);
                cmd.Parameters.AddWithValue("@clave", obj.Clave);
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

        public string Actualizar(Usuario obj)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("usuario_actualizar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", obj.IdUsuario);
                cmd.Parameters.AddWithValue("@idRol", obj.IdRol);
                cmd.Parameters.AddWithValue("@documento", obj.Documento);
                cmd.Parameters.AddWithValue("@nombreCompleto", obj.NombreCompleto);
                cmd.Parameters.AddWithValue("@correo", obj.Correo);
                cmd.Parameters.AddWithValue("@clave", obj.Clave);
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
                SqlCommand cmd = new SqlCommand("usuario_activar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", id);
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
                SqlCommand cmd = new SqlCommand("usuario_desactivar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", id);
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
