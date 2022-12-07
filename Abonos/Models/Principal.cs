using System.Data;

namespace Abonos.Models
{
    public class Principal
    {
        public int IdAbono { get; set; }
        public int IdCompra { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Principal() { }

        public Principal(IDataReader pReader)
        {

        }
    }
}
