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
    public class ArticulosVentaRepository : OpheliaRepositoryBase<ArticuloVenta, Int64>, IArticulosVentaRepository
    {
        public ArticulosVentaRepository(IDbContextProvider<OpheliaDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
        
        /// <summary>
        /// Retorna la información de productos vendidos, cantidades y valor total vendido.
        /// </summary>
        /// <returns></returns>
        public List<ProductosVendidos> GetTotalSoldByProduct()
        {
            return Context.ProductosVendidos.FromSql(OpheliaConsts.QUERY_TOTAL_SOLD).AsNoTracking().ToList();
        }
    }
}
