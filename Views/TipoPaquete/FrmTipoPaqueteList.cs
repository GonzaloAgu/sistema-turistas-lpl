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
    public partial class FrmTipoPaqueteList : FormBase
    {
        private string _criterio = null;
        private List<TipoPaquete> _listado;
        
        public FrmTipoPaqueteList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        
        public void ShowListado(List<TipoPaquete> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.TipoPaqueteGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<TipoPaquete>(listado);
            var source = new BindingSource(bindingList, null);
            //this.TuristasGrd.DataSource = listado;
            this.TipoPaqueteGrd.DataSource =  source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmTipoPaqueteList_Load(object sender, EventArgs e)
        {
            
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EspecialidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for( int i=0;i<this.TipoPaqueteGrd.Rows.Count;++i)
            {
                DataGridViewRow item  = this.TipoPaqueteGrd.Rows[i];
                //item.Cells[3].Value = (item.DataBoundItem as TipoPaquete).PaisObj.Nombre;
            }
        }

        private void TipoPaqueteGrd_DoubleClick(object sender, EventArgs e)
        {
            if( this.TipoPaqueteGrd.SelectedRows.Count>0)
            {
                /*
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmTuristaAM frm = new FrmTipoPaqueteAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarTipoPaquete (this, (this.TipoPaqueteGrd.SelectedRows[0].DataBoundItem as Turista));*/
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = TipoPaqueteGrd.SelectedRows[0].Index;
                this.TipoPaqueteGrd.DataSource = TipoPaquete.FindAllStatic(_criterio, (e1, e2) => e1.Codigo.CompareTo(e2.Codigo));
                TipoPaqueteGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Tipo paquete actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TipoPaqueteGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";
            
            if(TipoPaqueteGrd.Tag!=null)
                sortOrderGrid = TipoPaqueteGrd.Tag.ToString();
            DataGridViewColumn newColumn = TipoPaqueteGrd.Columns[e.ColumnIndex];
            if (newColumn.Name == "Descripcion") //columna no ordenable
                return; 
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
            var tpaquetes = (TipoPaqueteGrd.DataSource as BindingSource).List.Cast<TipoPaquete>().ToList();
            sortOrderGrid = direction == ListSortDirection.Descending ? "-" : "" + newColumn.Name;
            if (newColumn.Name == "Nombre")
                tpaquetes.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Nombre.CompareTo(t2.Nombre) : t2.Nombre.CompareTo(t1.Nombre)));
            if (newColumn.Name == "Duracion")
                tpaquetes.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Duracion.CompareTo(t2.Duracion) : t2.Duracion.CompareTo(t1.Duracion)));
            if (newColumn.Name == "Nivel")
                tpaquetes.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Nivel.CompareTo(t2.Nivel) : t2.Nivel.CompareTo(t1.Nivel)));
            if (newColumn.Name == "Codigo")
                tpaquetes.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo)));
            TipoPaqueteGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;
            TipoPaqueteGrd.DataSource = null;
            var bindingList = new BindingList<TipoPaquete>(tpaquetes);
            var source = new BindingSource(bindingList, null);
            TipoPaqueteGrd.DataSource = source;
            TipoPaqueteGrd.Tag = sortOrderGrid;
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void TipoPaqueteGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
