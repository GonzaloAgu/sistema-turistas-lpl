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
    public partial class FrmPaqueteActividad : FormBase
    {
        public FrmPaqueteActividad()
        {
            InitializeComponent();
        }

        private void FrmPaqueteActividad_Load(object sender, EventArgs e)
        {
            paqueteCbo.DataSource = Paquete.FindAllStatic(null, null);
            LoadComboBox(Actividad.FindAllStatic(null, null), ActividadCbo);
            paqueteCbo.SelectedIndex = -1;
            ActividadCbo.SelectedIndex = -1;
        }

        private void paqueteCbo_SelectedValueChanged(object sender, EventArgs e)
        {
            mainGroup.Visible = paqueteCbo.SelectedIndex != -1;
            Paquete paquete = paqueteCbo.SelectedItem as Paquete;
            ActividadesGrd.AutoGenerateColumns = false;
            
            if (paquete != null)
            {
                gridLbl.Text = "Actividades ofrecidas en el paquete " + paquete.TipoPaqueteObj.Nombre;
                ActividadesGrd.DataSource = PaqueteActividad.FindAllStatic("cod_paquete=" + paquete.Codigo, null);
            }
        }

        private void tipoPaqueteGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            for (int i = 0; i < this.ActividadesGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.ActividadesGrd.Rows[i];
                PaqueteActividad obj = item.DataBoundItem as PaqueteActividad;
                item.Cells[0].Value = obj.ActividadObj.TipoActividadObj.Nombre;
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fechaBtn_Click(object sender, EventArgs e)
        {
            Calendario.Visible = !Calendario.Visible;
        }

        private void anadirBtn_Click(object sender, EventArgs e)
        {
            if (paqueteCbo.SelectedIndex == -1 || ActividadCbo.SelectedIndex == -1 || ImporteTxt.Text == "")
            {
                MessageBox.Show("Falta rellenar algunos datos", "Faltan datos...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Calendario.SelectionStart == Calendario.SelectionEnd && Calendario.SelectionEnd.Date == DateTime.Today.Date) {
                MessageBox.Show("Falta seleccionar la fecha", "Faltan datos...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PaqueteActividad obj = new PaqueteActividad();
            obj.CodPaquete = (paqueteCbo.SelectedItem as Paquete).Codigo;
            obj.CodActividad = (ActividadCbo.SelectedItem as Actividad).Codigo;
            obj.Importe = int.Parse(ImporteTxt.Text);
            obj.Detalle = detalleTxt.Text;
            obj.FechaHoraDesde = Calendario.SelectionStart;
            obj.FechaHoraHasta = Calendario.SelectionEnd;

            try
            {
                
                obj.SaveObj();
                MessageBox.Show("Actividad añadida a paquete con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //tipoPaqueteGrd.DataSource = AgenciaTipoPaquete.FindAllStatic("cod_agencia=" + atp.CodAgencia, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La actividad ya está vinculada o se produjo otro error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calendario_MouseLeave(object sender, EventArgs e)
        {
            Calendario.Visible = false;
            fechaBtn.Text = "Elegir fechas";
        }

    }
}
