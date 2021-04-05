using Abp.Application.Services;
using Abp.UI;
using AutoMapper;
using Ophelia.Clientes;
using Ophelia.Dtos;
using Ophelia.Entidades;
using Ophelia.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Servicios.Implementacion
{
    public class ClienteServicio : ApplicationService, IClienteServicio
    {
        private readonly ClienteManager _clienteManager;
        public ClienteServicio(ClienteManager clienteManager)
        {
            _clienteManager = clienteManager;
        }
        public ListPaginationDto<ClienteDto> GetAllOrClientsWithPurchases(bool WithPurchases)
        {
            List<Cliente> clientes = null;
            ListPaginationDto<ClienteDto> resultado = new ListPaginationDto<ClienteDto>();

            if (!WithPurchases)
                clientes = _clienteManager.GetAll();
            else
                clientes = _clienteManager.GetClientsWithPurchases();

            var clientesDto = (from cliente in clientes
                               select new ClienteDto()
                               {
                                   Id = cliente.Id,
                                   Cedula = cliente.Cedula,
                                   PrimerNombre = cliente.PrimerNombre,
                                   SegundoNombre = cliente.SegundoNombre,
                                   PrimerApellido = cliente.PrimerApellido,
                                   SegundoApellido = cliente.SegundoApellido,
                                   Edad = cliente.Edad,
                                   Telefono = cliente.Telefono
                               }).ToList();

            resultado.Items = clientesDto;
            resultado.totalCount = clientesDto.Count;
            return resultado;
        }
        public long CreateCliente(ClienteInputDto clienteInput)
        {
            Cliente clienteExistente = _clienteManager.ObtenerClienteByCedula(clienteInput.Cedula);
            if (clienteExistente != null)
                throw new UserFriendlyException("Ya existe un usuario con este Número de Cedula.");

            if (clienteInput.PrimerNombre != null && clienteInput.PrimerNombre != string.Empty)
                clienteInput.PrimerNombre = clienteInput.PrimerNombre.ToUpper();

            if (clienteInput.SegundoNombre != null && clienteInput.SegundoNombre != string.Empty)
                clienteInput.SegundoNombre = clienteInput.SegundoNombre.ToUpper();

            if (clienteInput.PrimerApellido != null && clienteInput.PrimerApellido != string.Empty)
                clienteInput.PrimerApellido = clienteInput.PrimerApellido.ToUpper();

            if (clienteInput.SegundoApellido != null && clienteInput.SegundoApellido != string.Empty)
                clienteInput.SegundoApellido = clienteInput.SegundoApellido.ToUpper();

            Cliente nuevoCliente = null;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClienteInputDto, Cliente>();
            });

            IMapper mapper = config.CreateMapper();
            nuevoCliente = mapper.Map<ClienteInputDto, Cliente>(clienteInput);

            return _clienteManager.CreateCliente(nuevoCliente);
        }
    }
}
