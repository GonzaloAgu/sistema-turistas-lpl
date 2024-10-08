﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Windows.Forms;
using System.Configuration;

using Npgsql; // Libreria para conectar con PostgreSQL
using TurApp.db; // incluir libreria para poder acceder a los objetos de negocios.

namespace TurApp.Views
{    
    public partial class MainView : FormBase
    {
        private Usuario _usuarioActual = null;
        public Usuario UsuarioActual
        {
            get { return _usuarioActual; }
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowUsuario()
        {
            _usuarioActual = Usuario.UsuarioSys;
            StatusInfoUser.Text = String.Format("Usuario: {0} - {1}", _usuarioActual.UsuarioName, _usuarioActual.FechaLogin); ;
            // mostrar los permisos del usuario en base a los roles, leer cada permiso.
            // Recorrer cada item de Menu, para verificar primero los grupos  y luego cada opcion.
            var list = this.menuStrip1.Items.Cast < ToolStripMenuItem>().ToList().Where(t=> t.Name.IndexOf("1mnu_top") != -1);
            List<Funcion> listFuncUser = UsuarioActual.ListadoFunciones;
            bool prmOK=true;
            foreach (var item in list)
	        {
                // verificar el permiso puede incluir listado hacer split.
                prmOK = true;
                string perm = item.Tag.ToString();
                string[] listFunciones = perm.Split(',');
                for (int i = 0; i < listFunciones.Length; i++)
                {
                    prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFunciones[i])!=null;
                }
                item.Enabled = prmOK;
                //por cada ItemPrincipal, verificar los SubItems por debajo si tiene permiso.

                var list_subitm = item.DropDownItems.Cast<ToolStripMenuItem>().ToList();
                                
                foreach (var subitm in list_subitm)
                {
                    prmOK = true;
                    string permsub = subitm.Tag.ToString();
                    string[] listFuncionesSub = permsub.Split(',');
                    for (int i = 0; i < listFuncionesSub.Length; i++)
                    {
                        prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFuncionesSub[i]) != null;
                    }                    
                    subitm.Enabled = prmOK;
                }
            }
            // aplicar permiso a cada submenu.
            
            this.Visible = true;
        }
        private static readonly MainView instance = new MainView();
        static MainView()
        {
            
        }
        private MainView()
        {
            InitializeComponent();
        }
        // Implementacion de Patron Singleton
        public static MainView Instance
        {
            get
            {
                return instance;
            }
        }

        public void ShowMain(FrmLogin loginFrm, Usuario user)
        {
            loginFrm.Dispose();
            loginFrm= null;
            _usuarioActual = user;
            this.Show();
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin;
            if (_usuarioActual == null)
            {
                this.Visible = false;
                frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                if (_usuarioActual == null)
                {
                    Application.Exit();
                    return;
                }
                this.Visible = true;
            }
        }

        private void IngresoEspecialidadMnu_Click(object sender, EventArgs e)
        {
            
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                MessageBox.Show("Operacion realizada correctamente " , "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Verificar si hay Form de Listado para poder actualizar la lista de datos..
            }
            else
            {
                MessageBox.Show("Ocurrio un error: " + ev.Mensaje,"Error...",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }             

        private void IngresoTuristaMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;  // convierte el cursor en un reloj de arena
            FrmTuristaAM frm = new FrmTuristaAM();  // genera el formulario de ingreso de turista
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);  // cuando el formulario frm se complete, esto llama al metodo frm_DoCompleteOperationForm que genera un cartelito de "operacion exitosa"
            frm.ShowIngresoTurista(this);   // hace que el formulario de turista se muestre. se pasa como parámetro el formulario general (this), no se bien por qué
        }

