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
    public class DVentas
    {
        public DataTable Listar(string valor)
        {
            try
            {
                ConexionM.abrir();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("venta_listar", ConexionM.conectar);
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


        public DataTable Buscar(string valor)
        {
            try
            {
                ConexionM.abrir();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("venta_buscar", ConexionM.conectar);
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

        public string Insertar(Venta obj)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("venta_insertar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", obj.IdUsuario);
                cmd.Parameters.AddWithValue("@idCliente", obj.IdCliente);
                cmd.Parameters.AddWithValue("@tipoDocumento", obj.TipoDocumento);
                //cmd.Parameters.AddWithValue("@numeroDocumento", obj.NumeroDocumento);
                cmd.Parameters.AddWithValue("@documentoCliente", obj.DocumentoCliente);
                cmd.Parameters.AddWithValue("@nombreCliente", obj.NombreCliente);
                cmd.Parameters.AddWithValue("@montoPago", obj.MontoPago);
                cmd.Parameters.AddWithValue("@montoCambio", obj.MontoCambio);
                cmd.Parameters.AddWithValue("@montoTotal", obj.MontoTotal);
                cmd.Parameters.AddWithValue("@detalle", obj.Detalle);
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

        public string Eliminar(int id)
        {
            try
            {
                ConexionM.abrir();
                SqlCommand cmd = new SqlCommand("compra_eliminar", ConexionM.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCompra", id);
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
