using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ophelia.Entidades;
using Ophelia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.EntityFrameworkCore.Repositories
{
    public class VentasRepository : OpheliaRepositoryBase<Venta, Int64>, IVentasRepository
    {
        public VentasRepository(IDbContextProvider<OpheliaDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public override IQueryable<Venta> GetAll()
        {
            return Context.Set<Venta>()
                .Include(reg => reg.ClienteAsociado)
                .Include(reg => reg.ArticulosAsociados);
        }
    }
}
