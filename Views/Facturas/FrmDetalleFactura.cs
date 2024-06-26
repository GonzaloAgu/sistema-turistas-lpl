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
        public FrmDetalleFactura(FacturaTurista factura, int renglon) {
            _factura = factura;
            _renglon = renglon;
            InitializeComponent();
        }

        private void FrmDetalleFactura_Load(object sender, EventArgs e) {
            LoadComboBox(Paquete.FindAllStatic(null, null), PaqueteCbo, "Codigo");
        }

        private void anadirBtn_Click(object sender, EventArgs e) {
            if (PaqueteCbo.SelectedIndex == -1 || ImporteTxt.Text == "") {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetalleFacturaTurista detalle = new DetalleFacturaTurista();
            detalle.CodPaquete = (PaqueteCbo.SelectedValue as Paquete).Codigo;
            detalle.Importe = Int32.Parse(ImporteTxt.Text);
            detalle.NroRenglon = _renglon;
            detalle.NroFactura = _factura.Nro;
            detalle.SerieFactura = _factura.Serie;
            detalle.LetraFactura = _factura.Letra;
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
    }
}
