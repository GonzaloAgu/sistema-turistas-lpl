﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;

namespace TurApp.Views
{
    public partial class FrmLocalidadBusq : FormBase
    {
        public FrmLocalidadBusq()
        {
            InitializeComponent();
        }

        

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if (this.CodPostalChk.Checked)
            {
                criterio = String.Format("cod_postal = {0}", CodPostalTxt.Text);
            }

            if (this.NombreLocalidadChk.Checked)
            {
                if(criterio==null)
                    criterio = String.Format("nombre ILIKE '%{0}%'", NombreLocalidadTxt.Text);
                else
                    criterio += String.Format(" AND nombre ILIKE '%{0}%'", NombreLocalidadTxt.Text);
            }

            try
            {
                var lista = Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmLocalidadList frm = new FrmLocalidadList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CodPostalChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CodPostalTxt.Enabled = this.CodPostalChk.Checked;
        }

  


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        
        private void FrmLocalidadBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void CancelarBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NombreLocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreLocalidadTxt.Enabled = this.NombreLocalidadChk.Checked;
        }

        private void CodPostalTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }     
        }
    }
}