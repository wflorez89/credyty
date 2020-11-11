using Credyty.CustomTypes;
using System.Collections.Generic;

namespace Credyty.Repository.Interfaces
{
    public interface IClienteRepository
    {
        List<ClienteModel> GetAll();
        ClienteModel Get(int id);
        void Add(ClienteModel c);
        void Update(ClienteModel c);
        void Delete(int id);
    }
}
