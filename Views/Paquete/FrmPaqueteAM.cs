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
using System.Globalization;

namespace TurApp.Views
{
    [Permiso(ClaseBaseForm="Paquete", FuncionPermiso = "AltaPaquete,ModificaPaquete,ConsultaPaquete", RolUsuario = "administrador,operadorTurista,operadorTurno,consulta,operador")]
    public partial class FrmPaqueteAM : FormBase
    {
        // Requerida override para poder agregarle un handler
        public override event FormEvent DoCompleteOperationForm;
        private Paquete _Paquete_modif = null;
        private string PaqueteLog = "";
        public FrmPaqueteAM()
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
        private void FrmpPaqueteAM_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadCombos()
        {
            this.DniTurTxt.DataSource =  Turista.FindAllStatic(null, (pa1, pa2) => pa1.NroDocumento.CompareTo(pa2.NroDocumento));

            //this.PaisCbo.DataSource = ORMDB<Localidad>.FindAll(null);
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
                    this.Text = "Ingreso de nuevo Paquete...";
                    this.DniTurTxt.SelectedIndex = -1;
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Paquete...";
                    
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Paquete...";
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
            Paquete Paquete = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog="";
            MainView.Instance.Cursor = Cursors.WaitCursor;                       
            
            if (CodPaqTxt.Text == "")
            {
                MessageBox.Show("Ingrese cod. paquete", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodPaqTxt.Focus();
                return;
            }
            if (CodTPTxt.Text == "")
            {
                MessageBox.Show("Ingrese cod. tipo paquete", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodTPTxt.Focus();
                return;
            }
            if (CodAgeTxt.Text == "")
            {
                MessageBox.Show("Ingrese cod. agencia", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodTPTxt.Focus();
                return;
            }
            if (FechaTxt.Text == "")
            {
                MessageBox.Show("Ingrese fecha", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodTPTxt.Focus();
                return;
            }
            if (DniTur.Text == "")
            {
                MessageBox.Show("Ingrese dni turista", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodTPTxt.Focus();
                return;
            }
            if (NivelTxt.Text == "")
            {
                MessageBox.Show("Ingrese nivel", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodTPTxt.Focus();
                return;
            }
            if (CodDestinoTxt.Text == "")
            {
                MessageBox.Show("Ingrese cod destino", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodTPTxt.Focus();
                return;
            }
            // validar...
            //.....
            //....
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Paquete = new Paquete();
                operacionLog = "ALTA";
                Paquete = new Paquete();
                Paquete.Codigo = Convert.ToInt32(CodPaqTxt.Text);
                Paquete.CodTipoPaquete = Convert.ToInt32(CodTPTxt.Text);
                Paquete.CodAgencia = Convert.ToInt32(CodAgeTxt.Text);
                string format = "d/MM/yyyy";
                CultureInfo provider = CultureInfo.InvariantCulture;
                string fecha = FechaTxt.Text;
                DateTime date = DateTime.ParseExact(fecha, format, provider);
                Paquete.Fecha = date;
                Paquete.DniTurista = Convert.ToInt32(DniTurTxt.Text);
                Paquete.Nivel = Convert.ToInt32(NivelTxt.Text);
                Paquete.CodDestino = Convert.ToInt32(CodDestinoTxt.Text);
            }
            
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Paquete = _Paquete_modif;
                Paquete.Codigo = Convert.ToInt32(CodPaqTxt.Text);
                Paquete.CodTipoPaquete = Convert.ToInt32(CodTPTxt.Text);
                Paquete.CodAgencia = Convert.ToInt32(CodAgeTxt.Text);
                Paquete.Fecha = Convert.ToDateTime(FechaTxt.Text);
                Paquete.DniTurista = Convert.ToInt32(DniTurTxt.Text);
                Paquete.Nivel = Convert.ToInt32(NivelTxt.Text);
                Paquete.CodDestino = Convert.ToInt32(CodDestinoTxt.Text);
                detalleLog = "OBJ-Antes:" + PaqueteLog + " - OBJ-MOD";                
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            /*ReadDataFromForm(this, Paquete);
            Turista.NroDocumento = Convert.ToInt32(DniTxt.Text);
            Turista.Nombre = NombreTxt.Text;            
            Turista.Domicilio = DomicilioTxt.Text;
            Turista.CodPais= Convert.ToInt32(PaisCbo.SelectedValue);
            Turista.Observaciones = ObservacionesTxt.Text;
            Turista.Telefono = TelefonoTxt.Text;
             * */
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Paquete);
            // intentar guardar en la Base de datos.
            try
            {
                Paquete.SaveObj();
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
                    DoCompleteOperationForm(Paquete, new EventArgDom { ObjProcess = Paquete, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(Paquete, new EventArgDom { ObjProcess = Paquete, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }
        // Notificara al Invocador que recargue algun cambio de datos.
        public void ShowModificarPaquete(FormBase Invoker, Paquete Paq_modif)
        {
            ShowInfoPaqueteInForm(Paq_modif, Invoker);
        }
        public void ShowModificarPaquete(Paquete Paq_modif)
        {
            ShowInfoPaqueteInForm(Paq_modif, null);
        }
        private void ShowInfoPaqueteInForm(Paquete Paq_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Paquete_modif = Paq_modif;
            PaqueteLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Paquete_modif);
            // cargar cada control con informacion del Turista....            
            FormBase.ShowDataFromModel(this, Paq_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click+=new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoPaquete(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoPaquete()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmPaqueteAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;   
        }

        private void CodPaq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }            
        }

        private void DniLbl_Click(object sender, EventArgs e)
        {

        }

    }
}
