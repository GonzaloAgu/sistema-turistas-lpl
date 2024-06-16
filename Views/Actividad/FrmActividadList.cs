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
    public partial class FrmActividadList : FormBase {
        private string _criterio = null;
        private List<Actividad> _listado;

        public FrmActividadList() {
            InitializeComponent();
        }

        public void ShowListado(List<Actividad> listado, FormBase Invoker, string criterio) {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.ActividadesGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Actividad>(listado);
            var source = new BindingSource(bindingList, null);
            this.ActividadesGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        
        private void Actividades_DataBinding(object sender, DataGridViewBindingCompleteEventArgs e) {
            
            for (int i = 0; i < this.ActividadesGrd.Rows.Count; ++i) {
                DataGridViewRow item = this.ActividadesGrd.Rows[i];
                
                // Esto debe hacerse para todas las columnas que sean una referencia a otro objeto.
                Actividad actividadObj = item.DataBoundItem as Actividad; 
        
                item.Cells["TipoActividad"].Value = actividadObj.TipoActividadObj.Nombre;;
                item.Cells["Descripcion"].Value = actividadObj.TipoActividadObj.Descripcion;
            }
        }

        private void ActividadesGrd_DoubleClick(object sender, EventArgs e) {
            if (this.ActividadesGrd.SelectedRows.Count > 0) {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmActividadAM frm = new FrmActividadAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarActividad(this, (this.ActividadesGrd.SelectedRows[0].DataBoundItem as Actividad));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev) {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK) {
                var selAnt = ActividadesGrd.SelectedRows[0].Index;
                this.ActividadesGrd.DataSource = Actividad.FindAllStatic(_criterio, (a1, a2) => a1.TipoActividadObj.Nombre.CompareTo(a2.TipoActividadObj.Nombre));
                ActividadesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Actividad actualizada", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
