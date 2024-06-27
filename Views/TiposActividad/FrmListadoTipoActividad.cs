﻿﻿using System;
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
    public partial class FrmListadoTipoActividad : FormBase
    {
        public FrmListadoTipoActividad()
        {
            InitializeComponent();
        }

        /*
        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }
        */


        private void FrmListadoTipoActividad_Load(object sender, EventArgs e)
        {

            this.TipoActividadGrd.AutoGenerateColumns = false;
            this.TipoActividadGrd.DataSource = TipoActividad.FindAllStatic(null, (p1, p2) => (p1.Codigo).CompareTo(p2.Codigo));
        }


        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //
            string criterio = null;
            if (this.NombreChk.Checked)
                criterio += " nombre = " + int.Parse(this.NombreTxt.Text);
           
            try
            {
                this.TipoActividadGrd.DataSource = TipoActividad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TipoActividadGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.TipoActividadGrd.Rows)
            {
                rw.Cells[0].Value = (rw.DataBoundItem as TipoActividad).Nombre;
                rw.Cells[1].Value = (rw.DataBoundItem as TipoActividad).Codigo;
                rw.Cells[2].Value = (rw.DataBoundItem as TipoActividad).Descripcion;
                rw.Cells[3].Value = (rw.DataBoundItem as TipoActividad).Duracion;
                rw.Cells[4].Value = (rw.DataBoundItem as TipoActividad).Nivel;

            }
        }



        private void TipoActividadGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmTipoActividadAM frmpac = new FrmTipoActividadAM();
            TipoActividad pac = (this.TipoActividadGrd.SelectedRows[0].DataBoundItem as TipoActividad);
            //frmpac.ShowModificarLocalidad(pac);
            frmpac.ShowModificarTipoActividad(pac);
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implementar funcionalidad...!", "falta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /*
        private void NombreLocalidadChek_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreLocalidadTxt.Enabled = this.NombreLocalidadChek.Checked;
            CodPostalCheckBox.Enabled = !NombreLocalidadChek.Checked;
        }
        */
        private void NombreChek_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
            //CodPostalCheckBox.Enabled = !NombreLocalidadChek.Checked;
        }

      

        private void LocalidadesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TipoActividadGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exportarBtn_Click_1(object sender, EventArgs e)
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
                        archivo.WriteLine("Codigo, Duracion, Descripcion,");
                        foreach (TipoActividad ta in (TipoActividadGrd.DataSource as List<TipoActividad>))
                            archivo.WriteLine(String.Format("{0},{1},{2}", ta.Codigo, ta.Duracion, ta.Descripcion));
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