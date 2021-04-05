using Abp.Domain.Services;
using Ophelia.Entidades;
using Ophelia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Ventas
{
    public class VentaManager : IDomainService
    {
        private readonly IVentasRepository _ventasRepository;
        private readonly IArticulosVentaRepository _articulosVentaRepository;
        public VentaManager(IVentasRepository ventasRepository, IArticulosVentaRepository articulosVentaRepository)
        {
            _ventasRepository = ventasRepository;
            _articulosVentaRepository = articulosVentaRepository;
        }

        /// <summary>
        /// Retorna una lista con todas las ventas.
        /// </summary>
        /// <returns></returns>
        public List<Venta> GetAll()
        {
            return _ventasRepository.GetAll().ToList();
        }

        public List<ProductosVendidos> GetTotalSoldByProduct()
        {
            return _articulosVentaRepository.GetTotalSoldByProduct();
        }
    }
}
