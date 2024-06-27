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
    public partial class FrmFacturasTurista : FormBase
    {
        private Turista _turista;

        public FrmFacturasTurista(Turista tur)
        {
            _turista = tur;
            InitializeComponent();
        }

        private void FrmFacturasTurista_Load(object sender, EventArgs e)
        {
            facturasGrd.DataSource = FacturaTurista.FindAllStatic("dni_turista=" + _turista.NroDocumento, null);
            this.Text = "Listado de facturas de " + _turista.Nombre;
        }

        private void facturasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in facturasGrd.Rows)
            {
                FacturaTurista factura = row.DataBoundItem as FacturaTurista;
                row.Cells["FormaPago"].Value = factura.FormaPagoObj.Forma;

                // Calculo importe total de la factura
                try
                {
                    String criterio = String.Format("nro_fact={0} AND serie_fact={1} AND letra_fact='{2}'", factura.Nro, factura.Serie, factura.Letra);
                    List<DetalleFacturaTurista> detalles = DetalleFacturaTurista.FindAllStatic(criterio, null);

                    int importe = 0;
                    foreach (DetalleFacturaTurista det in detalles)
                    {
                        importe += (int)det.Importe;
                    }
                    row.Cells["Importe"].Value = "$" + importe;
                }
                catch (Exception ex)
                {
                    row.Cells["Importe"].Value = "$0";
                    MessageBox.Show(ex.Message, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void facturasGrd_DoubleClick(object sender, EventArgs e)
        {
            if (facturasGrd.SelectedRows.Count != 1)
                return;

            FacturaTurista fact = facturasGrd.SelectedRows[0].DataBoundItem as FacturaTurista;
            FrmListaDetalles form = new FrmListaDetalles(fact);
            form.ShowDialog();
        }


        

        
    }
}
