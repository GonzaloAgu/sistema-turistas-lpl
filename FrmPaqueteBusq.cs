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
    public partial class FrmPaqueteBusq : FormBase
    {
        public FrmPaqueteBusq()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if (this.CodigoChk.Checked)
            {
                criterio = String.Format("codigo = {0}", CodigoTxt.Text);
            }

            try
            {
                var lista = Paquete.FindAllStatic(criterio, (p1, p2) => (p1.Codigo).CompareTo(p2.Codigo));
                //var lista = Paquete.FindAllStatic(criterio, null);
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmPaqueteList frm = new FrmPaqueteList();
                frm.ShowListado(lista, this, criterio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  
        private void CodigoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CodigoTxt.Enabled = this.CodigoChk.Checked;
        }


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void FrmTuristaBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void FrmActividadBusq_Load(object sender, EventArgs e) {

        }

    }
}
