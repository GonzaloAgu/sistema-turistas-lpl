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
    public partial class FrmPaqueteList : FormBase
    {
        private string _criterio = null;
        private List<Paquete> _listado;
        
        public FrmPaqueteList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        
        public void ShowListado(List<Paquete> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.PaquetesGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Paquete>(listado);
            var source = new BindingSource(bindingList, null);
            //this.PaquetesGrd.DataSource = listado;
            this.PaquetesGrd.DataSource =  source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmPaqueteList_Load(object sender, EventArgs e)
        {
            
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Paquetes_DataBinding(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            for (int i = 0; i < this.PaquetesGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.PaquetesGrd.Rows[i];

                // Esto debe hacerse para todas las columnas que sean una referencia a otro objeto.
                Paquete PaqueteObj = item.DataBoundItem as Paquete;

                item.Cells["DniTurista"].Value = PaqueteObj.TuristaObj.NroDocumento;
                item.Cells["CodAgencia"].Value = PaqueteObj.AgenciaObj.Codigo;
                item.Cells["CodTipoPaquete"].Value = PaqueteObj.TipoPaqueteObj.Codigo;
                item.Cells["CodDestino"].Value = PaqueteObj.DestinoObj.Codigo;
            }
        }

        private void EspecialidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for( int i=0;i<this.PaquetesGrd.Rows.Count;++i)
            {
                DataGridViewRow item  = this.PaquetesGrd.Rows[i];
                item.Cells[3].Value = (item.DataBoundItem as Paquete).Codigo;
            }
        }

        private void PaquetesGrd_DoubleClick(object sender, EventArgs e)
        {
            if( this.PaquetesGrd.SelectedRows.Count>0)
            {

                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmPaqueteAM frm = new FrmPaqueteAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarPaquete (this, (this.PaquetesGrd.SelectedRows[0].DataBoundItem as Paquete));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = PaquetesGrd.SelectedRows[0].Index;
                this.PaquetesGrd.DataSource = Paquete.FindAllStatic(_criterio, (e1, e2) => e1.Codigo.CompareTo(e2.Codigo));
                PaquetesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Paquete actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PaquetesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";
            
            if(PaquetesGrd.Tag!=null)
                sortOrderGrid = PaquetesGrd.Tag.ToString();
            DataGridViewColumn newColumn = PaquetesGrd.Columns[e.ColumnIndex];

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
            var Paquetes = (PaquetesGrd.DataSource as BindingSource).List.Cast<Paquete>().ToList();
            sortOrderGrid = direction == ListSortDirection.Descending ? "-" : "" + newColumn.Name;
            if (newColumn.Name == "Codigo")
                Paquetes.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo)));
            if (newColumn.Name == "TipoPaq")
                Paquetes.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.CodTipoPaquete.CompareTo(t2.CodTipoPaquete) : t2.CodTipoPaquete.CompareTo(t1.CodTipoPaquete)));
            if (newColumn.Name == "CodAgencia")
                Paquetes.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.CodAgencia.CompareTo(t2.CodAgencia) : t2.CodAgencia.CompareTo(t1.CodAgencia)));
            if (newColumn.Name == "Fecha")
                Paquetes.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Fecha.CompareTo(t2.Fecha) : t2.Fecha.CompareTo(t1.Fecha)));
            if (newColumn.Name == "DniTur")
                Paquetes.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.DniTurista.CompareTo(t2.DniTurista) : t2.DniTurista.CompareTo(t1.DniTurista)));
            if (newColumn.Name == "Nivel")
                Paquetes.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Nivel.CompareTo(t2.Nivel) : t2.Nivel.CompareTo(t1.Nivel)));
            PaquetesGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;
            PaquetesGrd.DataSource = null;
            var bindingList = new BindingList<Paquete>(Paquetes);
            var source = new BindingSource(bindingList, null);
            PaquetesGrd.DataSource = source;
            PaquetesGrd.Tag = sortOrderGrid;
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void TuristasGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
