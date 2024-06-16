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
    public partial class FrmFormaPagoList : FormBase {
        private string _criterio = null;
        private List<FormaPago> _listado;
        public FrmFormaPagoList() {
            InitializeComponent();
        }

        public void ShowListado(List<FormaPago> listado, FormBase Invoker, string criterio) {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.FormasPagoGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<FormaPago>(listado);
            var source = new BindingSource(bindingList, null);
            this.FormasPagoGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void FormasPagoGrd_DoubleClick(object sender, EventArgs e) {
            if (this.FormasPagoGrd.SelectedRows.Count > 0) {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmFormaPagoAM frm = new FrmFormaPagoAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarFormaPago(this, (this.FormasPagoGrd.SelectedRows[0].DataBoundItem as FormaPago));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev) {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK) {
                var selAnt = FormasPagoGrd.SelectedRows[0].Index;
                this.FormasPagoGrd.DataSource = FormaPago.FindAllStatic(_criterio, (a1, a2) => a1.Forma.CompareTo(a2.Forma));
                FormasPagoGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Forma de pago actualizada", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
