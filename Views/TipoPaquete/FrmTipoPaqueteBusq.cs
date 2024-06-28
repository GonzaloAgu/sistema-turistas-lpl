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
    public partial class FrmTipoPaqueteBusq : FormBase
    {
        public FrmTipoPaqueteBusq()
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
            if (this.CodigoChk.Checked && this.CodigoTxt.Text != "")
            {
                criterio = String.Format("codigo = {0}", CodigoTxt.Text);
            }

            if (this.NivelChk.Checked && this.NivelTxt.Text != "")
            {
                if(criterio==null)
                    criterio = String.Format("nivel = {0} ", NivelTxt.Text);
                else
                    criterio += String.Format(" and nivel = {0}", NivelTxt.Text);
            }

            try
            {
                var lista = TipoPaquete.FindAllStatic(criterio, (p1, p2) => (p1.Codigo).CompareTo(p2.Codigo));
                MainView.Instance.Cursor = Cursors.Default;
                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmTipoPaqueteList frm = new FrmTipoPaqueteList();
                frm.ShowListado(lista, this, null);
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

        private void NivelChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NivelTxt.Enabled = this.NivelChk.Checked;
        }


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void PaisChk_CheckedChanged(object sender, EventArgs e)
        {
            //this.PaisCbo.Enabled = this.NivelChk.Checked;
        }

        private void FrmTipoPaqueteBusq_Load(object sender, EventArgs e)
        {            
            //PaisCbo.DataSource = Pais.FindAllStatic(null,(loc1,loc2)=>loc1.Nombre.CompareTo(loc2.Nombre) );
            //PaisCbo.SelectedIndex = -1;
        }

        private void FrmTipoPaqueteBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

      

    }
}
