using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP03.Entidades;

namespace TP03.Windows
{
    public partial class FrmTipoDePagoAE : Form
    {
        private TipoDePago? _tipoDePago;

        public FrmTipoDePagoAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (_tipoDePago is not null)
            {
                TxtTipoDePago.Text = _tipoDePago.Descripcion;

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (_tipoDePago is null)
                {
                    _tipoDePago = new TipoDePago();
                }
                _tipoDePago.Descripcion = TxtTipoDePago.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TxtTipoDePago.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TxtTipoDePago, "Es requerido el monto");
            }
            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        internal TipoDePago? GetTipoDePago()
        {
            return _tipoDePago;
        }

        internal void SetTipoDePago(TipoDePago tipoEditado)
        {
            this._tipoDePago = tipoEditado;
        }
    }
}
