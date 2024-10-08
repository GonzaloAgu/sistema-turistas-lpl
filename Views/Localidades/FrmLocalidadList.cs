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
    public partial class FrmLocalidadList : FormBase
    {
        private string _criterio = null;
        private List<Localidad> _listado;

        public FrmLocalidadList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowListado(List<Localidad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.LocalidadesGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Localidad>(listado);
            var source = new BindingSource(bindingList, null);
            //this.LocalidadesGrd.DataSource = listado;
            this.LocalidadesGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmList_Load(object sender, EventArgs e)
        {

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EspecialidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.LocalidadesGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.LocalidadesGrd.Rows[i];
                item.Cells[3].Value = (item.DataBoundItem as Localidad).Nombre;
            }
        }

        private void TuristasGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.LocalidadesGrd.SelectedRows.Count > 0)
            {

                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmLocalidadAM frm = new FrmLocalidadAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarLocalidad(this, (this.LocalidadesGrd.SelectedRows[0].DataBoundItem as Localidad));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = LocalidadesGrd.SelectedRows[0].Index;
                this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(_criterio, (e1, e2) => e1.Codigo.CompareTo(e2.Codigo));
                LocalidadesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Localidadd actualizada", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LocalidadesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (LocalidadesGrd.Tag != null)
                sortOrderGrid = LocalidadesGrd.Tag.ToString();
            DataGridViewColumn newColumn = LocalidadesGrd.Columns[e.ColumnIndex];
            
            ListSortDirection direction = ListSortDirection.Ascending;
            if (sortOrderGrid == "")
                direction = ListSortDirection.Ascending;
            else
            {
                if (sortOrderGrid.IndexOf("-") != -1)
                    direction = ListSortDirection.Ascending;
                else
                    direction = ListSortDirection.Descending;
            }
            var localidades = (LocalidadesGrd.DataSource as BindingSource).List.Cast<Localidad>().ToList();
            sortOrderGrid = direction == ListSortDirection.Descending ? "-" : "" + newColumn.Name;
            if (newColumn.Name == "Nombre")
                localidades.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Nombre.CompareTo(t2.Nombre) : t2.Nombre.CompareTo(t1.Nombre)));
            if (newColumn.Name == "Codigo Postal")
                localidades.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo)));
            LocalidadesGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;
            LocalidadesGrd.DataSource = null;
            var bindingList = new BindingList<Localidad>(localidades);
            var source = new BindingSource(bindingList, null);
            LocalidadesGrd.DataSource = source;
            LocalidadesGrd.Tag = sortOrderGrid;
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void LocalidadesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CerrarBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      

      

    }     
}
