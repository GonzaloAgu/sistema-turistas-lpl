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

namespace TurApp.Views {
    public partial class FrmListadoAgencia : FormBase {
        public FrmListadoAgencia() {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm) {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void FrmListadoAgencias_Load(object sender, EventArgs e) {
            LoadComboBox(Localidad.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), LocalidadCbo, addSeleccion: true);
            AgenciaGrd.AutoGenerateColumns = false;
            AgenciaGrd.DataSource = Agencia.FindAllStatic(null, (a1, a2) => a1.Nombre.CompareTo(a2.Nombre));
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e) {
            LocalidadCbo.Enabled = LocalidadChk.Checked;
        }

        private void AgenciaGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            
            foreach (DataGridViewRow fila in AgenciaGrd.Rows) {
                Agencia agencia = fila.DataBoundItem as Agencia;
                string loc = agencia.LocalidadObj.Nombre;
                fila.Cells["LocalidadCol"].Value = agencia.LocalidadObj.Nombre;
                fila.Cells["PisoDeptoCol"].Value = String.Format("{0} {1}", agencia.Piso, agencia.Dpto);
            }
        }

        private void FiltroBtn_Click(object sender, EventArgs e) {
            string criterio = null;

            if (NombreChk.Checked && NombreTxt.Text != "") {
                criterio = String.Format("nombre ILIKE '%{0}%'", NombreTxt.Text);
            }
            if (this.LocalidadChk.Checked && this.LocalidadCbo.SelectedIndex != -1) {
                if (criterio != null)
                    criterio += "AND codigo_postal=" + (LocalidadCbo.SelectedValue as Localidad).Codigo;
                else
                    criterio = "codigo_postal=" + (LocalidadCbo.SelectedValue as Localidad).Codigo;
            }
            AgenciaGrd.DataSource = Agencia.FindAllStatic(criterio, (a1, a2) => a1.Nombre.CompareTo(a2.Nombre));
        }

        private void NombreChk_CheckStateChanged(object sender, EventArgs e) {
            NombreTxt.Enabled = NombreChk.Checked;
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
                        archivo.WriteLine("Codigo,Calle,CodPostal,Dpto");
                        foreach (Agencia ag in (AgenciaGrd.DataSource as List<Agencia>))
                            archivo.WriteLine(String.Format("{0},{1},{2},{3}", ag.Codigo, ag.Calle, ag.CodPostal, ag.Dpto));
                        MessageBox.Show("Archivo guardado exitosamente en: " + saveFileDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AgenciaGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmAgenciaAM frmpac = new FrmAgenciaAM();
            Agencia pac = (this.AgenciaGrd.SelectedRows[0].DataBoundItem as Agencia);
            frmpac.ShowModificarAgencia(pac);
        }
    }
}
