using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP03.Entidades;

namespace TP03.Windows.helper
{
    public static class GridHelper
    {
        public static void limpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }
        /// <summary>
        /// hive lo que puede
        /// </summary>
        public static void SetearFila(DataGridViewRow r, TipoDePago tipoDePago)
        {
            r.Cells[0].Value = tipoDePago.TipoDePagoId;
            r.Cells[1].Value = tipoDePago.Monto;

            r.Tag = tipoDePago;
        }
        public static void AgregarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Add(r);
        }
        public static void QuitarFila(DataGridViewRow r, DataGridView grid)
        {

            grid.Rows.Remove(r);

        }
    }
}
