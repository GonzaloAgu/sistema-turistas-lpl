namespace TurApp.Views {
    partial class FrmFormaPagoList {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.FormasPagoGrd = new System.Windows.Forms.DataGridView();
            this.TipoActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.FormasPagoGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(247, 281);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 11;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // FormasPagoGrd
            // 
            this.FormasPagoGrd.AllowUserToAddRows = false;
            this.FormasPagoGrd.AllowUserToDeleteRows = false;
            this.FormasPagoGrd.AllowUserToResizeColumns = false;
            this.FormasPagoGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FormasPagoGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FormasPagoGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormasPagoGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoActividad});
            this.FormasPagoGrd.Location = new System.Drawing.Point(4, 17);
            this.FormasPagoGrd.Margin = new System.Windows.Forms.Padding(2);
            this.FormasPagoGrd.MultiSelect = false;
            this.FormasPagoGrd.Name = "FormasPagoGrd";
            this.FormasPagoGrd.ReadOnly = true;
            this.FormasPagoGrd.RowTemplate.Height = 24;
            this.FormasPagoGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FormasPagoGrd.Size = new System.Drawing.Size(277, 237);
            this.FormasPagoGrd.TabIndex = 0;
            this.FormasPagoGrd.DoubleClick += new System.EventHandler(this.FormasPagoGrd_DoubleClick);
            // 
            // TipoActividad
            // 
            this.TipoActividad.DataPropertyName = "Forma";
            this.TipoActividad.HeaderText = "Forma de pago";
            this.TipoActividad.Name = "TipoActividad";
            this.TipoActividad.ReadOnly = true;
            this.TipoActividad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TipoActividad.Width = 230;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FormasPagoGrd);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(290, 266);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            // 
            // FrmFormaPagoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 335);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFormaPagoList";
            this.Text = "Busqueda de formas de pago";
            ((System.ComponentModel.ISupportInitialize)(this.FormasPagoGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridView FormasPagoGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoActividad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}