        private void BuscarTuristaMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTuristaBusq frm = new FrmTuristaBusq();
            frm.ShowBuscar();
        }

        private void ListadoTuristaMnu_Click(object sender, EventArgs e)
        {
            FrmListadoTuristas frmListPac = new FrmListadoTuristas();
            frmListPac.Show();
        }

        private void ListadoAgencias_Click(object sender, EventArgs e)
        {
            FrmListadoAgencia frm = new FrmListadoAgencia();
            frm.Show();
        }

        private void IngresoAgencia_Click(object sender, EventArgs e)
        {
            FrmAgenciaAM frm = new FrmAgenciaAM();
            frm.ShowIngresoAgencia();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgenciaBusq frmba = new FrmAgenciaBusq();
            frmba.ShowBuscar();
        }

        
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir del sistema?", "salida..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
                return;
            }
            e.Cancel = true;
        }

        private void ActividadAM_mnu_Click(object sender, EventArgs e)
        {
            FrmActividadAM form = new FrmActividadAM();
            form.ShowIngresoActividad();
        }

   



        //////////////////

        private void LocalidadAM_mnu_Click(object sender, EventArgs e)
        {
            /*MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmLocalidadAM frm = new FrmLocalidadAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoLocalidad(this);*/
            FrmLocalidadAM frmListLoc = new FrmLocalidadAM();
            frmListLoc.Show();
            frmListLoc.OperacionForm = FrmOperacion.frmAlta;
        }

        private void ListadoLocalidadesMnu_Click(object sender, EventArgs e)
        {
            FrmListadoLocalidades frmListLoc = new FrmListadoLocalidades();
            frmListLoc.Show();
        }

        private void BuscarLocalidad_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmLocalidadBusq frm = new FrmLocalidadBusq();
            frm.ShowBuscar();
        }



        

        private void buscarActividadesMnu_Click(object sender, EventArgs e) {
            FrmActividadBusq frm = new FrmActividadBusq();
            frm.ShowBuscar();
        }

        private void ListadoActividades_Click(object sender, EventArgs e) {
            FrmListadoActividad form = new FrmListadoActividad();
            form.Show();
        }

        private void IngresoFormaPago_Click(object sender, EventArgs e) {
            FrmFormaPagoAM form = new FrmFormaPagoAM();
            form.ShowIngresoFormaPago();
        }

        private void BuscarFormasPago_Click(object sender, EventArgs e) {
            FrmFormaPagoBusq form = new FrmFormaPagoBusq();
            form.Show();
        }

        private void FormaPagosToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmListadoFormaPago form = new FrmListadoFormaPago();
            form.Show();
        }

        private void TipoActivAM_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;  // convierte el cursor en un reloj de arena
            FrmTipoActividadAM frm = new FrmTipoActividadAM();  // genera el formulario de ingreso de turista
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);  // cuando el formulario frm se complete, esto llama al metodo frm_DoCompleteOperationForm que genera un cartelito de "operacion exitosa"
            frm.ShowIngresoTipoActividad(this);   // hace que el formulario de turista se muestre. se pasa como parámetro el formulario general (this), no se bien por qué
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void BuscarTipoAct_mnu_Click(object sender, EventArgs e)
        {
 
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTipoActividadBusq frm = new FrmTipoActividadBusq();
            frm.ShowBuscar();
        

        }
/*
            private void ListadoTipoActividadMnu_Click(object sender, EventArgs e)
        {
            //FrmListadoTuristas frmListPac = new FrmListadoTuristas();
            FrmListadoActividad frmListPac = new FrmListadoActividad();
            frmListPac.Show();
        }

  */          private void TipoActividadToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                FrmListadoTipoActividad frmListPac = new FrmListadoTipoActividad();
                frmListPac.Show();
            }




      

        
        private void PaqueteAM_mnu_Click(object sender, EventArgs e)
        {
            FrmPaqueteAM form = new FrmPaqueteAM();
            form.ShowIngresoPaquete();
        }

        private void BuscarPaquete_mnu_Click(object sender, EventArgs e)
        {
            FrmPaqueteBusq form = new FrmPaqueteBusq();
            form.Show();
        }

        private void PaqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoPaquetes form = new FrmListadoPaquetes();
            form.Show();
        }

        private void Facturar_mnu_top_Click(object sender, EventArgs e)
        {
            FrmFacturar form = new FrmFacturar();
            form.Show();
        }

        private void TipoPaqueteAM_mnu_Click(object sender, EventArgs e)
        {
            FrmTipoPaqueteAM form = new FrmTipoPaqueteAM();
            form.ShowIngresoTipoPaquete();
        }

        private void BuscarTipoPaquete_mnu_Click(object sender, EventArgs e)
        {
            FrmTipoPaqueteBusq form = new FrmTipoPaqueteBusq();
            form.Show();
        }

        private void IngresoPais_Click(object sender, EventArgs e)
        {
            FrmPaisAM form = new FrmPaisAM();
            form.ShowIngresoPais();
        }

        private void AcercaDe_mnu_Click(object sender, EventArgs e)
        {
            FrmAcercaDe form = new FrmAcercaDe();
            form.Show();
        }

        private void TipoPaqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoTipoPaquetes form = new FrmListadoTipoPaquetes();
            form.Show();
        }

        private void tipoPaqueteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgenciaTipoPaquete form = new FrmAgenciaTipoPaquete();
            form.ShowDialog();
        }

        private void actividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaqueteActividad form = new FrmPaqueteActividad();
            form.ShowDialog();
        }
        private void tipoActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoPaqueteTipoActividad form = new FrmTipoPaqueteTipoActividad();
            form.ShowDialog();
        }
    }
}
