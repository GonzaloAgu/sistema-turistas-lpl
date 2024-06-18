namespace TurApp.Views
{
    partial class FrmTipoActividadAM
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
            this.codigolbl = new System.Windows.Forms.Label();
            this.nombrelbl = new System.Windows.Forms.Label();
            this.descripcionlbl = new System.Windows.Forms.Label();
            this.duracionlbl = new System.Windows.Forms.Label();
            this.nivellbl = new System.Windows.Forms.Label();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.descripciontxt = new System.Windows.Forms.TextBox();
            this.duraciontxt = new System.Windows.Forms.TextBox();
            this.niveltxt = new System.Windows.Forms.TextBox();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.guardarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codigolbl
            // 
            this.codigolbl.AutoSize = true;
            this.codigolbl.Location = new System.Drawing.Point(74, 61);
            this.codigolbl.Name = "codigolbl";
            this.codigolbl.Size = new System.Drawing.Size(52, 17);
            this.codigolbl.TabIndex = 0;
            this.codigolbl.Text = "Código";
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.Location = new System.Drawing.Point(74, 127);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(58, 17);
            this.nombrelbl.TabIndex = 1;
            this.nombrelbl.Text = "Nombre";
            // 
            // descripcionlbl
            // 
            this.descripcionlbl.AutoSize = true;
            this.descripcionlbl.Location = new System.Drawing.Point(74, 190);
            this.descripcionlbl.Name = "descripcionlbl";
            this.descripcionlbl.Size = new System.Drawing.Size(82, 17);
            this.descripcionlbl.TabIndex = 2;
            this.descripcionlbl.Text = "Descripción";
            // 
            // duracionlbl
            // 
            this.duracionlbl.AutoSize = true;
            this.duracionlbl.Location = new System.Drawing.Point(74, 250);
            this.duracionlbl.Name = "duracionlbl";
            this.duracionlbl.Size = new System.Drawing.Size(65, 17);
            this.duracionlbl.TabIndex = 3;
            this.duracionlbl.Text = "Duración";
            // 
            // nivellbl
            // 
            this.nivellbl.AutoSize = true;
            this.nivellbl.Location = new System.Drawing.Point(74, 329);
            this.nivellbl.Name = "nivellbl";
            this.nivellbl.Size = new System.Drawing.Size(39, 17);
            this.nivellbl.TabIndex = 4;
            this.nivellbl.Text = "Nivel";
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(266, 56);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(100, 22);
            this.codigotxt.TabIndex = 5;
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(266, 122);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(100, 22);
            this.nombretxt.TabIndex = 6;
            // 
            // descripciontxt
            // 
            this.descripciontxt.Location = new System.Drawing.Point(266, 185);
            this.descripciontxt.Name = "descripciontxt";
            this.descripciontxt.Size = new System.Drawing.Size(100, 22);
            this.descripciontxt.TabIndex = 7;
            // 
            // duraciontxt
            // 
            this.duraciontxt.Location = new System.Drawing.Point(266, 250);
            this.duraciontxt.Name = "duraciontxt";
            this.duraciontxt.Size = new System.Drawing.Size(100, 22);
            this.duraciontxt.TabIndex = 8;
            this.duraciontxt.TextChanged += new System.EventHandler(this.duraciontxt_TextChanged);
            // 
            // niveltxt
            // 
            this.niveltxt.Location = new System.Drawing.Point(266, 324);
            this.niveltxt.Name = "niveltxt";
            this.niveltxt.Size = new System.Drawing.Size(100, 22);
            this.niveltxt.TabIndex = 9;
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.Location = new System.Drawing.Point(55, 406);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(101, 23);
            this.cancelarbtn.TabIndex = 10;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // guardarbtn
            // 
            this.guardarbtn.Location = new System.Drawing.Point(266, 406);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(100, 23);
            this.guardarbtn.TabIndex = 11;
            this.guardarbtn.Text = "Guardar";
            this.guardarbtn.UseVisualStyleBackColor = true;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // FrmTipoActividadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 540);
            this.Controls.Add(this.guardarbtn);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.niveltxt);
            this.Controls.Add(this.duraciontxt);
            this.Controls.Add(this.descripciontxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.nivellbl);
            this.Controls.Add(this.duracionlbl);
            this.Controls.Add(this.descripcionlbl);
            this.Controls.Add(this.nombrelbl);
            this.Controls.Add(this.codigolbl);
            this.Name = "FrmTipoActividadAM";
            this.Text = "TipoActividad";
            this.Load += new System.EventHandler(this.FrmTipoActividadAM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigolbl;
        private System.Windows.Forms.Label nombrelbl;
        private System.Windows.Forms.Label descripcionlbl;
        private System.Windows.Forms.Label duracionlbl;
        private System.Windows.Forms.Label nivellbl;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox descripciontxt;
        private System.Windows.Forms.TextBox duraciontxt;
        private System.Windows.Forms.TextBox niveltxt;
        private System.Windows.Forms.Button cancelarbtn;
        private System.Windows.Forms.Button guardarbtn;
    }
}