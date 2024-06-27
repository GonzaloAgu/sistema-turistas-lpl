using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;

namespace TurApp.Views {
    public partial class FrmListadoActividad : FormBase {
        public FrmListadoActividad() {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm) {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void NivelChk_CheckedChanged(object sender, EventArgs e) {
            this.NivelTxt.Enabled = this.NivelChk.Checked;
        }

        private void FrmListadoActividades_Load(object sender, EventArgs e) {
            LoadComboBox( TipoActividad.FindAllStatic(null, (ta1, ta2) => ta1.Descripcion.CompareTo(ta2.Descripcion)), this.TipoActividadCbo, addSeleccion: true);
            ActividadesGrd.AutoGenerateColumns = false;
            ActividadesGrd.DataSource = Actividad.FindAllStatic(null, (a1, a2) => a1.TipoActividadObj.Nombre.CompareTo(a2.TipoActividadObj.Nombre));
        }

        private void TipoAct_CheckedChange(object sender, EventArgs e) {
            this.TipoActividadCbo.Enabled = TipoActChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e) {
            
            string criterio = null;

            if (NivelChk.Checked && NivelTxt.Text != "") {
                criterio = "nivel=" + NivelTxt.Text;
            }
            if (this.TipoActChk.Checked && this.TipoActividadCbo.SelectedIndex != -1) {
                if (criterio != null)
                    criterio += " and cod_tipo_actividad = " + (TipoActividadCbo.SelectedValue as TipoActividad).Codigo;
                else
                    criterio = " cod_tipo_actividad = " + (TipoActividadCbo.SelectedValue as TipoActividad).Codigo;
            }
            ActividadesGrd.DataSource = Actividad.FindAllStatic(criterio, (a1, a2) => a1.TipoActividadObj.Nombre.CompareTo(a2.TipoActividadObj.Nombre));
        }

        private void ActividadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (DataGridViewRow item in this.ActividadesGrd.Rows) {

                // Esto debe hacerse para todas las columnas que sean una referencia a otro objeto.
                Actividad actividadObj = item.DataBoundItem as Actividad;

                item.Cells["TipoActCol"].Value = actividadObj.TipoActividadObj.Nombre; ;
                item.Cells["DescripcionCol"].Value = actividadObj.TipoActividadObj.Descripcion;
                item.Cells["TransporteCol"].Value = actividadObj.TransporteObj.Descripcion;
            }
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo TXT (*.txt)|*.txt|Archivo CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar archivo como";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter archivo = new StreamWriter(saveFileDialog.FileName))
                    {
                        archivo.WriteLine("Codigo,CodigoTipoActividad,CodigoTransporte,");
                        foreach (Actividad act in (ActividadesGrd.DataSource as List<Actividad>))
                            archivo.WriteLine(String.Format("{0},{1},{2}", act.Codigo, act.CodTipoActividad, act.CodTransporte));
                        MessageBox.Show("Archivo guardado exitosamente en: " + saveFileDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
