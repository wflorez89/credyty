using Credyty.CustomTypes;
using System.Collections.Generic;

namespace Credyty.Logic.Interfaces
{
    public interface IClienteLogic
    {
        List<ClienteModel> GetAll();
        ClienteModel Get(int id);
        void Add(ClienteModel c);
        void Update(ClienteModel c);
        void Delete(int id);
    }
}
