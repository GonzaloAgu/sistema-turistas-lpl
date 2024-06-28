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
    [Permiso(ClaseBaseForm="TipoPaquete", FuncionPermiso = "AltaTipoPaquete,ModificaTipoPaquete,ConsultaTipoPaquete", RolUsuario = "administrador,operadorTipoPaquete,operadorTurno,consulta,operador")]
    public partial class FrmTipoPaqueteAM : FormBase
    {
        // Requerida override para poder agregarle un handler
        public override event FormEvent DoCompleteOperationForm;
        private TipoPaquete _TipoPaquete_modif = null;
        private string TipoPaqueteLog = "";
        public FrmTipoPaqueteAM()
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
        private void FrmpTipoPaqueteaAM_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadCombos()
        {
            //this.NivelTxt.DataSource =  Pais.FindAllStatic(null, (pa1, pa2) => pa1.Nombre.CompareTo(pa2.Nombre));
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
                    this.Text = "Ingreso de nuevo Tipo paquete...";
                    //this.NivelTxt.SelectedIndex = -1;
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Tipo paquete...";
                    
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Tipo paquete...";
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
            TipoPaquete TipoPaq = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog="";
            MainView.Instance.Cursor = Cursors.WaitCursor;                       
            
            if (NombreTxt.Text == "")
            {
                MessageBox.Show("Ingrese nombre", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreTxt.Focus();
                return;
            }
            if (DescripcionTxt.Text == "")
            {
                MessageBox.Show("Ingrese descripción", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DescripcionTxt.Focus();
                return;
            }
            if (DuracionTxt.Text == "")
            {
                MessageBox.Show("Ingrese duración", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DuracionTxt.Focus();
                return;
            }
            if (NivelTxt.Text == "")
            {
                MessageBox.Show("Ingrese nivel", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NivelTxt.Focus();
                return;
            }
            // validar...
            //.....
            //....
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                TipoPaq = new TipoPaquete();
                operacionLog = "ALTA";
                TipoPaq.Nombre = NombreTxt.Text;
                TipoPaq.Descripcion = DescripcionTxt.Text;
                DateTime parsedDate = DateTime.ParseExact(DuracionTxt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                TipoPaq.Duracion = parsedDate.ToString("yyyy-MM-dd") + " 00:00:00";
                TipoPaq.Nivel = Convert.ToInt32(NivelTxt.Text);
            }
            
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                TipoPaq = _TipoPaquete_modif;
                TipoPaq.Nombre = NombreTxt.Text;
                TipoPaq.Descripcion = DescripcionTxt.Text;
                DateTime parsedDate = DateTime.ParseExact(DuracionTxt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                TipoPaq.Duracion = parsedDate.ToString("yyyy-MM-dd") + " 00:00:00";
                TipoPaq.Nivel = Convert.ToInt32(NivelTxt.Text);
                detalleLog = "OBJ-Antes:" + TipoPaqueteLog + " - OBJ-MOD"; 
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            ReadDataFromForm(this, TipoPaq);
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(TipoPaq);

            // intentar guardar en la Base de datos.
            try
            {
                TipoPaq.SaveObj();
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
                    DoCompleteOperationForm(TipoPaq, new EventArgDom { ObjProcess = TipoPaq, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(TipoPaq, new EventArgDom { ObjProcess = TipoPaq, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }
        // Notificara al Invocador que recargue algun cambio de datos.
        public void ShowModificarTipoPaquete(FormBase Invoker, TipoPaquete TP_modif)
        {
            ShowInfoTipoPaqueteInForm(TP_modif, Invoker);
        }

        public void ShowModificarTipoPaquete(TipoPaquete TP_modif)
        {
            ShowInfoTipoPaqueteInForm(TP_modif, null);
        }

        private void ShowInfoTipoPaqueteInForm(TipoPaquete TP_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _TipoPaquete_modif = TP_modif;
            TipoPaqueteLog = Newtonsoft.Json.JsonConvert.SerializeObject(_TipoPaquete_modif);
            // cargar cada control con informacion del Turista....            
            FormBase.ShowDataFromModel(this, TP_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click+=new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }

        public void ShowIngresoTipoPaquete(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoTipoPaquete()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmTuristaAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;   
        }

        private void DniTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }            
        }


        private void MisFactBtn_Click(object sender, EventArgs e)
        {
            //FrmFacturasTurista form = new FrmFacturasTurista(_TipoPaquete_modif);
            //form.ShowDialog();
        }

    }
}
