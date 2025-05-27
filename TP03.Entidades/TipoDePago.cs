using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03.Entidades
{
    public class TipoDePago
    {
        public int TipoDePagoId { get; set; }
        public string Descripcion { get; set; } = null!;

        public int Monto { get; set; }

        public TipoDePagoEnum tipodePagoEnum { get; set; }


        public override string ToString()
        {
            return $"{Descripcion}";
        }

        public TipoDePago Clonar()
        {
            return new TipoDePago
            {
                TipoDePagoId = TipoDePagoId,
                Descripcion = Descripcion
            };
        }
    }
    public enum TipoDePagoEnum
    {
        Efectivo = 1,
        Débito,
        Crédito,
        Transferencia,
        MercadoPago,
        CuentaCorriente
    }
}
