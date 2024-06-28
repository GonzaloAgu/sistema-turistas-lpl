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
            this.nombrelbl = new System.Windows.Forms.Label();
            this.descripcionlbl = new System.Windows.Forms.Label();
            this.duracionlbl = new System.Windows.Forms.Label();
            this.nivellbl = new System.Windows.Forms.Label();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.descripciontxt = new System.Windows.Forms.TextBox();
            this.duraciontxt = new System.Windows.Forms.TextBox();
            this.niveltxt = new System.Windows.Forms.TextBox();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.guardarbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.Location = new System.Drawing.Point(30, 32);
            this.nombrelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(44, 13);
            this.nombrelbl.TabIndex = 1;
            this.nombrelbl.Text = "Nombre";
            // 
            // descripcionlbl
            // 
            this.descripcionlbl.AutoSize = true;
            this.descripcionlbl.Location = new System.Drawing.Point(12, 70);
            this.descripcionlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descripcionlbl.Name = "descripcionlbl";
            this.descripcionlbl.Size = new System.Drawing.Size(63, 13);
            this.descripcionlbl.TabIndex = 2;
            this.descripcionlbl.Text = "Descripción";
            // 
            // duracionlbl
            // 
            this.duracionlbl.AutoSize = true;
            this.duracionlbl.Location = new System.Drawing.Point(24, 108);
            this.duracionlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.duracionlbl.Name = "duracionlbl";
            this.duracionlbl.Size = new System.Drawing.Size(50, 13);
            this.duracionlbl.TabIndex = 3;
            this.duracionlbl.Text = "Duración";
            // 
            // nivellbl
            // 
            this.nivellbl.AutoSize = true;
            this.nivellbl.Location = new System.Drawing.Point(43, 146);
            this.nivellbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nivellbl.Name = "nivellbl";
            this.nivellbl.Size = new System.Drawing.Size(31, 13);
            this.nivellbl.TabIndex = 4;
            this.nivellbl.Text = "Nivel";
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(94, 29);
            this.nombretxt.Margin = new System.Windows.Forms.Padding(2);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(167, 20);
            this.nombretxt.TabIndex = 6;
            // 
            // descripciontxt
            // 
            this.descripciontxt.Location = new System.Drawing.Point(94, 67);
            this.descripciontxt.Margin = new System.Windows.Forms.Padding(2);
            this.descripciontxt.Name = "descripciontxt";
            this.descripciontxt.Size = new System.Drawing.Size(167, 20);
            this.descripciontxt.TabIndex = 7;
            // 
            // duraciontxt
            // 
            this.duraciontxt.Location = new System.Drawing.Point(94, 105);
            this.duraciontxt.Margin = new System.Windows.Forms.Padding(2);
            this.duraciontxt.MaxLength = 8;
            this.duraciontxt.Name = "duraciontxt";
            this.duraciontxt.Size = new System.Drawing.Size(76, 20);
            this.duraciontxt.TabIndex = 8;
            this.duraciontxt.TextChanged += new System.EventHandler(this.duraciontxt_TextChanged);
            // 
            // niveltxt
            // 
            this.niveltxt.Location = new System.Drawing.Point(94, 143);
            this.niveltxt.Margin = new System.Windows.Forms.Padding(2);
            this.niveltxt.Name = "niveltxt";
            this.niveltxt.Size = new System.Drawing.Size(76, 20);
            this.niveltxt.TabIndex = 9;
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.Location = new System.Drawing.Point(27, 224);
            this.cancelarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarbtn.TabIndex = 10;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // guardarbtn
            // 
            this.guardarbtn.Location = new System.Drawing.Point(212, 224);
            this.guardarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(75, 23);
            this.guardarbtn.TabIndex = 11;
            this.guardarbtn.Text = "Guardar";
            this.guardarbtn.UseVisualStyleBackColor = true;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.niveltxt);
            this.groupBox1.Controls.Add(this.duraciontxt);
            this.groupBox1.Controls.Add(this.descripciontxt);
            this.groupBox1.Controls.Add(this.nombretxt);
            this.groupBox1.Controls.Add(this.nivellbl);
            this.groupBox1.Controls.Add(this.duracionlbl);
            this.groupBox1.Controls.Add(this.descripcionlbl);
            this.groupBox1.Controls.Add(this.nombrelbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 193);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Formato: hh:mm:ss";
            // 
            // FrmTipoActividadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 264);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.guardarbtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTipoActividadAM";
            this.Text = "Ingreso de Tipo de Actividad";
            this.Load += new System.EventHandler(this.FrmTipoActividadAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nombrelbl;
        private System.Windows.Forms.Label descripcionlbl;
        private System.Windows.Forms.Label duracionlbl;
        private System.Windows.Forms.Label nivellbl;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox descripciontxt;
        private System.Windows.Forms.TextBox duraciontxt;
        private System.Windows.Forms.TextBox niveltxt;
        private System.Windows.Forms.Button cancelarbtn;
        private System.Windows.Forms.Button guardarbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}