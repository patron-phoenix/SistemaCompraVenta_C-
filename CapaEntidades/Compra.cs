using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Compra
    {
        public int IdCompra {  get; set; }
        public int IdUsuario { get; set; }
        public int IdProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento {  get; set; }
        public decimal MontoTotal {  get; set; }
        public string FechaRegistro {  get; set; }
        public DataTable Detalle {  get; set; }

    }
}
