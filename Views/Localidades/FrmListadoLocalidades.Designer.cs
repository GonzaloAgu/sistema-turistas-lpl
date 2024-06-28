namespace TurApp.Views
{
    partial class FrmListadoLocalidades
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
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreLocalidadTxt = new System.Windows.Forms.TextBox();
            this.NombreLocalidadChek = new System.Windows.Forms.CheckBox();
            this.LocalidadesGrd = new System.Windows.Forms.DataGridView();
            this.CodPostalCheckBox = new System.Windows.Forms.CheckBox();
            this.CodigoPostalTxt = new System.Windows.Forms.TextBox();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Enabled = false;
            this.ExportarBtn.Location = new System.Drawing.Point(477, 467);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 6;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click_1);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(485, 15);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 5;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreLocalidadTxt);
            this.groupBox1.Controls.Add(this.NombreLocalidadChek);
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(227, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // NombreLocalidadTxt
            // 
            this.NombreLocalidadTxt.Enabled = false;
            this.NombreLocalidadTxt.Location = new System.Drawing.Point(69, 15);
            this.NombreLocalidadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreLocalidadTxt.Name = "NombreLocalidadTxt";
            this.NombreLocalidadTxt.Size = new System.Drawing.Size(146, 20);
            this.NombreLocalidadTxt.TabIndex = 2;
            // 
            // NombreLocalidadChek
            // 
            this.NombreLocalidadChek.AutoSize = true;
            this.NombreLocalidadChek.Location = new System.Drawing.Point(4, 17);
            this.NombreLocalidadChek.Margin = new System.Windows.Forms.Padding(2);
            this.NombreLocalidadChek.Name = "NombreLocalidadChek";
            this.NombreLocalidadChek.Size = new System.Drawing.Size(63, 17);
            this.NombreLocalidadChek.TabIndex = 1;
            this.NombreLocalidadChek.Text = "Nombre";
            this.NombreLocalidadChek.UseVisualStyleBackColor = true;
            this.NombreLocalidadChek.CheckedChanged += new System.EventHandler(this.NombreLocalidadChek_CheckedChanged);
            // 
            // LocalidadesGrd
            // 
            this.LocalidadesGrd.AllowUserToAddRows = false;
            this.LocalidadesGrd.AllowUserToDeleteRows = false;
            this.LocalidadesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalidadesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniCol,
            this.NombreCol});
            this.LocalidadesGrd.Location = new System.Drawing.Point(11, 67);
            this.LocalidadesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadesGrd.MultiSelect = false;
            this.LocalidadesGrd.Name = "LocalidadesGrd";
            this.LocalidadesGrd.ReadOnly = true;
            this.LocalidadesGrd.RowTemplate.Height = 24;
            this.LocalidadesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocalidadesGrd.ShowEditingIcon = false;
            this.LocalidadesGrd.Size = new System.Drawing.Size(550, 384);
            this.LocalidadesGrd.TabIndex = 13;
            this.LocalidadesGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LocalidadesGrd_CellContentClick);
            this.LocalidadesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.LocalidadesGrd_DataBindingComplete);
            this.LocalidadesGrd.DoubleClick += new System.EventHandler(this.LocalidadesGrd_DoubleClick);
            // 
            // CodPostalCheckBox
            // 
            this.CodPostalCheckBox.AutoSize = true;
            this.CodPostalCheckBox.Location = new System.Drawing.Point(249, 24);
            this.CodPostalCheckBox.Name = "CodPostalCheckBox";
            this.CodPostalCheckBox.Size = new System.Drawing.Size(91, 17);
            this.CodPostalCheckBox.TabIndex = 3;
            this.CodPostalCheckBox.Text = "Codigo Postal";
            this.CodPostalCheckBox.UseVisualStyleBackColor = true;
            this.CodPostalCheckBox.CheckedChanged += new System.EventHandler(this.CodPostalCheckBox_CheckedChanged);
            // 
            // CodigoPostalTxt
            // 
            this.CodigoPostalTxt.Enabled = false;
            this.CodigoPostalTxt.Location = new System.Drawing.Point(346, 22);
            this.CodigoPostalTxt.Name = "CodigoPostalTxt";
            this.CodigoPostalTxt.Size = new System.Drawing.Size(100, 20);
            this.CodigoPostalTxt.TabIndex = 4;
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "Codigo";
            this.DniCol.HeaderText = "Codigo Postal";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Nombre";
            this.NombreCol.HeaderText = "Nombre";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 400;
            // 
            // FrmListadoLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 505);
            this.Controls.Add(this.CodigoPostalTxt);
            this.Controls.Add(this.CodPostalCheckBox);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LocalidadesGrd);
            this.Controls.Add(this.ExportarBtn);
            this.Name = "FrmListadoLocalidades";
            this.Text = "Listado de localidades...";
            this.Load += new System.EventHandler(this.FrmListadoLocalidades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadesGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombreLocalidadTxt;
        private System.Windows.Forms.CheckBox NombreLocalidadChek;
        private System.Windows.Forms.DataGridView LocalidadesGrd;
        private System.Windows.Forms.CheckBox CodPostalCheckBox;
        private System.Windows.Forms.TextBox CodigoPostalTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;

    }
}