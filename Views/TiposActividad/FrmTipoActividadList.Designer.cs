namespace TurApp.Views
{
    partial class FrmTipoActividadList
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
            this.TipoActividadesGrd = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TipoActividadesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoActividadesGrd
            // 
            this.TipoActividadesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TipoActividadesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.codigo,
            this.descripcion,
            this.duracion,
            this.nivel});
            this.TipoActividadesGrd.Location = new System.Drawing.Point(4, 12);
            this.TipoActividadesGrd.Name = "TipoActividadesGrd";
            this.TipoActividadesGrd.Size = new System.Drawing.Size(773, 246);
            this.TipoActividadesGrd.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // duracion
            // 
            this.duracion.HeaderText = "Duración";
            this.duracion.Name = "duracion";
            // 
            // nivel
            // 
            this.nivel.HeaderText = "Nivel";
            this.nivel.Name = "nivel";
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(203, 297);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(202, 47);
            this.CerrarBtn.TabIndex = 1;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            // 
            // FrmTipoActividadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 369);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.TipoActividadesGrd);
            this.Name = "FrmTipoActividadList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmTipoActividadList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipoActividadesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TipoActividadesGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.Button CerrarBtn;


    }
}