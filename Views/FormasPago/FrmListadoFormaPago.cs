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

namespace TurApp.Views {
    public partial class FrmListadoFormaPago : FormBase {
        private List<FormaPago> _lista = null;
        private int _sentido = 1;

        public FrmListadoFormaPago() {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm) {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void FrmListadoFormaPago_Load(object sender, EventArgs e) {
            FormaPagoGrd.AutoGenerateColumns = false;
            _lista = FormaPago.FindAllStatic(null, (a1, a2) => a1.Forma.CompareTo(a2.Forma));
            FormaPagoGrd.DataSource = _lista;
        }

        private void FiltroBtn_Click(object sender, EventArgs e) {
            string criterio = null;

            if (FormaTxt.Text != "")
                criterio = String.Format("forma ILIKE '%{0}%'", FormaTxt.Text);
            _lista = FormaPago.FindAllStatic(criterio, (a1, a2) => a1.Forma.CompareTo(a2.Forma));
            FormaPagoGrd.DataSource = _lista;
        }

        private void ExportarBtn_Click(object sender, EventArgs e){

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo TXT (*.txt)|*.txt|Archivo CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar archivo como";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try {
                    using(StreamWriter archivo = new StreamWriter(saveFileDialog.FileName)) {
                        archivo.WriteLine("codigo,forma");
                        foreach (FormaPago forma in _lista)
                            archivo.WriteLine(String.Format("{0},{1}", forma.Codigo, forma.Forma));
                        MessageBox.Show("Archivo guardado exitosamente en: " + saveFileDialog.FileName);
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormaPagoGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_sentido == 1)
                _sentido = -1;
            else
                _sentido = 1;

            int columna = e.ColumnIndex;
            _lista.Sort((fp1, fp2) => _sentido * fp1.Forma.CompareTo(fp2.Forma));
            FormaPagoGrd.Refresh();
        }
    }
}
