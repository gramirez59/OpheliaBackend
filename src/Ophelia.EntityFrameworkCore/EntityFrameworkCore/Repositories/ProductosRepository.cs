using Abp.EntityFrameworkCore;
using Ophelia.Entidades;
using Ophelia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.EntityFrameworkCore.Repositories
{
    public class ProductosRepository : OpheliaRepositoryBase<Producto, Int64>, IProductosRepository
    {
        public ProductosRepository(IDbContextProvider<OpheliaDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
