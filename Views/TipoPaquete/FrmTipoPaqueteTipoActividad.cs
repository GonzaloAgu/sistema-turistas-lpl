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
    public partial class FrmTipoPaqueteTipoActividad : FormBase
    {
        public FrmTipoPaqueteTipoActividad()
        {
            InitializeComponent();
        }

        private void FrmAgenciaTipoPaquete_Load(object sender, EventArgs e)
        {
            LoadComboBox(TipoPaquete.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre)), tipoPaqueteCbo, "Nombre");
            LoadComboBox(TipoActividad.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre)), tipoActividadCbo);
            tipoPaqueteCbo.SelectedIndex = -1;
            tipoActividadCbo.SelectedIndex = -1;
        }

        private void tipoActividadGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            for (int i = 0; i < this.tipoActividadGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.tipoActividadGrd.Rows[i];
                TipoPaqueteTipoActividad tipoPaqTipoAct = item.DataBoundItem as TipoPaqueteTipoActividad;
                item.Cells[0].Value = tipoPaqTipoAct.CodTipoPaquete;
                item.Cells[1].Value = tipoPaqTipoAct.TipoPaqueteObj.Nombre;
            }
        }

        private void tipoPaqueteCbo_SelectedValueChanged(object sender, EventArgs e)
        {
            mainGroup.Visible = tipoPaqueteCbo.SelectedIndex != -1;
            TipoPaquete tipopPaquete = tipoPaqueteCbo.SelectedItem as TipoPaquete;
            tipoActividadGrd.AutoGenerateColumns = false;

            if (tipopPaquete != null) {
                gridLbl.Text = "Tipos de paquete ofrecidos por " + tipopPaquete.Nombre;
                List<TipoPaqueteTipoActividad> lista = TipoPaqueteTipoActividad.FindAllStatic("cod_tipoPaquete=" + tipopPaquete.Codigo, null);
                tipoActividadGrd.DataSource = lista;
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anadirBtn_Click(object sender, EventArgs e)
        {
            if (tipoPaqueteCbo.SelectedIndex == -1 || tipoActividadCbo.SelectedIndex == -1) {
                MessageBox.Show("Falta seleccionar un tipo de actividad", "Faltan datos...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                TipoPaqueteTipoActividad tpta = new TipoPaqueteTipoActividad();
                tpta.CodTipoPaquete = (tipoPaqueteCbo.SelectedItem as TipoPaquete).Codigo;
                tpta.CodTipoActividad = (tipoActividadCbo.SelectedItem as TipoActividad).Codigo;
                tpta.SaveObj();
                MessageBox.Show("Tipo de actividad añadido con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tipoActividadGrd.DataSource = TipoPaqueteTipoActividad.FindAllStatic("cod_tipoPaquete=" + tpta.CodTipoPaquete, null);
            }
            catch (Exception exex)
            {
                MessageBox.Show("El tipo de paquete ingresado ya está vinculado o se produjo otro error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }




        public ComboBox tipoActividadCbo { get; set; }



        public ComboBox tipoPaqueteCbo { get; set; }
    }
}
