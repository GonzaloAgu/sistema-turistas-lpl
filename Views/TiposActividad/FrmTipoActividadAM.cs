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

namespace TurApp.Views
{
    [Permiso(ClaseBaseForm = "TipoActividad", FuncionPermiso = "AltaTipoActividad,ModificaTipoActividad,ConsultaTipoActividad", RolUsuario = "administrador,operadorActividad,consulta,operador")]
    public partial class FrmTipoActividadAM : FormBase
    {
        // Requerida override para poder agregarle un handler
        public override event FormEvent DoCompleteOperationForm;
        private TipoActividad _TipoActividad_modif = null;
        private string TipoActividadLog = "";
        public FrmTipoActividadAM()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            if (perm != null)
            {
                this.guardarbtn.Enabled = perm.HasAddPerm || perm.HasUpdPerm;
                if (!this.guardarbtn.Enabled && perm.HasViewPerm)
                {
                    this.guardarbtn.Visible = false;
                    FormBase.SoloConsulta(this);
                    OperacionForm = FrmOperacion.frmConsulta;
                }
            }
        }

        private void FrmTipoActividadAM_Load(object sender, EventArgs e)
        {
            // Cargar datos iniciales si es necesario
        }

        private void LoadCombos()
        {
            // Cargar los combos aquí, si hay alguno en el formulario.
            // Ejemplo: this.AlgunCombo.DataSource = AlgunaFuenteDeDatos;
        }

        public override FrmOperacion OperacionForm
        {
            get
            {
                return base.OperacionForm;
            }
            set
            {
                base.OperacionForm = value;
                LoadCombos();
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de nuevo Tipo de Actividad...";
                    // Resetear campos si es necesario
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualización de datos del Tipo de Actividad...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos del Tipo de Actividad...";
                    this.guardarbtn.Visible = false;
                }
            }
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            TipoActividad tipoActividad = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            
            // Validar otros campos según sea necesario...

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                tipoActividad = new TipoActividad();
                operacionLog = "ALTA";
                tipoActividad.Duracion = duraciontxt.Text;
                tipoActividad.Descripcion = descripciontxt.Text;
                tipoActividad.Nivel = Convert.ToInt32(niveltxt.Text);
                tipoActividad.Nombre = nombretxt.Text;

            }
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                tipoActividad = _TipoActividad_modif;
                tipoActividad.Duracion = duraciontxt.Text;
                tipoActividad.Descripcion = descripciontxt.Text;
                tipoActividad.Nivel = Convert.ToInt32(niveltxt.Text);
                tipoActividad.Nombre = nombretxt.Text;
                detalleLog = "OBJ-Antes:" + TipoActividadLog + " - OBJ-MOD";

            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            //ReadDataFromForm(this, tipoActividad);
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(tipoActividad);

            try
            {
                tipoActividad.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex)
            {
                errMsj = "Error: " + ex.Message;
            }

            if (DoCompleteOperationForm != null)
            {
                if (errMsj == "")
                    DoCompleteOperationForm(tipoActividad, new EventArgDom { ObjProcess = tipoActividad, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(tipoActividad, new EventArgDom { ObjProcess = tipoActividad, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        public void ShowModificarTipoActividad(FormBase Invoker, TipoActividad tipoActividad_modif)
        {
            ShowInfoTipoActividadInForm(tipoActividad_modif, Invoker);
        }

        public void ShowModificarTipoActividad(TipoActividad tipoActividad_modif)
        {
            ShowInfoTipoActividadInForm(tipoActividad_modif, null);
        }

        private void ShowInfoTipoActividadInForm(TipoActividad tipoActividad_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _TipoActividad_modif = tipoActividad_modif;
            TipoActividadLog = Newtonsoft.Json.JsonConvert.SerializeObject(_TipoActividad_modif);
            FormBase.ShowDataFromModel(this, tipoActividad_modif);
            this.InvokerForm = Invoker;
            this.cancelarbtn.Click += new EventHandler(cancelarbtn_Click);
            this.ShowDialog();
        }

        public void ShowIngresoTipoActividad(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoTipoActividad()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmTipoActividadAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void CodigoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MisFactBtn_Click(object sender, EventArgs e)
        {
            // Implementar funcionalidad adicional si es necesario
        }

        private void duraciontxt_TextChanged(object sender, EventArgs e)
        {

        }

      

        

     
    }
}
