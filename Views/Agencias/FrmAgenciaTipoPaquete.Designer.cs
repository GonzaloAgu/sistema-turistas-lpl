namespace TurApp.Views
{
    partial class FrmAgenciaTipoPaquete
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
            this.mainGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anadirBtn = new System.Windows.Forms.Button();
            this.tipoPaqueteCbo = new System.Windows.Forms.ComboBox();
            this.gridLbl = new System.Windows.Forms.Label();
            this.tipoPaqueteGrd = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenciaCbo = new System.Windows.Forms.ComboBox();
            this.CodAge = new System.Windows.Forms.Label();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.mainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPaqueteGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGroup
            // 
            this.mainGroup.Controls.Add(this.label1);
            this.mainGroup.Controls.Add(this.anadirBtn);
            this.mainGroup.Controls.Add(this.tipoPaqueteCbo);
            this.mainGroup.Controls.Add(this.gridLbl);
            this.mainGroup.Controls.Add(this.tipoPaqueteGrd);
            this.mainGroup.Location = new System.Drawing.Point(11, 54);
            this.mainGroup.Name = "mainGroup";
            this.mainGroup.Size = new System.Drawing.Size(278, 237);
            this.mainGroup.TabIndex = 0;
            this.mainGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo Paquete:";
            // 
            // anadirBtn
            // 
            this.anadirBtn.Location = new System.Drawing.Point(196, 196);
            this.anadirBtn.Name = "anadirBtn";
            this.anadirBtn.Size = new System.Drawing.Size(75, 23);
            this.anadirBtn.TabIndex = 12;
            this.anadirBtn.Text = "Añadir";
            this.anadirBtn.UseVisualStyleBackColor = true;
            this.anadirBtn.Click += new System.EventHandler(this.anadirBtn_Click);
            // 
            // tipoPaqueteCbo
            // 
            this.tipoPaqueteCbo.DisplayMember = "Codigo";
            this.tipoPaqueteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPaqueteCbo.FormattingEnabled = true;
            this.tipoPaqueteCbo.Location = new System.Drawing.Point(89, 198);
            this.tipoPaqueteCbo.Name = "tipoPaqueteCbo";
            this.tipoPaqueteCbo.Size = new System.Drawing.Size(102, 21);
            this.tipoPaqueteCbo.TabIndex = 11;
            this.tipoPaqueteCbo.ValueMember = "Codigo";
            // 
            // gridLbl
            // 
            this.gridLbl.AutoSize = true;
            this.gridLbl.Location = new System.Drawing.Point(9, 23);
            this.gridLbl.Name = "gridLbl";
            this.gridLbl.Size = new System.Drawing.Size(33, 13);
            this.gridLbl.TabIndex = 1;
            this.gridLbl.Text = "Tipos";
            // 
            // tipoPaqueteGrd
            // 
            this.tipoPaqueteGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoPaqueteGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre});
            this.tipoPaqueteGrd.Location = new System.Drawing.Point(11, 39);
            this.tipoPaqueteGrd.Name = "tipoPaqueteGrd";
            this.tipoPaqueteGrd.RowHeadersVisible = false;
            this.tipoPaqueteGrd.Size = new System.Drawing.Size(260, 127);
            this.tipoPaqueteGrd.TabIndex = 0;
            this.tipoPaqueteGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tipoPaqueteGrd_DataBindingComplete);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 205;
            // 
            // agenciaCbo
            // 
            this.agenciaCbo.DisplayMember = "Codigo";
            this.agenciaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agenciaCbo.FormattingEnabled = true;
            this.agenciaCbo.Location = new System.Drawing.Point(89, 24);
            this.agenciaCbo.Name = "agenciaCbo";
            this.agenciaCbo.Size = new System.Drawing.Size(184, 21);
            this.agenciaCbo.TabIndex = 9;
            this.agenciaCbo.ValueMember = "Codigo";
            this.agenciaCbo.SelectedValueChanged += new System.EventHandler(this.agenciaCbo_SelectedValueChanged);
            // 
            // CodAge
            // 
            this.CodAge.AutoSize = true;
            this.CodAge.Location = new System.Drawing.Point(19, 27);
            this.CodAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodAge.Name = "CodAge";
            this.CodAge.Size = new System.Drawing.Size(46, 13);
            this.CodAge.TabIndex = 10;
            this.CodAge.Text = "&Agencia";
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(215, 297);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(75, 23);
            this.CerrarBtn.TabIndex = 2;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // FrmAgenciaTipoPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 331);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.agenciaCbo);
            this.Controls.Add(this.CodAge);
            this.Controls.Add(this.mainGroup);
            this.Name = "FrmAgenciaTipoPaquete";
            this.Text = "Vincular tipo de paquete...";
            this.Load += new System.EventHandler(this.FrmAgenciaTipoPaquete_Load);
            this.mainGroup.ResumeLayout(false);
            this.mainGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPaqueteGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroup;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridView tipoPaqueteGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label gridLbl;
        private System.Windows.Forms.ComboBox agenciaCbo;
        private System.Windows.Forms.Label CodAge;
        private System.Windows.Forms.Button anadirBtn;
        private System.Windows.Forms.ComboBox tipoPaqueteCbo;
        private System.Windows.Forms.Label label1;
    }
}