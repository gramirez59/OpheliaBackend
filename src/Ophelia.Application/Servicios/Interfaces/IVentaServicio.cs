using Abp.Application.Services;
using Ophelia.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Servicios.Interfaces
{
    public interface IVentaServicio : IApplicationService
    {
        /// <summary>
        /// Retorna todas la ventas.
        /// </summary>
        /// <returns></returns>
        ListPaginationDto<VentaDto> GetAllPurchases();
        
        /// <summary>
        /// Retorna la información de cantidades de productos vendidos.
        /// </summary>
        /// <returns></returns>
        ListPaginationDto<ProductoVendidoDto> GetTotalSoldByProduct();
    }
}
