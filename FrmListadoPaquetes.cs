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
    public partial class FrmListadoPaquetes : FormBase
    {
        public FrmListadoPaquetes()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void TipoPaqChk_CheckedChanged(object sender, EventArgs e)
        {
            this.TipoPaqTxt.Enabled = this.TipoPaqChk.Checked;
        }

        private void FrmListadoPaquetes_Load(object sender, EventArgs e)
        {            
            //LoadComboBox( Pais.FindAllStatic(null , (l1,l2)=> l1.Nombre.CompareTo(l2.Nombre)) , this.NivelTxt, addSeleccion: true);
                                    
            this.PaquetesGrd.AutoGenerateColumns = false;
            this.PaquetesGrd.DataSource = Paquete.FindAllStatic (null, (p1,p2)=> (p1.Codigo).CompareTo(p2.Codigo));
        }

        private void PaisChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NivelTxt.Enabled = NivelChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //
            string criterio = null;
            
            if (this.NivelChk.Checked && this.NivelTxt.Text != "")
            {
                if (criterio != null)
                {
                    criterio += " and nivel = " + Convert.ToInt32(NivelTxt.Text);
                }
                else
                    criterio = "nivel = " + Convert.ToInt32(NivelTxt.Text);
            }
            if (this.TipoPaqChk.Checked && this.TipoPaqTxt.Text != "")
            {
                if (criterio != null)
                {
                    criterio += " and cod_tipo_paquete = " + Convert.ToInt32(TipoPaqTxt.Text);
                }
                else
                    criterio = "cod_tipo_paquete = " + Convert.ToInt32(TipoPaqTxt.Text);
            }
            this.PaquetesGrd.DataSource = Paquete.FindAllStatic(criterio, (p1, p2) => (p1.Codigo).CompareTo(p2.Codigo));            
        }

        private void PaquetesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.PaquetesGrd.Rows)
            {
                rw.Cells[0].Value = (rw.DataBoundItem as Paquete).TipoPaqueteObj.Codigo;
                rw.Cells[1].Value = (rw.DataBoundItem as Paquete).AgenciaObj.Codigo;
                rw.Cells[2].Value = (rw.DataBoundItem as Paquete).Fecha;
                rw.Cells[3].Value = (rw.DataBoundItem as Paquete).TuristaObj.NroDocumento;
                rw.Cells[4].Value = (rw.DataBoundItem as Paquete).Nivel;
                rw.Cells[5].Value = (rw.DataBoundItem as Paquete).DestinoObj.Codigo;
            }
        }

        private void PaquetesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PaquetesGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmPaqueteAM frmpac = new FrmPaqueteAM();
            Paquete pac  =  (this.PaquetesGrd.SelectedRows[0].DataBoundItem as Paquete);
            frmpac.ShowModificarPaquete(pac);
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implementar funcionalidad...!", "falta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
