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
                    this.Text = "Ingreso de nuevo Paquete...";
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
            
            if (tipoPaqCbo.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese tipo paquete", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tipoPaqCbo.Focus();
                return;
            }
            if (agenciaCbo.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese agencia", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                agenciaCbo.Focus();
                return;
            }
            if (FechaTxt.Text == "")
            {
                MessageBox.Show("Ingrese fecha", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FechaTxt.Focus();
                return;
            }
            if (DniTur.Text == "")
            {
                MessageBox.Show("Ingrese dni turista", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DniTur.Focus();
                return;
            }
            if (NivelTxt.Text == "")
            {
                MessageBox.Show("Ingrese nivel", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NivelTxt.Focus();
                return;
            }
            if (destinosCbo.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese destino", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                destinosCbo.Focus();
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
                Paquete.CodTipoPaquete = (tipoPaqCbo.SelectedValue as TipoPaquete).Codigo;
                Paquete.CodAgencia = (agenciaCbo.SelectedValue as Agencia).Codigo;
                string format = "dd/MM/yyyy";
                CultureInfo provider = CultureInfo.InvariantCulture;
                string fecha = FechaTxt.Text;
                DateTime date = DateTime.ParseExact(fecha, format, provider);
                Paquete.Fecha = date;
                Paquete.DniTurista = (turistaCbo.SelectedValue as Turista).NroDocumento;
                Paquete.Nivel = Convert.ToInt32(NivelTxt.Text);
                Paquete.CodDestino = (destinosCbo.SelectedValue as Destino).Codigo;
            }
            
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Paquete = _Paquete_modif;
                Paquete.CodTipoPaquete = (tipoPaqCbo.SelectedValue as TipoPaquete).Codigo;
                Paquete.CodAgencia = (agenciaCbo.SelectedValue as Agencia).Codigo;
                Paquete.CodDestino = (destinosCbo.SelectedValue as Destino).Codigo;
                Paquete.Fecha = Convert.ToDateTime(FechaTxt.Text);
                Paquete.DniTurista = Convert.ToInt32(turistaCbo.SelectedValue);
                Paquete.Nivel = Convert.ToInt32(NivelTxt.Text);
                Paquete.DniTurista = (turistaCbo.SelectedValue as Turista).NroDocumento;
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

        private void FrmPaqueteAM_Load(object sender, EventArgs e)
        {
            LoadComboBox(TipoPaquete.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre)), tipoPaqCbo, "Nombre");
            tipoPaqCbo.SelectedIndex = -1;

            LoadComboBox(Agencia.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre)), agenciaCbo, "Nombre");
            agenciaCbo.SelectedIndex = -1;

            LoadComboBox(Turista.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre)), turistaCbo, "Nombre");
            agenciaCbo.SelectedIndex = -1;

            LoadComboBox(Destino.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre)), destinosCbo, "Nombre");
            agenciaCbo.SelectedIndex = -1;

        }

        private void SoloDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        
      

    }
}
