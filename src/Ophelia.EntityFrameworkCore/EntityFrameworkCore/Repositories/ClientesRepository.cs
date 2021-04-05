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
    public class ClientesRepository : OpheliaRepositoryBase<Cliente, Int64>, IClientesRepository
    {
        public ClientesRepository(IDbContextProvider<OpheliaDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
