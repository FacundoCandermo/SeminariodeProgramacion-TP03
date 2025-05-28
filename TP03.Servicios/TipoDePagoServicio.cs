using TP03.DatosSql;
using TP03.Entidades;

namespace TP03.Servicios
{
    public class TipoDePagoServicio
    {
        private readonly TipoDePagoRepositorio _tipoDePagoRepositorio = null!;
        public TipoDePagoServicio()
        {
            _tipoDePagoRepositorio = new TipoDePagoRepositorio(true);
        }

        public bool Existe(TipoDePago pago)
        {
            return _tipoDePagoRepositorio.Existe(pago);
        }

        public List<TipoDePago> GetLista()
        {
            return _tipoDePagoRepositorio.GetLista();
        }

        public void Guardar(TipoDePago pago)
        {
            if (pago.TipoDePagoId == 0)
            {
                _tipoDePagoRepositorio.Agregar(pago);
            }
            else
            {
                _tipoDePagoRepositorio.Editar(pago);
            }
        }

        public void Borrar(int tipoDePagoId)
        {
            _tipoDePagoRepositorio.Borrar(tipoDePagoId);
        }

        
    }
}
