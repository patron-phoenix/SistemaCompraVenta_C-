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
    public class DProveedor
    {
        public DataTable Listar()
        {
            try
            {
                ConexionM.abrir();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("proveedor_listar", ConexionM.conectar);
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
                SqlDataAdapter da = new SqlDataAdapter("proveedor_buscar", ConexionM.conectar);
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

        public string Insertar(Proveedor obj)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("proveedor_insertar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@documento", obj.Documento);
                cmd.Parameters.AddWithValue("@razonSocial", obj.RazonSocial);
                cmd.Parameters.AddWithValue("@correo", obj.Correo);
                cmd.Parameters.AddWithValue("@telefono", obj.Telefono);
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

        public string Actualizar(Proveedor obj)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("proveedor_actualizar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", obj.IdProveedor);
                cmd.Parameters.AddWithValue("@documento", obj.Documento);
                cmd.Parameters.AddWithValue("@razonSocial", obj.RazonSocial);
                cmd.Parameters.AddWithValue("@correo", obj.Correo);
                cmd.Parameters.AddWithValue("@telefono", obj.Telefono);
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
                SqlCommand cmd = new SqlCommand("proveedor_activar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", id);
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
                SqlCommand cmd = new SqlCommand("proveedor_desactivar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", id);
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
