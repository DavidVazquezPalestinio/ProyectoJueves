using System.Data;
using Abonos.Models;
using CoreDbContext.Servicios;

namespace Abonos.Repositorio
{
    public class AbonoRepositorio
    {
        private readonly ISqlDbFactory DbFactory;

        public AbonoRepositorio(ISqlDbFactory pDbFactory)
        {
            DbFactory = pDbFactory;
        }

        public void GuadarAbono(Abono pAbono)
        {
            IDataParameter[] parametros = new IDataParameter[2];
            parametros[0] = DbFactory.Parametro("IdCompra", SqlDbType.Int, pAbono.IdCompra);
            parametros[1] = DbFactory.Parametro("Monto", SqlDbType.Decimal, 18, 5, pAbono.IdCompra);

            DbFactory.EjecutarProcedimientoAlmacenado("pGuardarAbono", parametros);
        }
        public void GetHistorialAbonos(Abono pAbono)
        {
            IDataParameter[] parametros = new IDataParameter[1];
            parametros[0] = DbFactory.Parametro("IdCompra", SqlDbType.Int, pAbono.IdCompra);


            DbFactory.EjecutarProcedimientoAlmacenadoConsulta("[dbo].[pGetHistorialAbonos]", parametros, pReader => new Abono(pReader));
        }
    }
}
