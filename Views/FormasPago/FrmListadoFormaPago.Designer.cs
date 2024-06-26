namespace TurApp.Views {
    partial class FrmListadoFormaPago {
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
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.FormaPagoGrd = new System.Windows.Forms.DataGridView();
            this.Forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FormaPagoGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(228, 14);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 15;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // FormaPagoGrd
            // 
            this.FormaPagoGrd.AllowUserToAddRows = false;
            this.FormaPagoGrd.AllowUserToDeleteRows = false;
            this.FormaPagoGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormaPagoGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Forma});
            this.FormaPagoGrd.Location = new System.Drawing.Point(11, 65);
            this.FormaPagoGrd.Margin = new System.Windows.Forms.Padding(2);
            this.FormaPagoGrd.MultiSelect = false;
            this.FormaPagoGrd.Name = "FormaPagoGrd";
            this.FormaPagoGrd.ReadOnly = true;
            this.FormaPagoGrd.RowTemplate.Height = 24;
            this.FormaPagoGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FormaPagoGrd.ShowEditingIcon = false;
            this.FormaPagoGrd.Size = new System.Drawing.Size(293, 194);
            this.FormaPagoGrd.TabIndex = 13;
            this.FormaPagoGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FormaPagoGrd_ColumnHeaderMouseClick);
            // 
            // Forma
            // 
            this.Forma.DataPropertyName = "Forma";
            this.Forma.HeaderText = "Forma de Pago";
            this.Forma.Name = "Forma";
            this.Forma.ReadOnly = true;
            this.Forma.Width = 250;
            // 
            // FormaTxt
            // 
            this.FormaTxt.Location = new System.Drawing.Point(69, 15);
            this.FormaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.FormaTxt.Name = "FormaTxt";
            this.FormaTxt.Size = new System.Drawing.Size(129, 20);
            this.FormaTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FormaTxt);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(208, 42);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forma";
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Enabled = false;
            this.ExportarBtn.Location = new System.Drawing.Point(220, 269);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 17;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // FrmListadoFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 307);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.FormaPagoGrd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExportarBtn);
            this.Name = "FrmListadoFormaPago";
            this.Text = "Listado de formas de pago";
            this.Load += new System.EventHandler(this.FrmListadoFormaPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormaPagoGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.DataGridView FormaPagoGrd;
        private System.Windows.Forms.TextBox FormaTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma;
        private System.Windows.Forms.Label label1;
    }
}