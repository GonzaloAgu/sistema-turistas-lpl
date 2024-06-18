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
        public FrmDetalleFactura(FacturaTurista factura) {
            _factura = factura;
            InitializeComponent();
        }

        private void FrmDetalleFactura_Load(object sender, EventArgs e) {
            LoadComboBox(Paquete.FindAllStatic(null, null), PaqueteCbo);
        }

        private void anadirBtn_Click(object sender, EventArgs e) {
            if (PaqueteCbo.SelectedIndex == -1 || ImporteTxt.Text == "") {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetalleFacturaTurista detalle = new DetalleFacturaTurista();
            detalle.CodPaquete = (PaqueteCbo.SelectedValue as Paquete).Codigo;
            detalle.Importe = Int32.Parse(ImporteTxt.Text);
            detalle.NroFactura = _factura.Nro;
            detalle.SerieFactura = _factura.Serie;
            detalle.LetraFactura = _factura.Letra;
            detalle.SaveObj();
        }
    }
}
