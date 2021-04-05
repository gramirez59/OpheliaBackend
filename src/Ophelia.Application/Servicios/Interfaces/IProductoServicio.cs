using Abp.Application.Services;
using Ophelia.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Servicios.Interfaces
{
    public interface IProductoServicio : IApplicationService
    {
        /// <summary>
        /// Retorna todos los productos o los productos con poca existencia.
        /// </summary>
        /// <param name="getLowStock"></param>
        /// <returns></returns>
        ListPaginationDto<ProductoDto> GetAllOrGetLowStock(bool getLowStock);
    }
}
