using Abp.Domain.Services;
using Ophelia.Entidades;
using Ophelia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Clientes
{
    public class ClienteManager : IDomainService
    {
        private readonly IClientesRepository _clienteRepository;
        private readonly IVentasRepository _ventasRepository;

        public ClienteManager(IClientesRepository clienteRepository, IVentasRepository ventasRepository)
        {
            _clienteRepository = clienteRepository;
            _ventasRepository = ventasRepository;
        }

        /// <summary>
        /// Retorna todos los clientes.
        /// </summary>
        /// <returns></returns>
        public List<Cliente> GetAll()
        {
            return _clienteRepository.GetAllList();
        }

        /// <summary>
        /// Retorna los clientes menores de una edad especifica que hayan realizado compras en un rango de fechas.
        /// </summary>
        /// <returns></returns>
        public List<Cliente> GetClientsWithPurchases()
        {
            var query =
                from clientes in _clienteRepository.GetAll()
                join ventas in _ventasRepository.GetAll() on clientes.Id equals ventas.IdCliente
                where clientes.Edad <= OpheliaConsts.AGE_CLIENT
                && ventas.Fecha >= OpheliaConsts.INIT_DATE
                && ventas.Fecha <= OpheliaConsts.LAST_DATE
                select clientes;
            return query.ToList();
        }

        /// <summary>
        /// Retorna un cliente especifico recibiendo como parametro el número de cedula
        /// </summary>
        /// <param name="numCedula">Número de cedula del Cliente</param>
        /// <returns></returns>
        public Cliente ObtenerClienteByCedula(string numCedula)
        {
            return _clienteRepository.GetAll().Where(x => x.Cedula.Equals(numCedula)).FirstOrDefault();
        }

        public long CreateCliente(Cliente cliente)
        {
            try
            {
                return _clienteRepository.InsertAndGetId(cliente);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
