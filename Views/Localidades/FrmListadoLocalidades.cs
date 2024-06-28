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

namespace TurApp.Views
{
    public partial class FrmListadoLocalidades : FormBase
    {
        public FrmListadoLocalidades()
        {
            InitializeComponent();
        }
        

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }


        private void FrmListadoLocalidades_Load(object sender, EventArgs e)
        {
            
            this.LocalidadesGrd.AutoGenerateColumns = false;
            this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(null, (p1, p2) => (p1.Codigo).CompareTo(p2.Codigo));
        }


        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //
            string criterio = null;
            if (this.CodPostalCheckBox.Checked)
                criterio = "cod_postal=" + int.Parse(this.CodigoPostalTxt.Text);


            if (this.NombreLocalidadChek.Checked){
                if(criterio != null)
                    criterio += String.Format("AND nombre ILIKE '%{0}%'", NombreLocalidadTxt.Text);
                else
                    criterio = String.Format("nombre ILIKE '%{0}%'", NombreLocalidadTxt.Text);
            }
             
            try
            {
                this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LocalidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.LocalidadesGrd.Rows)
            {
                rw.Cells[0].Value = (rw.DataBoundItem as Localidad).Codigo;

            }
        }

     

        private void LocalidadesGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmLocalidadAM frmpac = new FrmLocalidadAM();
            Localidad pac = (this.LocalidadesGrd.SelectedRows[0].DataBoundItem as Localidad);
            frmpac.ShowModificarLocalidad(pac);
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implementar funcionalidad...!", "falta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void NombreLocalidadChek_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreLocalidadTxt.Enabled = this.NombreLocalidadChek.Checked;
            CodPostalCheckBox.Enabled = !NombreLocalidadChek.Checked;
        }

        private void CodPostalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.CodigoPostalTxt.Enabled = this.CodPostalCheckBox.Checked;
            NombreLocalidadChek.Enabled = !CodPostalCheckBox.Checked;
            
        }

        private void LocalidadesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExportarBtn_Click_1(object sender, EventArgs e)
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
                        archivo.WriteLine("CodigoPostal,Nombre");
                        foreach (Localidad loc in (LocalidadesGrd.DataSource as List<Localidad>))
                            archivo.WriteLine(String.Format("{0},{1}", loc.Codigo, loc.Nombre));
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