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
                criterio = String.Format("codigo={0}", CodigoTxt.Text);
            }

            if (tipoPaqChk.Checked)
            {
                if(criterio != null)
                    criterio += String.Format("AND cod_tipo_paquete={0}", (tipoPaqCbo.SelectedValue as TipoPaquete).Codigo);
                else
                    criterio = String.Format("cod_tipo_paquete={0}", (tipoPaqCbo.SelectedValue as TipoPaquete).Codigo);
            }

            if (agenciaChk.Checked)
            {
                if (criterio != null)
                    criterio += String.Format("AND cod_agencia={0}", (agenciaCbo.SelectedValue as Agencia).Codigo);
                else
                    criterio = String.Format("cod_agencia={0}", (agenciaCbo.SelectedValue as Agencia).Codigo);
            }

            if (turistaChk.Checked)
            {
                if (criterio != null)
                    criterio += String.Format("AND dni_turista={0}", (turistaCbo.SelectedValue as Turista).NroDocumento);
                else
                    criterio = String.Format("dni_turista = {0}", (turistaCbo.SelectedValue as Turista).NroDocumento);
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
            LoadComboBox(TipoPaquete.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre)), tipoPaqCbo, "Nombre");
            tipoPaqCbo.SelectedIndex = -1;

            LoadComboBox(Agencia.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre)), agenciaCbo, "Nombre");
            agenciaCbo.SelectedIndex = -1;

            LoadComboBox(Turista.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre)), turistaCbo, "Nombre");
            agenciaCbo.SelectedIndex = -1;
        }

        private void tipoPaqChk_CheckedChanged(object sender, EventArgs e)
        {
            tipoPaqCbo.Enabled = tipoPaqChk.Checked;
        }

        private void agenciaChk_CheckedChanged(object sender, EventArgs e)
        {
            agenciaCbo.Enabled = agenciaChk.Checked;
        }

        private void turistaChk_CheckedChanged(object sender, EventArgs e)
        {
            turistaCbo.Enabled = turistaChk.Checked;
        }

    }
}
