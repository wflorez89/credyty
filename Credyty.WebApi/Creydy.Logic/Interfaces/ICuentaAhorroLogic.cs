using Credyty.CustomTypes;

namespace Credyty.Logic.Interfaces
{
    public interface ICuentaAhorroLogic
    {
        CuentaAhorroModel Add(CuentaAhorroModel c);
        void CancelarCuenta(int id);
    }
}
