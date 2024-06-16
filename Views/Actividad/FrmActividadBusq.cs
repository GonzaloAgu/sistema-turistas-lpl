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
    public partial class FrmActividadBusq : FormBase {
        public FrmActividadBusq() {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm) {

        }

        private void BuscarBtn_Click(object sender, EventArgs e) {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if (this.TipoActChk.Checked) {
                criterio = String.Format("cod_tipo_actividad = {0}", tipoActCb.SelectedValue );
            }

            if (this.TransporteChk.Checked) {
                if (criterio == null)
                    criterio = String.Format("cod_transporte = {0} ", TransporteCbo.SelectedValue);
                else
                    criterio += String.Format(" and cod_transporte = {0}", TransporteCbo.SelectedValue);
            }

            if (this.NivelChk.Checked) {
                if (criterio == null)
                    criterio = String.Format("nivel = {0} ", NivelTxt.Text);
                else
                    criterio += String.Format(" and nivel = {0} ", NivelTxt.Text);
            }

            try {
                var lista = Actividad.FindAllStatic(criterio, null);
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0) {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmActividadList frm = new FrmActividadList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex) {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void NombresChk_CheckedChanged(object sender, EventArgs e) {
            this.NivelTxt.Enabled = this.NivelChk.Checked;
        }


        private void CancelarBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void ShowBuscar() {
            this.Show();
        }

        private void PaisChk_CheckedChanged(object sender, EventArgs e) {
            this.TransporteCbo.Enabled = this.TransporteChk.Checked;
        }

        private void FrmActividadBusq_Load(object sender, EventArgs e) {
            TransporteCbo.DataSource = Transporte.FindAllStatic(null, (t1, t2) => t1.Descripcion.CompareTo(t2.Descripcion));
            TransporteCbo.SelectedIndex = -1;
            tipoActCb.DataSource = TipoActividad.FindAllStatic(null, (t1, t2) => t1.Nombre.CompareTo(t2.Nombre));
            tipoActCb.SelectedIndex = -1;
        }

        private void FrmActividadBusq_Activated(object sender, EventArgs e) {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void TipoActCheckedChanged(object sender, EventArgs e) {
            this.tipoActCb.Enabled = this.TipoActChk.Checked;
        }

        private void Transporte_CheckChange(object sender, EventArgs e) {
            this.TransporteCbo.Enabled = this.TransporteChk.Checked;
        }

        private void Nivel_CheckChange(object sender, EventArgs e) {
            this.NivelTxt.Enabled = this.NivelChk.Checked;
        }

        private void Nivel_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.')) {
                e.Handled = true;
            }  
        }


    }
}

