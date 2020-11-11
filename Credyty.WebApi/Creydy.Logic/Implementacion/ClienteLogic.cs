using Credyty.CustomTypes;
using Credyty.Repository.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Credyty.Logic.Interfaces
{
    public class ClienteLogic : IClienteLogic
    {

        private IClienteRepository _clienteRepository;
        private ILogger<ClienteLogic> _logger;

        public ClienteLogic(
            IClienteRepository clienteRepository,
            ILogger<ClienteLogic> logger
            )
        {
            _clienteRepository = clienteRepository;
            _logger = logger;
        }


        public void Add(ClienteModel c)
        {
            try
            {
                _clienteRepository.Add(c);
            }
            catch (System.Exception e)
            {
                _logger.LogError(e.ToString());
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                _clienteRepository.Delete(id);
            }
            catch (System.Exception e)
            {
                _logger.LogError(e.ToString());
                throw;
            }
        }

        public ClienteModel Get(int id)
        {
            try
            {
                return _clienteRepository.Get(id);
            }
            catch (System.Exception e)
            {
                _logger.LogError(e.ToString());
                throw;
            }
        }

        public List<ClienteModel> GetAll()
        {
            try
            {
                return _clienteRepository.GetAll();
            }
            catch (System.Exception e)
            {
                _logger.LogError(e.ToString());
                throw;
            }
        }

        public void Update(ClienteModel c)
        {
            try
            {
                _clienteRepository.Update(c);
            }
            catch (System.Exception e)
            {
                _logger.LogError(e.ToString());
                throw;
            }
        }
    }
}
