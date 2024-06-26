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
            this.ImporteTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PaqueteCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anadirBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImporteTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PaqueteCbo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ImporteTxt
            // 
            this.ImporteTxt.Location = new System.Drawing.Point(84, 48);
            this.ImporteTxt.Name = "ImporteTxt";
            this.ImporteTxt.Size = new System.Drawing.Size(152, 20);
            this.ImporteTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe";
            // 
            // PaqueteCbo
            // 
            this.PaqueteCbo.DisplayMember = "Codigo";
            this.PaqueteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaqueteCbo.FormattingEnabled = true;
            this.PaqueteCbo.Location = new System.Drawing.Point(84, 17);
            this.PaqueteCbo.Name = "PaqueteCbo";
            this.PaqueteCbo.Size = new System.Drawing.Size(152, 21);
            this.PaqueteCbo.TabIndex = 1;
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
            this.anadirBtn.Location = new System.Drawing.Point(186, 129);
            this.anadirBtn.Name = "anadirBtn";
            this.anadirBtn.Size = new System.Drawing.Size(75, 23);
            this.anadirBtn.TabIndex = 1;
            this.anadirBtn.Text = "Añadir...";
            this.anadirBtn.UseVisualStyleBackColor = true;
            this.anadirBtn.Click += new System.EventHandler(this.anadirBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(39, 129);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 2;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // FrmDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 166);
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
        private System.Windows.Forms.TextBox ImporteTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PaqueteCbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anadirBtn;
        private System.Windows.Forms.Button cancelarBtn;
    }
}