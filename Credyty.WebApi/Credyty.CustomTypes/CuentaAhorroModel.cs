using System;

namespace Credyty.CustomTypes
{
    public class CuentaAhorroModel
    {
        public int Id { get; set; }
        public string NumeroCuenta { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Estado { get; set; }

    }
}
