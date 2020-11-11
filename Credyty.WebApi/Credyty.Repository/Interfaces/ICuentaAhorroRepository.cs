using Credyty.CustomTypes;

namespace Credyty.Repository.Interfaces
{
    public interface ICuentaAhorroRepository
    {
        CuentaAhorroModel Add(CuentaAhorroModel c);
        void CancelarCuenta(int id);
    }
}
