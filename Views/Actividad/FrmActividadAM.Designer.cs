namespace TurApp.Views {
    partial class FrmActividadAM {
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
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nivelTxt = new System.Windows.Forms.TextBox();
            this.importeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TransporteCbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoActCB = new System.Windows.Forms.ComboBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(178, 212);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 1;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nivelTxt);
            this.groupBox1.Controls.Add(this.importeTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TransporteCbo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tipoActCB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // nivelTxt
            // 
            this.nivelTxt.Location = new System.Drawing.Point(120, 129);
            this.nivelTxt.Name = "nivelTxt";
            this.nivelTxt.Size = new System.Drawing.Size(121, 20);
            this.nivelTxt.TabIndex = 7;
            this.nivelTxt.Tag = "Nivel";
            this.nivelTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nivelTxt_KeyPress);
            // 
            // importeTxt
            // 
            this.importeTxt.Location = new System.Drawing.Point(120, 104);
            this.importeTxt.Name = "importeTxt";
            this.importeTxt.Size = new System.Drawing.Size(121, 20);
            this.importeTxt.TabIndex = 6;
            this.importeTxt.Tag = "Importe";
            this.importeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.importeTxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nivel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Importe";
            // 
            // TransporteCbo
            // 
            this.TransporteCbo.DisplayMember = "Descripcion";
            this.TransporteCbo.FormattingEnabled = true;
            this.TransporteCbo.Location = new System.Drawing.Point(120, 61);
            this.TransporteCbo.Name = "TransporteCbo";
            this.TransporteCbo.Size = new System.Drawing.Size(121, 21);
            this.TransporteCbo.TabIndex = 3;
            this.TransporteCbo.Tag = "CodTransporte";
            this.TransporteCbo.ValueMember = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de actividad";
            // 
            // tipoActCB
            // 
            this.tipoActCB.DisplayMember = "Nombre";
            this.tipoActCB.FormattingEnabled = true;
            this.tipoActCB.Location = new System.Drawing.Point(120, 34);
            this.tipoActCB.Name = "tipoActCB";
            this.tipoActCB.Size = new System.Drawing.Size(121, 21);
            this.tipoActCB.TabIndex = 0;
            this.tipoActCB.Tag = "CodTipoActividad";
            this.tipoActCB.ValueMember = "Codigo";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(45, 211);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 3;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // FrmActividadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GuardarBtn);
            this.Name = "FrmActividadAM";
            this.Text = "Actividad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tipoActCB;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TransporteCbo;
        private System.Windows.Forms.TextBox nivelTxt;
        private System.Windows.Forms.TextBox importeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}