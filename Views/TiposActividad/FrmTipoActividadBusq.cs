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
    public partial class FrmTipoActividadBusq : FormBase
    {
        public FrmTipoActividadBusq()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            // Configuración de permisos, implementar según sea necesario
        }

        private void buscarbtn_Click_1(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            string criterio = null;

            if (this.nombreChk.Checked)
            {
                criterio = String.Format("nombre LIKE '%{0}%'", nombretxt.Text);
                //criterio = String.Format("nombre = {0}", nombretxt.Text);
            }

            try
            {
                var lista = TipoActividad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con el criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // invocar Formulario de Listado.
                    FrmTipoActividadList frm = new FrmTipoActividadList();
                    frm.ShowListado(lista, this, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.nombretxt.Enabled = this.nombreChk.Checked;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void FrmTipoActividadBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        
    }
}
    


     

        