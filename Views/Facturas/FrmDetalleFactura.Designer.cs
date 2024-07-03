namespace TurApp.Views {
    partial class FrmDetalleFactura {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.importeLabel = new System.Windows.Forms.Label();
            this.PaqueteCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anadirBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.importeLabel);
            this.groupBox1.Controls.Add(this.PaqueteCbo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // importeLabel
            // 
            this.importeLabel.AutoSize = true;
            this.importeLabel.Location = new System.Drawing.Point(19, 57);
            this.importeLabel.Name = "importeLabel";
            this.importeLabel.Size = new System.Drawing.Size(0, 13);
            this.importeLabel.TabIndex = 2;
            this.importeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PaqueteCbo
            // 
            this.PaqueteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaqueteCbo.FormattingEnabled = true;
            this.PaqueteCbo.Location = new System.Drawing.Point(84, 17);
            this.PaqueteCbo.Name = "PaqueteCbo";
            this.PaqueteCbo.Size = new System.Drawing.Size(255, 21);
            this.PaqueteCbo.TabIndex = 1;
            this.PaqueteCbo.SelectedValueChanged += new System.EventHandler(this.PaqueteCbo_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paquete";
            // 
            // anadirBtn
            // 
            this.anadirBtn.Location = new System.Drawing.Point(203, 129);
            this.anadirBtn.Name = "anadirBtn";
            this.anadirBtn.Size = new System.Drawing.Size(75, 23);
            this.anadirBtn.TabIndex = 3;
            this.anadirBtn.Text = "Añadir...";
            this.anadirBtn.UseVisualStyleBackColor = true;
            this.anadirBtn.Click += new System.EventHandler(this.anadirBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(295, 129);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 4;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // FrmDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 166);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.anadirBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDetalleFactura";
            this.Text = "Añadir detalle a factura..";
            this.Load += new System.EventHandler(this.FrmDetalleFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label importeLabel;
        private System.Windows.Forms.ComboBox PaqueteCbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anadirBtn;
        private System.Windows.Forms.Button cancelarBtn;
    }
}