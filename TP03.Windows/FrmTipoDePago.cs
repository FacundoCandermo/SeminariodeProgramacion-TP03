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
using TP03.Servicios;
using TP03.Windows.helper;

namespace TP03.Windows
{
    public partial class FrmTipoDePago : Form
    {
        private readonly TipoDePagoServicio _servicios = null!;
        private List<TipoDePago> list = null!;
        public FrmTipoDePago()
        {
            InitializeComponent();
            _servicios = new TipoDePagoServicio();
        }

        private void FrmTipoDePago_Load(object sender, EventArgs e)
        {
            try
            {
                list = _servicios.GetLista();
                MostrarDatosEnGrilla();

            }
            catch (Exception )
            {
                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.limpiarGrilla(dgvdatos);
            foreach (TipoDePago tipoDePago in list)
            {
                var r = GridHelper.ConstruirFila(dgvdatos);
                GridHelper.SetearFila(r, tipoDePago);
                GridHelper.AgregarFila(r, dgvdatos);
            }
        }

        private void TsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {

            FrmTipoDePagoAE frm = new FrmTipoDePagoAE() { Text = "Agrgar nuevo pago" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            TipoDePago? tipoDePago = frm.GetTipoDePago();
            if (tipoDePago is null) return;
            try
            {
                if (!_servicios.Existe(tipoDePago))
                {
                    _servicios.Guardar(tipoDePago);
                    DataGridViewRow r = GridHelper.ConstruirFila(dgvdatos);
                    GridHelper.SetearFila(r, tipoDePago);
                    GridHelper.AgregarFila(r, dgvdatos);
                    MessageBox.Show("Tipo de pago agregado", "informacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("no se puede duplicar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvdatos.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgvdatos.SelectedRows[0];
            TipoDePago? tip = r.Tag as TipoDePago;
            if (tip is null) return;
            DialogResult dr = MessageBox.Show($"¿desead borrar este monto de {tip}?",
                "confirmar el borado",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                _servicios.Borrar(tip.TipoDePagoId);
                GridHelper.QuitarFila(r, dgvdatos);
                MessageBox.Show("pago Eliminado", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvdatos.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgvdatos.SelectedRows[0];
            TipoDePago? tip = r.Tag as TipoDePago;
            if (tip is null) return;
            TipoDePago? tipoEditado = tip.Clonar();
            FrmTipoDePagoAE frm = new FrmTipoDePagoAE() { Text = "Agrgar nuevo pago" };
            frm.SetTipoDePago(tipoEditado);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            tipoEditado = frm.GetTipoDePago();
            if (tipoEditado is null) return;
            try
            {
                if (!_servicios.Existe(tipoEditado))
                {
                    _servicios.Guardar(tipoEditado);
                    GridHelper.SetearFila(r, tipoEditado);
                    MessageBox.Show("Tipo de pago editado", "informacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("no se puede editar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
