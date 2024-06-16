using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;

namespace TurApp.Views {
    public partial class FrmFormaPagoBusq : FormBase {
        public FrmFormaPagoBusq() {
            InitializeComponent();
        }

        private void BuscarBtn_Click(object sender, EventArgs e) {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if(FormaTxt.Text != "")
                criterio = String.Format("forma ILIKE '%{0}%'", FormaTxt.Text);
            

            try {
                var lista = FormaPago.FindAllStatic(criterio, null);
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0) {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmFormaPagoList frm = new FrmFormaPagoList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex) {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Enter_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 10)
                BuscarBtn_Click(sender, e);
        }

        
    }
}
