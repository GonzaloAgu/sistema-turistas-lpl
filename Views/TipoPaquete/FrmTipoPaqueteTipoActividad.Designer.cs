namespace TurApp.Views
{
    partial class FrmTipoPaqueteTipoActividad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.tipopPaqueteCbo = new System.Windows.Forms.ComboBox();
            this.CodTP = new System.Windows.Forms.Label();
            this.mainGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anadirBtn = new System.Windows.Forms.Button();
            this.gridLbl = new System.Windows.Forms.Label();
            this.tipoActividadGrd = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoActividadGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(235, 290);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(75, 23);
            this.CerrarBtn.TabIndex = 12;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            // 
            // tipopPaqueteCbo
            // 
            this.tipopPaqueteCbo.DisplayMember = "Codigo";
            this.tipopPaqueteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipopPaqueteCbo.FormattingEnabled = true;
            this.tipopPaqueteCbo.Location = new System.Drawing.Point(109, 17);
            this.tipopPaqueteCbo.Name = "tipopPaqueteCbo";
            this.tipopPaqueteCbo.Size = new System.Drawing.Size(184, 21);
            this.tipopPaqueteCbo.TabIndex = 13;
            this.tipopPaqueteCbo.ValueMember = "Codigo";
            // 
            // CodTP
            // 
            this.CodTP.AutoSize = true;
            this.CodTP.Location = new System.Drawing.Point(39, 20);
            this.CodTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodTP.Name = "CodTP";
            this.CodTP.Size = new System.Drawing.Size(68, 13);
            this.CodTP.TabIndex = 14;
            this.CodTP.Text = "&TipoPaquete";
            // 
            // mainGroup
            // 
            this.mainGroup.Controls.Add(this.label1);
            this.mainGroup.Controls.Add(this.anadirBtn);
            this.mainGroup.Controls.Add(this.gridLbl);
            this.mainGroup.Controls.Add(this.tipoActividadGrd);
            this.mainGroup.Location = new System.Drawing.Point(31, 47);
            this.mainGroup.Name = "mainGroup";
            this.mainGroup.Size = new System.Drawing.Size(278, 237);
            this.mainGroup.TabIndex = 11;
            this.mainGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo Actividad:";
            // 
            // anadirBtn
            // 
            this.anadirBtn.Location = new System.Drawing.Point(196, 196);
            this.anadirBtn.Name = "anadirBtn";
            this.anadirBtn.Size = new System.Drawing.Size(75, 23);
            this.anadirBtn.TabIndex = 12;
            this.anadirBtn.Text = "Añadir";
            this.anadirBtn.UseVisualStyleBackColor = true;
            // 
            // gridLbl
            // 
            this.gridLbl.AutoSize = true;
            this.gridLbl.Location = new System.Drawing.Point(9, 23);
            this.gridLbl.Name = "gridLbl";
            this.gridLbl.Size = new System.Drawing.Size(33, 13);
            this.gridLbl.TabIndex = 1;
            this.gridLbl.Text = "Tipos";
            // 
            // tipoActividadGrd
            // 
            this.tipoActividadGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoActividadGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre});
            this.tipoActividadGrd.Location = new System.Drawing.Point(11, 39);
            this.tipoActividadGrd.Name = "tipoActividadGrd";
            this.tipoActividadGrd.RowHeadersVisible = false;
            this.tipoActividadGrd.Size = new System.Drawing.Size(260, 127);
            this.tipoActividadGrd.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 205;
            // 
            // FrmTipoPaqueteTipoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 331);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.tipopPaqueteCbo);
            this.Controls.Add(this.CodTP);
            this.Controls.Add(this.mainGroup);
            this.Name = "FrmTipoPaqueteTipoActividad";
            this.Text = "Vincular tipo de actividad...";
            this.mainGroup.ResumeLayout(false);
            this.mainGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoActividadGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.ComboBox tipopPaqueteCbo;
        private System.Windows.Forms.Label CodTP;
        private System.Windows.Forms.GroupBox mainGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anadirBtn;
        //private System.Windows.Forms.ComboBox tipoPaqueteCbo;
        private System.Windows.Forms.Label gridLbl;
        private System.Windows.Forms.DataGridView tipoActividadGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;

    }
}