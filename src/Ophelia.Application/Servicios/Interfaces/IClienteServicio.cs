using Abp.Application.Services;
using Ophelia.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Servicios.Interfaces
{
    public interface IClienteServicio : IApplicationService
    {
        /// <summary>
        /// Retorna todos los clientes o los clientes que tienen compras realizadas en un rango de fechas.
        /// </summary>
        /// <param name="WithPurchases">True = fitra los clientes para que retorne aquellos que tienen compras en un rango de fechas y que son menores de 35. False = Retorna todos los clientes</param>
        /// <returns></returns>
        ListPaginationDto<ClienteDto> GetAllOrClientsWithPurchases(bool WithPurchases);

        /// <summary>
        /// Registra un cliente en el sistema.
        /// </summary>
        /// <param name="clienteInput">Contiene la información del Cliente enviada desde el Front</param>
        /// <returns></returns>
        long CreateCliente(ClienteInputDto clienteInput);
    }
}
