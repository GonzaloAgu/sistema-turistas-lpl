﻿namespace TurApp.Views
{
    partial class FrmListadoTipoActividad
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
            this.TipoActividadGrd = new System.Windows.Forms.DataGridView();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.FiltrarBtn = new System.Windows.Forms.Button();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.nombrecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioncol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracioncol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TipoActividadGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoActividadGrd
            // 
            this.TipoActividadGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TipoActividadGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrecol,
            this.codigocol,
            this.descripcioncol,
            this.duracioncol,
            this.nivelcol});
            this.TipoActividadGrd.Location = new System.Drawing.Point(1, 60);
            this.TipoActividadGrd.Name = "TipoActividadGrd";
            this.TipoActividadGrd.RowTemplate.Height = 24;
            this.TipoActividadGrd.Size = new System.Drawing.Size(668, 227);
            this.TipoActividadGrd.TabIndex = 0;
            this.TipoActividadGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TipoActividadGrd_CellContentClick);
            this.TipoActividadGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TipoActividadGrd_DataBindingComplete);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(718, 182);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(75, 23);
            this.CerrarBtn.TabIndex = 1;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            // 
            // NombreChk
            // 
            this.NombreChk.AutoSize = true;
            this.NombreChk.Location = new System.Drawing.Point(12, 12);
            this.NombreChk.Name = "NombreChk";
            this.NombreChk.Size = new System.Drawing.Size(80, 21);
            this.NombreChk.TabIndex = 2;
            this.NombreChk.Text = "Nombre";
            this.NombreChk.UseVisualStyleBackColor = true;
            // 
            // FiltrarBtn
            // 
            this.FiltrarBtn.Location = new System.Drawing.Point(626, 12);
            this.FiltrarBtn.Name = "FiltrarBtn";
            this.FiltrarBtn.Size = new System.Drawing.Size(75, 23);
            this.FiltrarBtn.TabIndex = 3;
            this.FiltrarBtn.Text = "Filtrar";
            this.FiltrarBtn.UseVisualStyleBackColor = true;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(140, 10);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(173, 22);
            this.NombreTxt.TabIndex = 4;
            // 
            // nombrecol
            // 
            this.nombrecol.HeaderText = "nombre";
            this.nombrecol.Name = "nombrecol";
            // 
            // codigocol
            // 
            this.codigocol.HeaderText = "codigo";
            this.codigocol.Name = "codigocol";
            // 
            // descripcioncol
            // 
            this.descripcioncol.HeaderText = "descripcion";
            this.descripcioncol.Name = "descripcioncol";
            // 
            // duracioncol
            // 
            this.duracioncol.HeaderText = "duracion";
            this.duracioncol.Name = "duracioncol";
            // 
            // nivelcol
            // 
            this.nivelcol.HeaderText = "nivel";
            this.nivelcol.Name = "nivelcol";
            // 
            // FrmListadoTipoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 290);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.FiltrarBtn);
            this.Controls.Add(this.NombreChk);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.TipoActividadGrd);
            this.Name = "FrmListadoTipoActividad";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmListadoTipoActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipoActividadGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TipoActividadGrd;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.Button FiltrarBtn;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioncol;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracioncol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelcol;
    }
}