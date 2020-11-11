using Credyty.CustomTypes;

namespace Credyty.Repository.Interfaces
{
    public interface IMovimientoCuentaRepository
    {
        void Add(MovimientoCuentaModel c);
        decimal GetSaldoCuentaId(int cuentaid);

    }
}
