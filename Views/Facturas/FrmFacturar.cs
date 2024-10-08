﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;

namespace TurApp.Views {
    public partial class FrmFacturar : FormBase {
        private FacturaTurista _factura = null;
        private int _renglones = 1;

        public FrmFacturar() {
            InitializeComponent();
        }

        private void AnadirBtn_Click(object sender, EventArgs e) {
            FrmDetalleFactura form = new FrmDetalleFactura(_factura, _renglones);
            form.ShowDialog();
            finalizarBtn.Enabled = true;
            _renglones++;
        }

        private void FrmFacturar_Load(object sender, EventArgs e) {
            LoadComboBox(Turista.FindAllStatic(null, (t1, t2) => t1.Nombre.CompareTo(t2.Nombre)), TuristaCbo);
            LoadComboBox(FormaPago.FindAllStatic(null, (f1, f2) => f1.Forma.CompareTo(f2.Forma)), FormaPagoCbo, "Forma");
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            if (nroFacturaTxt.Text == "" || nroSerieTxt.Text == "" || LetraCbo.SelectedIndex == -1 || TuristaCbo.SelectedIndex == -1 || FormaPagoCbo.SelectedIndex == -1 || detallePagoTxt.Text == "")
            {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_factura == null)
            {
                _factura = new FacturaTurista();
                _factura.DniTurista = (TuristaCbo.SelectedValue as Turista).NroDocumento;
                _factura.CodFormaPago = (FormaPagoCbo.SelectedValue as FormaPago).Codigo;
                _factura.Nro = Int32.Parse(nroFacturaTxt.Text);
                _factura.Serie = Int32.Parse(nroSerieTxt.Text);
                _factura.Letra = LetraCbo.GetItemText(LetraCbo.SelectedItem);
                _factura.Fecha = DateTime.Now;
                _factura.DetallePago = detallePagoTxt.Text;

                try
                {
                    if (nroFacturaTxt.Text == "" || nroSerieTxt.Text == "" || LetraCbo.SelectedIndex == -1 || TuristaCbo.SelectedIndex == -1 || FormaPagoCbo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _factura.SaveObj();
                    GenerarBtn.Enabled = false;
                    AnadirBtn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
