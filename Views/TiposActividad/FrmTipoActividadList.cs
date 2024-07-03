using System;
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
    public partial class FrmTipoActividadList : FormBase
    {
        private string _criterio = null;
        private List<TipoActividad> _listado;

        public FrmTipoActividadList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            // Configuración de permisos, implementar según sea necesario
        }

        public void ShowListado(List<TipoActividad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.TipoActividadesGrd.AutoGenerateColumns = false;
            this.TipoActividadesGrd.DataSource = _listado;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmTipoActividadList_Load(object sender, EventArgs e)
        {
            // Cargar configuraciones adicionales si es necesario
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TipoActividadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.TipoActividadesGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.TipoActividadesGrd.Rows[i];
                item.Cells[0].Value = (item.DataBoundItem as TipoActividad).Nombre;
                item.Cells[1].Value = (item.DataBoundItem as TipoActividad).Codigo;
                item.Cells[2].Value = (item.DataBoundItem as TipoActividad).Descripcion;
                item.Cells[3].Value = (item.DataBoundItem as TipoActividad).Duracion;
                item.Cells[4].Value = (item.DataBoundItem as TipoActividad).Nivel;
            }
        }

        private void TipoActividadesGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.TipoActividadesGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmTipoActividadAM frm = new FrmTipoActividadAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarTipoActividad(this, (this.TipoActividadesGrd.SelectedRows[0].DataBoundItem as TipoActividad));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = TipoActividadesGrd.SelectedRows[0].Index;
                this.TipoActividadesGrd.DataSource = TipoActividad.FindAllStatic(_criterio, (e1, e2) => e1.Codigo.CompareTo(e2.Codigo));
                TipoActividadesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Tipo de actividad actualizada", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TipoActividadesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (TipoActividadesGrd.Tag != null)
                sortOrderGrid = TipoActividadesGrd.Tag.ToString();
            DataGridViewColumn newColumn = TipoActividadesGrd.Columns[e.ColumnIndex];

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
            var tipoActividades = (TipoActividadesGrd.DataSource as BindingSource).List.Cast<TipoActividad>().ToList();
            sortOrderGrid = direction == ListSortDirection.Descending ? "-" : "" + newColumn.Name;
            if (newColumn.Name == "Nombre")
                tipoActividades.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Nombre.CompareTo(t2.Nombre) : t2.Nombre.CompareTo(t1.Nombre)));
            if (newColumn.Name == "Codigo")
                tipoActividades.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo)));
            TipoActividadesGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;
            TipoActividadesGrd.DataSource = null;
            var bindingList = new BindingList<TipoActividad>(tipoActividades);
            var source = new BindingSource(bindingList, null);
            TipoActividadesGrd.DataSource = source;
            TipoActividadesGrd.Tag = sortOrderGrid;
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void TipoActividadesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementar lógica adicional si es necesario
        }

        private void CerrarBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      

        

       

        
    }
}

