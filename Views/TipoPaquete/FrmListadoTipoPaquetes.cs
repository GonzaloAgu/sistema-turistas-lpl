using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;
using System.IO;

namespace TurApp.Views
{
    public partial class FrmListadoTipoPaquetes : FormBase
    {
        public FrmListadoTipoPaquetes()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }

        private void FrmListadoTipoPaquetes_Load(object sender, EventArgs e)
        {            
            //LoadComboBox( Pais.FindAllStatic(null , (l1,l2)=> l1.Nombre.CompareTo(l2.Nombre)) , this.PaisCbo, addSeleccion: true);
                                    
            this.TipoPaquetesGrd.AutoGenerateColumns = false;
            this.TipoPaquetesGrd.DataSource = TipoPaquete.FindAllStatic (null, (p1,p2)=> (p1.Nombre).CompareTo(p2.Nombre));
        }

        private void CodigoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CodigoTxt.Enabled = CodigoChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //
            string criterio = null;

            if (NombreChk.Checked && NombreTxt.Text != "")
                criterio = String.Format("nombre ILIKE '%{0}%'", NombreTxt.Text);
            
            if (this.CodigoChk.Checked && this.CodigoTxt.Text != "")
            {
                
                if (criterio != null)
                {
                    criterio += " and codigo = " + CodigoTxt.Text;

                }
                else
                    criterio = "codigo = " + CodigoTxt.Text;
            }
            this.TipoPaquetesGrd.DataSource = TipoPaquete.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));            
        }

        private void TipoPaquetesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.TipoPaquetesGrd.Rows)
            {
                rw.Cells[1].Value = (rw.DataBoundItem as TipoPaquete).Codigo;
                rw.Cells[2].Value = (rw.DataBoundItem as TipoPaquete).Nombre;
                rw.Cells[3].Value = (rw.DataBoundItem as TipoPaquete).Descripcion;
                rw.Cells[4].Value = (rw.DataBoundItem as TipoPaquete).Duracion;
                rw.Cells[5].Value = (rw.DataBoundItem as TipoPaquete).Nivel;
            }
        }

        private void TipoPaquetesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TipoPaquetesGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmTipoPaqueteAM frmpac = new FrmTipoPaqueteAM();
            TipoPaquete pac  =  (this.TipoPaquetesGrd.SelectedRows[0].DataBoundItem as TipoPaquete);
            frmpac.ShowModificarTipoPaquete(pac);
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
                        archivo.WriteLine("codigo,nombre,descripcion,duracion,nivel");
                        foreach (TipoPaquete tp in (TipoPaquetesGrd.DataSource as List<TipoPaquete>))
                            archivo.WriteLine(String.Format("{0},{1},{2},{3},{4}", tp.Codigo, tp.Nombre, tp.Descripcion, tp.Duracion, tp.Nivel));
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
