using Abp.Application.Services;
using Ophelia.Dtos;
using Ophelia.Servicios.Interfaces;
using Ophelia.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Servicios.Implementacion
{
    public class VentaServicio : ApplicationService, IVentaServicio
    {
        private readonly VentaManager _ventaManager;
        public VentaServicio(VentaManager ventaManager)
        {
            _ventaManager = ventaManager;
        }
        public ListPaginationDto<VentaDto> GetAllPurchases()
        {
            ListPaginationDto<VentaDto> resultado = new ListPaginationDto<VentaDto>();

            var ventas = _ventaManager.GetAll();           

            var ventasDto = (from venta in ventas
                             select new VentaDto
                             {
                                 Id = venta.Id,
                                 Fecha = venta.Fecha?.ToString("dd/MM/yyyy HH:mm"),
                                 ValorTotal = venta.ValorTotal,
                                 Cliente = venta.ClienteAsociado.PrimerNombre + " " + venta.ClienteAsociado.PrimerApellido + " " + venta.ClienteAsociado.SegundoApellido,
                                 CantidadArticulos = venta.ArticulosAsociados.Count
                             }).ToList();

            resultado.Items = ventasDto;
            resultado.totalCount = ventasDto.Count;
            return resultado;
        }

        public ListPaginationDto<ProductoVendidoDto> GetTotalSoldByProduct()
        {
            ListPaginationDto<ProductoVendidoDto> resultado = new ListPaginationDto<ProductoVendidoDto>();
            var productosVendidos = _ventaManager.GetTotalSoldByProduct();

            var productosDto = (from producto in productosVendidos
                                select new ProductoVendidoDto
                                {
                                    Nombre = producto.Nombre,
                                    CantidadVendida = producto.CantidadVendida,
                                    TotalVendido = producto.TotalVendido
                                }).ToList();
            resultado.Items = productosDto;
            resultado.totalCount = productosDto.Count;
            return resultado;
        }
    }
}
