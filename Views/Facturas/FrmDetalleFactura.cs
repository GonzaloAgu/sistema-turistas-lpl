using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;

namespace TurApp.Views {
    public partial class FrmDetalleFactura : FormBase {
        private FacturaTurista _factura = null;
        private int _renglon;
        private int _importe;

        public FrmDetalleFactura(FacturaTurista factura, int renglon) {
            _factura = factura;
            _renglon = renglon;
            InitializeComponent();
        }

        private void FrmDetalleFactura_Load(object sender, EventArgs e) {
            LoadComboBox(Paquete.FindAllStatic(null, null), PaqueteCbo);
            importeLabel.Text = "";
        }

        private void anadirBtn_Click(object sender, EventArgs e) {
            if (PaqueteCbo.SelectedIndex == -1) {
                MessageBox.Show("Faltan seleccionar un paquete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Paquete paquete = (PaqueteCbo.SelectedValue as Paquete);
            DetalleFacturaTurista detalle = new DetalleFacturaTurista();
            detalle.CodPaquete = paquete.Codigo;
            detalle.NroRenglon = _renglon;
            detalle.NroFactura = _factura.Nro;
            detalle.SerieFactura = _factura.Serie;
            detalle.LetraFactura = _factura.Letra;
            detalle.Importe = _importe;

            try
            {
                detalle.SaveObj();
                MessageBox.Show("Operación exitosa", "Detalle agregado a la factura", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaqueteCbo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (PaqueteCbo.SelectedIndex == -1)
                return;

            List<PaqueteActividad> actividades = PaqueteActividad.FindAllStatic("cod_paquete=" + (PaqueteCbo.SelectedValue as Paquete).Codigo, null);

            int importe = 0;
            foreach (PaqueteActividad paqact in actividades)
            {
                importe += (int)paqact.ActividadObj.Importe;
            }

            _importe = importe;
            importeLabel.Text = "Importe del paquete: $" + importe + " (" + actividades.Count + " actividades)";
        }

    }
}
