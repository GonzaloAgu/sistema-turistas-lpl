using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;

namespace TurApp.Views
{
    public partial class FrmListaDetalles : FormBase
    {
        private FacturaTurista _factura;
        public FrmListaDetalles(FacturaTurista factura)
        {
            _factura = factura;
            InitializeComponent();
        }

        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListaDetalles_Load(object sender, EventArgs e)
        {
            facturaTxt.Text = String.Format("Factura Nº{0} - Serie {1} - Tipo {2}", _factura.Nro, _factura.Serie, _factura.Letra);
            TuristaTxt.Text = String.Format("Turista: {0} - DNI: {1}", _factura.TuristaObj.Nombre, _factura.TuristaObj.NroDocumento);

            detallesGrd.AutoGenerateColumns = false;
            string criterio = String.Format("nro_fact={0} AND serie_fact={1} AND letra_fact='{2}'", _factura.Nro, _factura.Serie, _factura.Letra);
            detallesGrd.DataSource = DetalleFacturaTurista.FindAllStatic(criterio, (d1, d2) => d1.NroRenglon.CompareTo(d2.NroRenglon));
        }

        private void detallesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow det in detallesGrd.Rows) {
                det.Cells["NombreTipoPaquete"].Value = (det.DataBoundItem as DetalleFacturaTurista).PaqueteObj.TipoPaqueteObj.Nombre;
                det.Cells["DescripcionTipoPaquete"].Value = (det.DataBoundItem as DetalleFacturaTurista).PaqueteObj.TipoPaqueteObj.Descripcion;
                det.Cells["Importe"].Value = "$" + (det.DataBoundItem as DetalleFacturaTurista).Importe;
            }
        }
    }
}
