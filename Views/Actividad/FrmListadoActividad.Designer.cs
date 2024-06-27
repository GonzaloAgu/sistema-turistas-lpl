namespace TurApp.Views {
    partial class FrmListadoActividad {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TipoActividadCbo = new System.Windows.Forms.ComboBox();
            this.TipoActChk = new System.Windows.Forms.CheckBox();
            this.NivelChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.NivelTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ActividadesGrd = new System.Windows.Forms.DataGridView();
            this.TipoActCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActividadesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TipoActividadCbo);
            this.groupBox3.Controls.Add(this.TipoActChk);
            this.groupBox3.Location = new System.Drawing.Point(162, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(244, 41);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // TipoActividadCbo
            // 
            this.TipoActividadCbo.DisplayMember = "Nombre";
            this.TipoActividadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoActividadCbo.Enabled = false;
            this.TipoActividadCbo.FormattingEnabled = true;
            this.TipoActividadCbo.Location = new System.Drawing.Point(122, 13);
            this.TipoActividadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActividadCbo.Name = "TipoActividadCbo";
            this.TipoActividadCbo.Size = new System.Drawing.Size(115, 21);
            this.TipoActividadCbo.TabIndex = 1;
            // 
            // TipoActChk
            // 
            this.TipoActChk.AutoSize = true;
            this.TipoActChk.Location = new System.Drawing.Point(10, 15);
            this.TipoActChk.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActChk.Name = "TipoActChk";
            this.TipoActChk.Size = new System.Drawing.Size(108, 17);
            this.TipoActChk.TabIndex = 0;
            this.TipoActChk.Text = "Tipo de actividad";
            this.TipoActChk.UseVisualStyleBackColor = true;
            this.TipoActChk.CheckedChanged += new System.EventHandler(this.TipoAct_CheckedChange);
            // 
            // NivelChk
            // 
            this.NivelChk.AutoSize = true;
            this.NivelChk.Location = new System.Drawing.Point(4, 17);
            this.NivelChk.Margin = new System.Windows.Forms.Padding(2);
            this.NivelChk.Name = "NivelChk";
            this.NivelChk.Size = new System.Drawing.Size(50, 17);
            this.NivelChk.TabIndex = 0;
            this.NivelChk.Text = "Nivel";
            this.NivelChk.UseVisualStyleBackColor = true;
            this.NivelChk.CheckedChanged += new System.EventHandler(this.NivelChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(721, 19);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 10;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // NivelTxt
            // 
            this.NivelTxt.Enabled = false;
            this.NivelTxt.Location = new System.Drawing.Point(69, 15);
            this.NivelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(66, 20);
            this.NivelTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NivelTxt);
            this.groupBox1.Controls.Add(this.NivelChk);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(147, 42);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // ActividadesGrd
            // 
            this.ActividadesGrd.AllowUserToAddRows = false;
            this.ActividadesGrd.AllowUserToDeleteRows = false;
            this.ActividadesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActividadesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoActCol,
            this.DescripcionCol,
            this.ImporteCol,
            this.LocCol,
            this.TransporteCol});
            this.ActividadesGrd.Location = new System.Drawing.Point(11, 70);
            this.ActividadesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.ActividadesGrd.MultiSelect = false;
            this.ActividadesGrd.Name = "ActividadesGrd";
            this.ActividadesGrd.ReadOnly = true;
            this.ActividadesGrd.RowTemplate.Height = 24;
            this.ActividadesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActividadesGrd.ShowEditingIcon = false;
            this.ActividadesGrd.Size = new System.Drawing.Size(826, 384);
            this.ActividadesGrd.TabIndex = 8;
            this.ActividadesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ActividadesGrd_DataBindingComplete);
            // 
            // TipoActCol
            // 
            this.TipoActCol.HeaderText = "Tipo de Actividad";
            this.TipoActCol.Name = "TipoActCol";
            this.TipoActCol.ReadOnly = true;
            // 
            // DescripcionCol
            // 
            this.DescripcionCol.HeaderText = "Descripcion";
            this.DescripcionCol.Name = "DescripcionCol";
            this.DescripcionCol.ReadOnly = true;
            this.DescripcionCol.Width = 150;
            // 
            // ImporteCol
            // 
            this.ImporteCol.DataPropertyName = "Importe";
            this.ImporteCol.HeaderText = "Importe";
            this.ImporteCol.Name = "ImporteCol";
            this.ImporteCol.ReadOnly = true;
            this.ImporteCol.Width = 150;
            // 
            // LocCol
            // 
            this.LocCol.DataPropertyName = "Nivel";
            this.LocCol.HeaderText = "Nivel de dificultad";
            this.LocCol.Name = "LocCol";
            this.LocCol.ReadOnly = true;
            // 
            // TransporteCol
            // 
            this.TransporteCol.HeaderText = "Transporte";
            this.TransporteCol.Name = "TransporteCol";
            this.TransporteCol.ReadOnly = true;
            this.TransporteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Enabled = false;
            this.ExportarBtn.Location = new System.Drawing.Point(721, 473);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 12;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // FrmListadoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 523);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ActividadesGrd);
            this.Controls.Add(this.ExportarBtn);
            this.Name = "FrmListadoActividad";
            this.Text = "Listado de actividades";
            this.Load += new System.EventHandler(this.FrmListadoActividades_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActividadesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox TipoActividadCbo;
        private System.Windows.Forms.CheckBox TipoActChk;
        private System.Windows.Forms.CheckBox NivelChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.TextBox NivelTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ActividadesGrd;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoActCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransporteCol;
    }
}