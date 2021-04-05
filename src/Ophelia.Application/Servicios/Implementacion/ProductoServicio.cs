using Abp.Application.Services;
using Ophelia.Dtos;
using Ophelia.Productos;
using Ophelia.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Servicios.Implementacion
{
    public class ProductoServicio : ApplicationService, IProductoServicio
    {
        private readonly ProductoManager _productoManager;

        public ProductoServicio(ProductoManager productoManager)
        {
            _productoManager = productoManager;
        }
        public ListPaginationDto<ProductoDto> GetAllOrGetLowStock(bool getLowStock)
        {
            ListPaginationDto<ProductoDto> resultado = new ListPaginationDto<ProductoDto>();

            var productos = _productoManager.GetAllOrGetLowStock(getLowStock);

            var productosDto = (from producto in productos
                                select new ProductoDto()
                                {
                                    Id = producto.Id,
                                    Nombre = producto.Nombre,
                                    Marca = producto.Marca,
                                    PrecioUnitario = producto.PrecioUnitario,
                                    CantidadInventario = producto.CantidadInventario
                                }).ToList();

            resultado.Items = productosDto;
            resultado.totalCount = productosDto.Count;
            return resultado;
        }
    }
}
