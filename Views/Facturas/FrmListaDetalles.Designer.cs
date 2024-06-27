namespace TurApp.Views
{
    partial class FrmListaDetalles
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.facturaTxt = new System.Windows.Forms.Label();
            this.detallesGrd = new System.Windows.Forms.DataGridView();
            this.Renglon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipoPaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTipoPaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cerrarBtn = new System.Windows.Forms.Button();
            this.TuristaTxt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detallesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TuristaTxt);
            this.groupBox1.Controls.Add(this.facturaTxt);
            this.groupBox1.Controls.Add(this.detallesGrd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // facturaTxt
            // 
            this.facturaTxt.AutoSize = true;
            this.facturaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturaTxt.Location = new System.Drawing.Point(28, 16);
            this.facturaTxt.Name = "facturaTxt";
            this.facturaTxt.Size = new System.Drawing.Size(33, 16);
            this.facturaTxt.TabIndex = 1;
            this.facturaTxt.Text = "&Nro:";
            // 
            // detallesGrd
            // 
            this.detallesGrd.AllowUserToAddRows = false;
            this.detallesGrd.AllowUserToDeleteRows = false;
            this.detallesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Renglon,
            this.NombreTipoPaquete,
            this.DescripcionTipoPaquete,
            this.Importe});
            this.detallesGrd.Location = new System.Drawing.Point(20, 78);
            this.detallesGrd.Name = "detallesGrd";
            this.detallesGrd.ReadOnly = true;
            this.detallesGrd.Size = new System.Drawing.Size(626, 222);
            this.detallesGrd.TabIndex = 0;
            this.detallesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.detallesGrd_DataBindingComplete);
            // 
            // Renglon
            // 
            this.Renglon.DataPropertyName = "NroRenglon";
            this.Renglon.HeaderText = "Renglon";
            this.Renglon.Name = "Renglon";
            this.Renglon.ReadOnly = true;
            this.Renglon.Width = 70;
            // 
            // NombreTipoPaquete
            // 
            this.NombreTipoPaquete.HeaderText = "Nombre Paquete";
            this.NombreTipoPaquete.Name = "NombreTipoPaquete";
            this.NombreTipoPaquete.ReadOnly = true;
            this.NombreTipoPaquete.Width = 160;
            // 
            // DescripcionTipoPaquete
            // 
            this.DescripcionTipoPaquete.HeaderText = "Descripción";
            this.DescripcionTipoPaquete.Name = "DescripcionTipoPaquete";
            this.DescripcionTipoPaquete.ReadOnly = true;
            this.DescripcionTipoPaquete.Width = 250;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // cerrarBtn
            // 
            this.cerrarBtn.Location = new System.Drawing.Point(556, 344);
            this.cerrarBtn.Name = "cerrarBtn";
            this.cerrarBtn.Size = new System.Drawing.Size(102, 23);
            this.cerrarBtn.TabIndex = 1;
            this.cerrarBtn.Text = "Cerrar";
            this.cerrarBtn.UseVisualStyleBackColor = true;
            this.cerrarBtn.Click += new System.EventHandler(this.cerrarBtn_Click);
            // 
            // TuristaTxt
            // 
            this.TuristaTxt.AutoSize = true;
            this.TuristaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuristaTxt.Location = new System.Drawing.Point(28, 45);
            this.TuristaTxt.Name = "TuristaTxt";
            this.TuristaTxt.Size = new System.Drawing.Size(33, 16);
            this.TuristaTxt.TabIndex = 2;
            this.TuristaTxt.Text = "&Nro:";
            // 
            // FrmListaDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 379);
            this.Controls.Add(this.cerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmListaDetalles";
            this.Text = "Detalle de Factura";
            this.Load += new System.EventHandler(this.FrmListaDetalles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detallesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView detallesGrd;
        private System.Windows.Forms.Button cerrarBtn;
        private System.Windows.Forms.Label facturaTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renglon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTipoPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label TuristaTxt;
    }
}