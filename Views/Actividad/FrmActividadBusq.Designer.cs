﻿namespace TurApp.Views {
    partial class FrmActividadBusq {
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
            this.TransporteCbo = new System.Windows.Forms.ComboBox();
            this.TransporteChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.TipoActChk = new System.Windows.Forms.CheckBox();
            this.NivelTxt = new System.Windows.Forms.TextBox();
            this.NivelChk = new System.Windows.Forms.CheckBox();
            this.tipoActCb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransporteCbo
            // 
            this.TransporteCbo.DisplayMember = "Descripcion";
            this.TransporteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransporteCbo.Enabled = false;
            this.TransporteCbo.FormattingEnabled = true;
            this.TransporteCbo.Location = new System.Drawing.Point(97, 62);
            this.TransporteCbo.Margin = new System.Windows.Forms.Padding(2);
            this.TransporteCbo.Name = "TransporteCbo";
            this.TransporteCbo.Size = new System.Drawing.Size(175, 21);
            this.TransporteCbo.TabIndex = 7;
            this.TransporteCbo.ValueMember = "Codigo";
            // 
            // TransporteChk
            // 
            this.TransporteChk.AutoSize = true;
            this.TransporteChk.Location = new System.Drawing.Point(16, 64);
            this.TransporteChk.Margin = new System.Windows.Forms.Padding(2);
            this.TransporteChk.Name = "TransporteChk";
            this.TransporteChk.Size = new System.Drawing.Size(77, 17);
            this.TransporteChk.TabIndex = 6;
            this.TransporteChk.Text = "Transporte";
            this.TransporteChk.UseVisualStyleBackColor = true;
            this.TransporteChk.CheckedChanged += new System.EventHandler(this.Transporte_CheckChange);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(327, 136);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 9;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(403, 136);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 8;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // TipoActChk
            // 
            this.TipoActChk.AutoSize = true;
            this.TipoActChk.Location = new System.Drawing.Point(16, 25);
            this.TipoActChk.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActChk.Name = "TipoActChk";
            this.TipoActChk.Size = new System.Drawing.Size(47, 17);
            this.TipoActChk.TabIndex = 2;
            this.TipoActChk.Text = "Tipo";
            this.TipoActChk.UseVisualStyleBackColor = true;
            this.TipoActChk.CheckedChanged += new System.EventHandler(this.TipoActCheckedChanged);
            // 
            // NivelTxt
            // 
            this.NivelTxt.Enabled = false;
            this.NivelTxt.Location = new System.Drawing.Point(346, 23);
            this.NivelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(91, 20);
            this.NivelTxt.TabIndex = 5;
            this.NivelTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nivel_KeyPress);
            // 
            // NivelChk
            // 
            this.NivelChk.AutoSize = true;
            this.NivelChk.Location = new System.Drawing.Point(292, 26);
            this.NivelChk.Margin = new System.Windows.Forms.Padding(2);
            this.NivelChk.Name = "NivelChk";
            this.NivelChk.Size = new System.Drawing.Size(50, 17);
            this.NivelChk.TabIndex = 4;
            this.NivelChk.Text = "Nivel";
            this.NivelChk.UseVisualStyleBackColor = true;
            this.NivelChk.CheckedChanged += new System.EventHandler(this.Nivel_CheckChange);
            // 
            // tipoActCb
            // 
            this.tipoActCb.DisplayMember = "Nombre";
            this.tipoActCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoActCb.Enabled = false;
            this.tipoActCb.FormattingEnabled = true;
            this.tipoActCb.Location = new System.Drawing.Point(97, 23);
            this.tipoActCb.Name = "tipoActCb";
            this.tipoActCb.Size = new System.Drawing.Size(175, 21);
            this.tipoActCb.TabIndex = 3;
            this.tipoActCb.ValueMember = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipoActCb);
            this.groupBox1.Controls.Add(this.TransporteCbo);
            this.groupBox1.Controls.Add(this.TransporteChk);
            this.groupBox1.Controls.Add(this.TipoActChk);
            this.groupBox1.Controls.Add(this.NivelTxt);
            this.groupBox1.Controls.Add(this.NivelChk);
            this.groupBox1.Location = new System.Drawing.Point(8, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FrmActividadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 174);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Name = "FrmActividadBusq";
            this.Text = "Busqueda de actividad...";
            this.Load += new System.EventHandler(this.FrmActividadBusq_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TransporteCbo;
        private System.Windows.Forms.CheckBox TransporteChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.CheckBox TipoActChk;
        private System.Windows.Forms.TextBox NivelTxt;
        private System.Windows.Forms.CheckBox NivelChk;
        private System.Windows.Forms.ComboBox tipoActCb;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}