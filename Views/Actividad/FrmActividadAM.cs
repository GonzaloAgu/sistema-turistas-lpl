using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;
using Newtonsoft;

namespace TurApp.Views {
    [Permiso(ClaseBaseForm = "Actividad", FuncionPermiso = "AltaActividad,ModificaActividad,ConsultaActividad", RolUsuario = "administrador,operadorTurista,operadorTurno,consulta,operador")]
    public partial class FrmActividadAM : FormBase {
        public override event FormEvent DoCompleteOperationForm;
        private Actividad _Actividad_modif = null;
        private string ActividadLog = "";
        public FrmActividadAM() {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm) {
            if (perm != null) {
                this.GuardarBtn.Enabled = perm.HasAddPerm || perm.HasUpdPerm;
                if (!this.GuardarBtn.Enabled && perm.HasViewPerm) {
                    this.GuardarBtn.Visible = false;
                    FormBase.SoloConsulta(this);
                    OperacionForm = FrmOperacion.frmConsulta;
                }
            }
        }

        private void LoadCombos() {
            this.tipoActCB.DataSource = TipoActividad.FindAllStatic(null, (ta1, ta2) =>
                ta1.Nombre.CompareTo(ta2.Nombre));
            this.TransporteCbo.DataSource = Transporte.FindAllStatic(null, (ta1, ta2) =>
                ta1.Descripcion.CompareTo(ta2.Descripcion));
        }

        public override FrmOperacion OperacionForm {
            get {
                return base.OperacionForm;
            }
            set {
                base.OperacionForm = value;
                LoadCombos();
                if (value == FrmOperacion.frmAlta) {
                    this.Text = "Ingreso de nueva actividad";
                    this.tipoActCB.SelectedIndex = -1;
                    // agregar el CB de transporte
                }
                if (value == FrmOperacion.frmModificacion) {
                    this.Text = "Actualizacion de datos de actividad";
                }
                if (value == FrmOperacion.frmConsulta) {
                    this.Text = "Consulta de datos de actividad";
                    this.GuardarBtn.Visible = false;
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void GuardarBtn_Click(object sender, EventArgs e) {
            Actividad actividad = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            // Validar...

            if (OperacionForm == FrmOperacion.frmAlta) {
                actividad = new Actividad();
                operacionLog = "ALTA";
            }

            if (OperacionForm == FrmOperacion.frmModificacion) {
                operacionLog = "MODIFICACION";
                actividad = _Actividad_modif;
                detalleLog = "OBJ-Antes:" + ActividadLog + " - OBJ-MOD:";
            }
            if (OperacionForm == FrmOperacion.frmConsulta) {
                operacionLog = "CONSULTA";
            }

            ReadDataFromForm(this, actividad);
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(actividad);

            try {
                actividad.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex) {
                errMsj = "Error: " + ex.Message;
            }

            if (DoCompleteOperationForm != null) {
                if(errMsj == "")
                    DoCompleteOperationForm(actividad,
                        new EventArgDom { ObjProcess = actividad, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(actividad,
                        new EventArgDom { ObjProcess = actividad, Mensaje = errMsj,  Status = TipoOperacionStatus.stError });
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        public void ShowModificarActividad(FormBase Invoker, Actividad Act_modif) {
            ShowInfoActividadInForm(Act_modif, Invoker);
        }

        public void ShowModificarActividad(Actividad Act_modif) {
            ShowInfoActividadInForm(Act_modif, null);
        }

        public void ShowInfoActividadInForm(Actividad Act_modif, FormBase Invoker) {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Actividad_modif = Act_modif;
            ActividadLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Actividad_modif);
            // cargar cada control con informacion del Turista....            
            FormBase.ShowDataFromModel(this, Act_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }

        public void ShowIngresoActividad(FormBase Invoker) {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoActividad() {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmActividadAM_Deactivate(object sender, EventArgs e) {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void nivelTxt_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.')) {
                e.Handled = true;
            }   
        }

        private void importeTxt_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.')) {
                e.Handled = true;
            }   
        }
    }
}
