namespace TurApp.Views
{
    partial class FrmPaqueteActividad
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
            this.paqueteCbo = new System.Windows.Forms.ComboBox();
            this.PaqLbl = new System.Windows.Forms.Label();
            this.mainGroup = new System.Windows.Forms.GroupBox();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.detalleTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ImporteTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anadirBtn = new System.Windows.Forms.Button();
            this.ActividadCbo = new System.Windows.Forms.ComboBox();
            this.gridLbl = new System.Windows.Forms.Label();
            this.ActividadesGrd = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActividadesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(494, 367);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(75, 23);
            this.CerrarBtn.TabIndex = 7;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // paqueteCbo
            // 
            this.paqueteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paqueteCbo.Location = new System.Drawing.Point(87, 15);
            this.paqueteCbo.Name = "paqueteCbo";
            this.paqueteCbo.Size = new System.Drawing.Size(241, 21);
            this.paqueteCbo.TabIndex = 0;
            this.paqueteCbo.SelectedValueChanged += new System.EventHandler(this.paqueteCbo_SelectedValueChanged);
            // 
            // PaqLbl
            // 
            this.PaqLbl.AutoSize = true;
            this.PaqLbl.Location = new System.Drawing.Point(17, 18);
            this.PaqLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PaqLbl.Name = "PaqLbl";
            this.PaqLbl.Size = new System.Drawing.Size(47, 13);
            this.PaqLbl.TabIndex = 14;
            this.PaqLbl.Text = "&Paquete";
            // 
            // mainGroup
            // 
            this.mainGroup.Controls.Add(this.Calendario);
            this.mainGroup.Controls.Add(this.detalleTxt);
            this.mainGroup.Controls.Add(this.label4);
            this.mainGroup.Controls.Add(this.fechaBtn);
            this.mainGroup.Controls.Add(this.label3);
            this.mainGroup.Controls.Add(this.ImporteTxt);
            this.mainGroup.Controls.Add(this.label2);
            this.mainGroup.Controls.Add(this.label1);
            this.mainGroup.Controls.Add(this.anadirBtn);
            this.mainGroup.Controls.Add(this.ActividadCbo);
            this.mainGroup.Controls.Add(this.gridLbl);
            this.mainGroup.Controls.Add(this.ActividadesGrd);
            this.mainGroup.Location = new System.Drawing.Point(14, 42);
            this.mainGroup.Name = "mainGroup";
            this.mainGroup.Size = new System.Drawing.Size(565, 314);
            this.mainGroup.TabIndex = 1;
            this.mainGroup.TabStop = false;
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(115, 85);
            this.Calendario.MaxSelectionCount = 90;
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 22;
            this.Calendario.Visible = false;
            this.Calendario.MouseLeave += new System.EventHandler(this.Calendario_MouseLeave);
            // 
            // detalleTxt
            // 
            this.detalleTxt.Location = new System.Drawing.Point(334, 216);
            this.detalleTxt.MaxLength = 120;
            this.detalleTxt.Multiline = true;
            this.detalleTxt.Name = "detalleTxt";
            this.detalleTxt.Size = new System.Drawing.Size(221, 57);
            this.detalleTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Detalle";
            // 
            // fechaBtn
            // 
            this.fechaBtn.Location = new System.Drawing.Point(115, 224);
            this.fechaBtn.Name = "fechaBtn";
            this.fechaBtn.Size = new System.Drawing.Size(84, 23);
            this.fechaBtn.TabIndex = 3;
            this.fechaBtn.Text = "Elegir fechas";
            this.fechaBtn.UseVisualStyleBackColor = true;
            this.fechaBtn.Click += new System.EventHandler(this.fechaBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rango de fechas";
            // 
            // ImporteTxt
            // 
            this.ImporteTxt.Location = new System.Drawing.Point(115, 253);
            this.ImporteTxt.Name = "ImporteTxt";
            this.ImporteTxt.Size = new System.Drawing.Size(199, 20);
            this.ImporteTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Importe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Actividad";
            // 
            // anadirBtn
            // 
            this.anadirBtn.Location = new System.Drawing.Point(447, 285);
            this.anadirBtn.Name = "anadirBtn";
            this.anadirBtn.Size = new System.Drawing.Size(108, 23);
            this.anadirBtn.TabIndex = 6;
            this.anadirBtn.Text = "Añadir actividad";
            this.anadirBtn.UseVisualStyleBackColor = true;
            this.anadirBtn.Click += new System.EventHandler(this.anadirBtn_Click);
            // 
            // ActividadCbo
            // 
            this.ActividadCbo.DisplayMember = "Codigo";
            this.ActividadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActividadCbo.FormattingEnabled = true;
            this.ActividadCbo.Location = new System.Drawing.Point(115, 197);
            this.ActividadCbo.Name = "ActividadCbo";
            this.ActividadCbo.Size = new System.Drawing.Size(199, 21);
            this.ActividadCbo.TabIndex = 2;
            this.ActividadCbo.ValueMember = "Codigo";
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
            // ActividadesGrd
            // 
            this.ActividadesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActividadesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Importe,
            this.FechaInicio,
            this.FechaFin,
            this.Detalle});
            this.ActividadesGrd.Location = new System.Drawing.Point(11, 39);
            this.ActividadesGrd.Name = "ActividadesGrd";
            this.ActividadesGrd.RowHeadersVisible = false;
            this.ActividadesGrd.Size = new System.Drawing.Size(544, 127);
            this.ActividadesGrd.TabIndex = 0;
            this.ActividadesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tipoPaqueteGrd_DataBindingComplete);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Actividad (Tipo)";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 75;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaHoraDesde";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 90;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaHoraHasta";
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 90;
            // 
            // Detalle
            // 
            this.Detalle.DataPropertyName = "Detalle";
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 160;
            // 
            // FrmPaqueteActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 402);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.paqueteCbo);
            this.Controls.Add(this.PaqLbl);
            this.Controls.Add(this.mainGroup);
            this.Name = "FrmPaqueteActividad";
            this.Text = "Actividades por paquete...";
            this.Load += new System.EventHandler(this.FrmPaqueteActividad_Load);
            this.mainGroup.ResumeLayout(false);
            this.mainGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActividadesGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.ComboBox paqueteCbo;
        private System.Windows.Forms.Label PaqLbl;
        private System.Windows.Forms.GroupBox mainGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anadirBtn;
        private System.Windows.Forms.ComboBox ActividadCbo;
        private System.Windows.Forms.Label gridLbl;
        private System.Windows.Forms.DataGridView ActividadesGrd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ImporteTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fechaBtn;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.TextBox detalleTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
    }
}