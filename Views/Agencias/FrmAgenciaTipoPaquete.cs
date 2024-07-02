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
    public partial class FrmAgenciaTipoPaquete : FormBase
    {
        public FrmAgenciaTipoPaquete()
        {
            InitializeComponent();
        }

        private void FrmAgenciaTipoPaquete_Load(object sender, EventArgs e)
        {
            LoadComboBox(Agencia.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre)), agenciaCbo, "Nombre");
            LoadComboBox(TipoPaquete.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre)), tipoPaqueteCbo);
            agenciaCbo.SelectedIndex = -1;
            tipoPaqueteCbo.SelectedIndex = -1;
        }

        private void tipoPaqueteGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            for (int i = 0; i < this.tipoPaqueteGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.tipoPaqueteGrd.Rows[i];
                AgenciaTipoPaquete agenciaTipoPaq = item.DataBoundItem  as AgenciaTipoPaquete;
                item.Cells[0].Value = agenciaTipoPaq.CodTipoPaquete;
                item.Cells[1].Value = agenciaTipoPaq.TipoPaqueteObj.Nombre;
            }
        }

        private void agenciaCbo_SelectedValueChanged(object sender, EventArgs e)
        {
            mainGroup.Visible = agenciaCbo.SelectedIndex != -1;
            Agencia agencia = agenciaCbo.SelectedItem as Agencia;
            tipoPaqueteGrd.AutoGenerateColumns = false;

            if (agencia != null) {
                gridLbl.Text = "Tipos de paquete ofrecidos por " + agencia.Nombre;
                List<AgenciaTipoPaquete> lista = AgenciaTipoPaquete.FindAllStatic("cod_agencia=" + agencia.Codigo, null);
                tipoPaqueteGrd.DataSource = lista;
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anadirBtn_Click(object sender, EventArgs e)
        {
            if (agenciaCbo.SelectedIndex == -1 || tipoPaqueteCbo.SelectedIndex == -1) {
                MessageBox.Show("Falta seleccionar un tipo de paquete", "Faltan datos...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                AgenciaTipoPaquete atp = new AgenciaTipoPaquete();
                atp.CodAgencia = (agenciaCbo.SelectedItem as Agencia).Codigo;
                atp.CodTipoPaquete = (tipoPaqueteCbo.SelectedItem as TipoPaquete).Codigo;
                atp.SaveObj();
                MessageBox.Show("Tipo de paquete añadido con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tipoPaqueteGrd.DataSource = AgenciaTipoPaquete.FindAllStatic("cod_agencia=" + atp.CodAgencia, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El tipo de paquete ingresado ya está vinculado o se produjo otro error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



    }
}
