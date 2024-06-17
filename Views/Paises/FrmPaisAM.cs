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

namespace TurApp.Views{
    [Permiso(ClaseBaseForm = "Pais", FuncionPermiso = "AltaPais,ModificaPais,ConsultaPais", RolUsuario = "administrador,operadorTurista,operadorTurno,consulta,operador")]
    public partial class FrmPaisAM : FormBase{
        // Requerida override para poder agregarle un handler
        //public override event FormEvent DoCompleteOperationForm;
        private Pais _Pais_modif = null;
        private string PaisLog = "";

        public FrmPaisAM()
        {
            InitializeComponent();
        }
        
        /*
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
        */

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
                    this.Text = "Ingreso de un nuevo pais...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de nombre de un pais...";
                }
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Pais Pais = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (NombrePaisTxt.Text == "")
            {
                MessageBox.Show("Ingrese nombre del pais", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombrePaisTxt.Focus();
                return;
            }
            // validar...
            //.....
            //....
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Pais = new Pais();
                operacionLog = "ALTA";
                Pais.Nombre = NombrePaisTxt.Text;
                // cargar la info del pais antes de dar de alta.
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Pais = _Pais_modif;
                Pais.Nombre = NombrePaisTxt.Text;
                detalleLog = "OBJ-Antes:" + PaisLog + " - OBJ-MOD";
            }

            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            /*
            Turista.NroDocumento = Convert.ToInt32(DniTxt.Text);
            Turista.Nombre = NombreTxt.Text;            
            Turista.Domicilio = DomicilioTxt.Text;
            Turista.CodPais= Convert.ToInt32(PaisCbo.SelectedValue);
            Turista.Observaciones = ObservacionesTxt.Text;
            Turista.Telefono = TelefonoTxt.Text;
             * */
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Pais);
            // intentar guardar en la Base de datos.
            try
            {
                Pais.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex)
            {
                errMsj = "Error: " + ex.Message;
            }
            
            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        public void ShowIngresoPais(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoPais()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        // Notificara al Invocador que recargue algun cambio de datos.
        public void ShowModificarPais(FormBase Invoker, Pais Pais_modif)
        {
            ShowInfoPaisInForm(Pais_modif, Invoker);
        }
        public void ShowModificarPais(Pais Pais_modif)
        {
            ShowInfoPaisInForm(Pais_modif, null);
        }

        private void ShowInfoPaisInForm(Pais Pais_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Pais_modif = Pais_modif;
            PaisLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Pais_modif);
            //           
            FormBase.ShowDataFromModel(this, Pais_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }


        private void FrmPaisAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NombreLbl_Click(object sender, EventArgs e)
        {

        }

        private void NombrePaisTxt_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
