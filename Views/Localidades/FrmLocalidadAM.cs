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
using TurApp.Views;

namespace TurApp.Views
{
    [Permiso(ClaseBaseForm = "Localidad", FuncionPermiso = "AltaLocalidad,ModificaLocalidad,ConsultaLocalidad", RolUsuario = "administrador,operadorTurista,operadorTurno,consulta,operador")]
    public partial class FrmLocalidadAM : FormBase
    {
        // Requerida override para poder agregarle un handler
        public override event FormEvent DoCompleteOperationForm;
        private Localidad _Localidad_modif = null;
        private string LocalidadLog = "";
        
        public FrmLocalidadAM()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            if (perm != null)
            {
                this.GuardarBtn.Enabled = perm.HasAddPerm || perm.HasUpdPerm;
                if (!this.GuardarBtn.Enabled && perm.HasViewPerm)
                {
                    this.GuardarBtn.Visible = false;
                    FormBase.SoloConsulta(this);
                    OperacionForm = FrmOperacion.frmConsulta;
                }
            }
        }
        private void FrmpTuristaAM_Load(object sender, EventArgs e)
        {

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
                
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de nuevo Localidad...";
                    
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Localidad...";

                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Localidad...";
                    this.GuardarBtn.Visible = false;
                }
            }
        }
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Localidad localidad = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (CodPostal.Text == "")
            {
                MessageBox.Show("Ingrese Codigo Postal", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodPostal.Focus();
                return;
            }
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                localidad = new Localidad();
                operacionLog = "ALTA";
                localidad = new Localidad();
                localidad.Codigo = Convert.ToInt32(CodPostal.Text);
                localidad.Nombre = nombreText.Text;
                
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                localidad = _Localidad_modif;
                localidad.Codigo = Convert.ToInt32(CodPostal.Text);
                localidad.Nombre = nombreText.Text;
                detalleLog = "OBJ-Antes:" + LocalidadLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            //ReadDataFromForm(this, localidad);
            
            
            /*
            Turista.NroDocumento = Convert.ToInt32(DniTxt.Text);
            Turista.Nombre = NombreTxt.Text;            
            Turista.Domicilio = DomicilioTxt.Text;
            Turista.CodPais= Convert.ToInt32(PaisCbo.SelectedValue);
            Turista.Observaciones = ObservacionesTxt.Text;
            Turista.Telefono = TelefonoTxt.Text;
             * */
           
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(localidad);
            // intentar guardar en la Base de datos.
            try
            {
                localidad.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex)
            {
                errMsj = "Error: " + ex.Message;
            }
            // si esta configurado, al form invoker enviarle evento de operacion completa
            if (DoCompleteOperationForm != null)
            {
                if (errMsj == "")
                    DoCompleteOperationForm(localidad, new EventArgDom { ObjProcess = localidad, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(localidad, new EventArgDom { ObjProcess = localidad , Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }
       
        // Notificara al Invocador que recargue algun cambio de datos.
        public void ShowModificarLocalidad(FormBase Invoker, Localidad Loc_modif)
        {
            ShowInfoLocalidadInForm(Loc_modif, Invoker);
        }
        public void ShowModificarLocalidad(Localidad Loc_modif)
        {
            ShowInfoLocalidadInForm(Loc_modif, null);
        }
        private void ShowInfoLocalidadInForm(Localidad Loc_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Localidad_modif = Loc_modif;
            LocalidadLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Localidad_modif);
            //           
            FormBase.ShowDataFromModel(this, Loc_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoLocalidad(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoLocalidad()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmLocalidadAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void CodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void CancelarBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

    }
}
