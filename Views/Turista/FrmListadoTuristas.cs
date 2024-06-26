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
    public partial class FrmListadoTuristas : FormBase
    {
        public FrmListadoTuristas()
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

        private void FrmListadoTuristas_Load(object sender, EventArgs e)
        {            
            LoadComboBox( Pais.FindAllStatic(null , (l1,l2)=> l1.Nombre.CompareTo(l2.Nombre)) , this.PaisCbo, addSeleccion: true);
                                    
            this.TuristasGrd.AutoGenerateColumns = false;
            this.TuristasGrd.DataSource = Turista.FindAllStatic (null, (p1,p2)=> (p1.Nombre).CompareTo(p2.Nombre));
        }

        private void PaisChk_CheckedChanged(object sender, EventArgs e)
        {
            this.PaisCbo.Enabled = PaisChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //
            string criterio = null;

            if (NombreChk.Checked && NombreTxt.Text != "")
                criterio = String.Format("nombre ILIKE '%{0}%'", NombreTxt.Text);
            
            if (this.PaisChk.Checked && this.PaisCbo.SelectedIndex != -1)
            {
                
                if (criterio != null)
                {
                    criterio += " and cod_pais = " + (PaisCbo.SelectedValue as Pais).Codigo;

                }
                else
                    criterio = "cod_pais = " + (PaisCbo.SelectedValue as Pais).Codigo;
            }
            this.TuristasGrd.DataSource = Turista.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));            
        }

        private void TuristasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.TuristasGrd.Rows)
            {
                rw.Cells[1].Value = (rw.DataBoundItem as Turista).Nombre;
                rw.Cells[2].Value = (rw.DataBoundItem as Turista).PaisObj.Nombre;
            }
        }

        private void TuristasGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TuristasGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmTuristaAM frmpac = new FrmTuristaAM();
            Turista pac  =  (this.TuristasGrd.SelectedRows[0].DataBoundItem as Turista);
            frmpac.ShowModificarTurista(pac);
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
                        archivo.WriteLine("dni,nombre,pais,");
                        foreach (Turista tur in (TuristasGrd.DataSource as List<Turista>))
                            archivo.WriteLine(String.Format("{0},{1},{2}", tur.NroDocumento, tur.Nombre, tur.PaisObj.Nombre));
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
