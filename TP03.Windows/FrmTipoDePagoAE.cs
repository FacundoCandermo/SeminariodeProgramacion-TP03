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
                _tipoDePago.tipodePagoEnum = (TipoDePagoEnum)CboTipoDePago.SelectedItem!;
                TxtMonto.Text = _tipoDePago.Monto.ToString();
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
                _tipoDePago.tipodePagoEnum = (TipoDePagoEnum)CboTipoDePago.SelectedItem!;
                _tipoDePago.Monto = int.Parse(TxtMonto.Text.Trim());
                DialogResult = DialogResult.OK;
            }
        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TxtMonto.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TxtMonto, "Es requerido el monto");
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
