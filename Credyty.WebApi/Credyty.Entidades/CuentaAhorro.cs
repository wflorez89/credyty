using System;

namespace Credyty.Entidades
{
    public class CuentaAhorro
    {
        public int Id { get; set; }
        public string NumeroCuenta { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Estado { get; set; }

    }
}
