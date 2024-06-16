using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;

namespace TurApp.Views {
    public partial class FrmListadoFormaPago : FormBase {
        public FrmListadoFormaPago() {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm) {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void FrmListadoFormaPago_Load(object sender, EventArgs e) {
            FormaPagoGrd.AutoGenerateColumns = false;
            FormaPagoGrd.DataSource = FormaPago.FindAllStatic(null, (a1, a2) => a1.Forma.CompareTo(a2.Forma));
        }

        private void FiltroBtn_Click(object sender, EventArgs e) {
            string criterio = null;

            if (FormaTxt.Text != "")
                criterio = String.Format("forma='{0}'", FormaTxt.Text);
            FormaPagoGrd.DataSource = FormaPago.FindAllStatic(criterio, (a1, a2) => a1.Forma.CompareTo(a2.Forma));
        }
    }
}
