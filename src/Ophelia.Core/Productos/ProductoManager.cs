using Abp.Domain.Services;
using Ophelia.Entidades;
using Ophelia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Productos
{
    public class ProductoManager : IDomainService
    {
        private readonly IProductosRepository _productosRepository;

        public ProductoManager(IProductosRepository productosRepository)
        {
            _productosRepository = productosRepository;
        }

        /// <summary>
        /// Retorna todos los productos o los productos con stock minimo
        /// </summary>
        /// <param name="getLowStock"></param>
        /// <returns></returns>
        public List<Producto> GetAllOrGetLowStock(bool getLowStock)
        {
            if(!getLowStock)
                return _productosRepository.GetAllList();
            else
                return _productosRepository.GetAll().Where(x => x.CantidadInventario <= OpheliaConsts.MINIMUM_STOCK).ToList();
        }
    }
}
