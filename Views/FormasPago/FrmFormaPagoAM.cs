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
    public partial class FrmFormaPagoAM : FormBase {

        public override event FormEvent DoCompleteOperationForm;
        private FormaPago _FormaPago_modif = null;
        private string FormaPagoLog = "";

        public FrmFormaPagoAM() {
            InitializeComponent();
        }

        public override FrmOperacion OperacionForm {
            get {
                return base.OperacionForm;
            }
            set {
                base.OperacionForm = value;

                if (value == FrmOperacion.frmAlta) {
                    this.Text = "Ingreso de nueva forma de pago";
                }
                if (value == FrmOperacion.frmModificacion) {
                    this.Text = "Actualizacion de datos de FormaPago";
                }
                if (value == FrmOperacion.frmConsulta) {
                    this.Text = "Consulta de datos de FormaPago";
                    this.GuardarBtn.Visible = false;
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void GuardarBtn_Click(object sender, EventArgs e) {
            FormaPago fp = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            // Valida si falta algun dato en el formulario
            if (formaTxt.Text == "")
                return;

            if (OperacionForm == FrmOperacion.frmAlta) {
                fp = new FormaPago();
                operacionLog = "ALTA";
            }

            if (OperacionForm == FrmOperacion.frmModificacion) {
                operacionLog = "MODIFICACION";
                fp = _FormaPago_modif;
                detalleLog = "OBJ-Antes:" + FormaPagoLog + " - OBJ-MOD:";
            }
            if (OperacionForm == FrmOperacion.frmConsulta) {
                operacionLog = "CONSULTA";
            }

            ReadDataFromForm(this, fp);
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(fp);

            try {
                fp.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex) {
                errMsj = "Error: " + ex.Message;
            }

            if (DoCompleteOperationForm != null) {
                if (errMsj == "")
                    DoCompleteOperationForm(fp,
                        new EventArgDom { ObjProcess = fp, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(fp,
                        new EventArgDom { ObjProcess = fp, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        public void ShowModificarFormaPago(FormBase Invoker, FormaPago FormaPago_modif) {
            ShowInfoFormaPagoInForm(FormaPago_modif, Invoker);
        }

        public void ShowModificarFormaPago(FormaPago Fp_modif) {
            ShowInfoFormaPagoInForm(Fp_modif, null);
        }

        public void ShowInfoFormaPagoInForm(FormaPago Fp_modif, FormBase Invoker) {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _FormaPago_modif = Fp_modif;
            FormaPagoLog = Newtonsoft.Json.JsonConvert.SerializeObject(_FormaPago_modif);           
            FormBase.ShowDataFromModel(this, Fp_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }

        public void ShowIngresoFormaPago(FormBase Invoker) {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoFormaPago() {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmFormaPagoAM_Deactivate(object sender, EventArgs e) {
            MainView.Instance.Cursor = Cursors.Default;
        }
    }
}
