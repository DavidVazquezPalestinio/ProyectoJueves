using System.Data;
using Abonos.Models;
using CoreDbContext.Servicios;

namespace Abonos.Repositorio
{
    public class PrincipalRepositorio
    {
        private readonly ISqlDbFactory DbFactory;

        public PrincipalRepositorio(ISqlDbFactory pDbFactory)
        {
            DbFactory = pDbFactory;
        }

        public List<Principal> GetAllComprasPendientes()
        {
            return DbFactory.EjecutarProcedimientoAlmacenadoConsulta("dbo.pGetComprasPendientes", pReader => new Principal(pReader)).ToList();
        }
        public List<Principal> GetCompra(int pIdCompra)
        {
            return DbFactory.EjecutarProcedimientoAlmacenadoConsulta("dbo.pGetCompra", pDbParameterCollection =>
            {
                pDbParameterCollection.Add(DbFactory.Parametro("IdCompra", SqlDbType.Int, pIdCompra));
            }, pReader => new Principal(pReader)).ToList();
        }
    }
}
