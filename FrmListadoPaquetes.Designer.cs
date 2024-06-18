namespace TurApp.Views
{
    partial class FrmListadoPaquetes
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
            this.PaquetesGrd = new System.Windows.Forms.DataGridView();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TipoPaqTxt = new System.Windows.Forms.TextBox();
            this.TipoPaqChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NivelTxt = new System.Windows.Forms.TextBox();
            this.NivelChk = new System.Windows.Forms.CheckBox();
            this.ExportarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaquetesGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaquetesGrd
            // 
            this.PaquetesGrd.AllowUserToAddRows = false;
            this.PaquetesGrd.AllowUserToDeleteRows = false;
            this.PaquetesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaquetesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniCol,
            this.ApellidoCol,
            this.NombreCol,
            this.Fecha,
            this.DniTur,
            this.Nivel,
            this.Destino});
            this.PaquetesGrd.Location = new System.Drawing.Point(9, 69);
            this.PaquetesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.PaquetesGrd.MultiSelect = false;
            this.PaquetesGrd.Name = "PaquetesGrd";
            this.PaquetesGrd.ReadOnly = true;
            this.PaquetesGrd.RowTemplate.Height = 24;
            this.PaquetesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaquetesGrd.ShowEditingIcon = false;
            this.PaquetesGrd.Size = new System.Drawing.Size(826, 384);
            this.PaquetesGrd.TabIndex = 0;
            this.PaquetesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PaquetesGrd_DataBindingComplete);
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "Codigo";
            this.DniCol.HeaderText = "Codigo";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
            // 
            // ApellidoCol
            // 
            this.ApellidoCol.DataPropertyName = "CodTP";
            this.ApellidoCol.HeaderText = "Tipo paquete";
            this.ApellidoCol.Name = "ApellidoCol";
            this.ApellidoCol.ReadOnly = true;
            this.ApellidoCol.Width = 150;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "CodAge";
            this.NombreCol.HeaderText = "Cod agencia";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // DniTur
            // 
            this.DniTur.HeaderText = "Dni turista";
            this.DniTur.Name = "DniTur";
            this.DniTur.ReadOnly = true;
            // 
            // Nivel
            // 
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "Destino";
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TipoPaqTxt);
            this.groupBox1.Controls.Add(this.TipoPaqChk);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(227, 42);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // TipoPaqTxt
            // 
            this.TipoPaqTxt.Location = new System.Drawing.Point(107, 14);
            this.TipoPaqTxt.Name = "TipoPaqTxt";
            this.TipoPaqTxt.Size = new System.Drawing.Size(98, 20);
            this.TipoPaqTxt.TabIndex = 9;
            // 
            // TipoPaqChk
            // 
            this.TipoPaqChk.AutoSize = true;
            this.TipoPaqChk.Location = new System.Drawing.Point(4, 17);
            this.TipoPaqChk.Margin = new System.Windows.Forms.Padding(2);
            this.TipoPaqChk.Name = "TipoPaqChk";
            this.TipoPaqChk.Size = new System.Drawing.Size(89, 17);
            this.TipoPaqChk.TabIndex = 0;
            this.TipoPaqChk.Text = "Tipo paquete";
            this.TipoPaqChk.UseVisualStyleBackColor = true;
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(719, 18);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 2;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NivelTxt);
            this.groupBox3.Controls.Add(this.NivelChk);
            this.groupBox3.Location = new System.Drawing.Point(259, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(225, 41);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // NivelTxt
            // 
            this.NivelTxt.Location = new System.Drawing.Point(97, 14);
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(100, 20);
            this.NivelTxt.TabIndex = 8;
            // 
            // NivelChk
            // 
            this.NivelChk.AutoSize = true;
            this.NivelChk.Location = new System.Drawing.Point(10, 15);
            this.NivelChk.Margin = new System.Windows.Forms.Padding(2);
            this.NivelChk.Name = "NivelChk";
            this.NivelChk.Size = new System.Drawing.Size(50, 17);
            this.NivelChk.TabIndex = 0;
            this.NivelChk.Text = "Nivel";
            this.NivelChk.UseVisualStyleBackColor = true;
            this.NivelChk.CheckedChanged += new System.EventHandler(this.PaisChk_CheckedChanged);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Enabled = false;
            this.ExportarBtn.Location = new System.Drawing.Point(736, 458);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 7;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // FrmListadoPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 493);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PaquetesGrd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmListadoPaquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Turistas";
            ((System.ComponentModel.ISupportInitialize)(this.PaquetesGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PaquetesGrd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox TipoPaqChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox NivelChk;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.TextBox NivelTxt;
        private System.Windows.Forms.TextBox TipoPaqTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
    }
}