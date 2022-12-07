using System.Data;
using System.Text;
using CoreUtilerias.Entidades;

namespace Abonos.Models
{
    public class Abono
    {
        public int IdCompra { get; set; }
        public decimal Precio { get; set; }
        public decimal Saldo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public Abono()
        {
            
        }
        public Abono(IDataReader pReader)
        {
            IdCompra = pReader.FInt("IdCompra");
            Precio = pReader.FDec("Precio");
            Saldo = pReader.FDec("Saldo");
            Descripcion = pReader.FStr("Descripcion");
            Estado = pReader.FStr("Estado");
        }
    }
}
