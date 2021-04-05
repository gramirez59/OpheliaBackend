using Abp.Domain.Repositories;
using Ophelia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Interfaces
{
    public interface IProductosRepository : IRepository<Producto, Int64>
    {
    }
}
