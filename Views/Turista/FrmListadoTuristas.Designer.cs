﻿namespace TurApp.Views
{
    partial class FrmListadoTuristas
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
            this.TuristasGrd = new System.Windows.Forms.DataGridView();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Moroso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PaisCbo = new System.Windows.Forms.ComboBox();
            this.PaisChk = new System.Windows.Forms.CheckBox();
            this.ExportarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TuristasGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TuristasGrd
            // 
            this.TuristasGrd.AllowUserToAddRows = false;
            this.TuristasGrd.AllowUserToDeleteRows = false;
            this.TuristasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TuristasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniCol,
            this.ApellidoCol,
            this.NombreCol,
            this.LocCol,
            this.Activo,
            this.Moroso});
            this.TuristasGrd.Location = new System.Drawing.Point(12, 85);
            this.TuristasGrd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TuristasGrd.MultiSelect = false;
            this.TuristasGrd.Name = "TuristasGrd";
            this.TuristasGrd.ReadOnly = true;
            this.TuristasGrd.RowTemplate.Height = 24;
            this.TuristasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TuristasGrd.ShowEditingIcon = false;
            this.TuristasGrd.Size = new System.Drawing.Size(1101, 473);
            this.TuristasGrd.TabIndex = 0;
            this.TuristasGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TuristasGrd_CellContentClick);
            this.TuristasGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TuristasGrd_DataBindingComplete);
            this.TuristasGrd.DoubleClick += new System.EventHandler(this.TuristasGrd_DoubleClick);
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "NroDocumento";
            this.DniCol.HeaderText = "Dni";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
            // 
            // ApellidoCol
            // 
            this.ApellidoCol.DataPropertyName = "Apellido";
            this.ApellidoCol.HeaderText = "Apellido";
            this.ApellidoCol.Name = "ApellidoCol";
            this.ApellidoCol.ReadOnly = true;
            this.ApellidoCol.Width = 150;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Nombres";
            this.NombreCol.HeaderText = "Nombres";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 150;
            // 
            // LocCol
            // 
            this.LocCol.HeaderText = "Localidad";
            this.LocCol.Name = "LocCol";
            this.LocCol.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Moroso
            // 
            this.Moroso.DataPropertyName = "Moroso";
            this.Moroso.HeaderText = "Moroso";
            this.Moroso.Name = "Moroso";
            this.Moroso.ReadOnly = true;
            this.Moroso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Moroso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.NombreChk);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(303, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Enabled = false;
            this.ApellidoTxt.Location = new System.Drawing.Point(92, 18);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(193, 22);
            this.ApellidoTxt.TabIndex = 1;
            // 
            // NombreChk
            // 
            this.NombreChk.AutoSize = true;
            this.NombreChk.Location = new System.Drawing.Point(5, 21);
            this.NombreChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreChk.Name = "NombreChk";
            this.NombreChk.Size = new System.Drawing.Size(80, 21);
            this.NombreChk.TabIndex = 0;
            this.NombreChk.Text = "Nombre";
            this.NombreChk.UseVisualStyleBackColor = true;
            this.NombreChk.CheckedChanged += new System.EventHandler(this.NombreChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(959, 22);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(101, 39);
            this.FiltroBtn.TabIndex = 2;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PaisCbo);
            this.groupBox3.Controls.Add(this.PaisChk);
            this.groupBox3.Location = new System.Drawing.Point(358, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(300, 50);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // PaisCbo
            // 
            this.PaisCbo.DisplayMember = "Id";
            this.PaisCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaisCbo.Enabled = false;
            this.PaisCbo.FormattingEnabled = true;
            this.PaisCbo.Location = new System.Drawing.Point(120, 18);
            this.PaisCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaisCbo.Name = "PaisCbo";
            this.PaisCbo.Size = new System.Drawing.Size(152, 24);
            this.PaisCbo.TabIndex = 1;
            this.PaisCbo.ValueMember = "Nombre";
            // 
            // PaisChk
            // 
            this.PaisChk.AutoSize = true;
            this.PaisChk.Location = new System.Drawing.Point(13, 18);
            this.PaisChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaisChk.Name = "PaisChk";
            this.PaisChk.Size = new System.Drawing.Size(57, 21);
            this.PaisChk.TabIndex = 0;
            this.PaisChk.Text = "Pais";
            this.PaisChk.UseVisualStyleBackColor = true;
            this.PaisChk.CheckedChanged += new System.EventHandler(this.PaisChk_CheckedChanged);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Enabled = false;
            this.ExportarBtn.Location = new System.Drawing.Point(981, 564);
            this.ExportarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(112, 32);
            this.ExportarBtn.TabIndex = 7;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // FrmListadoTuristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 607);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TuristasGrd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmListadoTuristas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Turistas";
            this.Load += new System.EventHandler(this.FrmListadoTuristas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TuristasGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TuristasGrd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox PaisCbo;
        private System.Windows.Forms.CheckBox PaisChk;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Moroso;
    }
}