namespace Ej1Guia3._1
{
    partial class fResultados
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbResultados = new System.Windows.Forms.TextBox();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultados";
            // 
            // tbResultados
            // 
            this.tbResultados.Location = new System.Drawing.Point(12, 32);
            this.tbResultados.Multiline = true;
            this.tbResultados.Name = "tbResultados";
            this.tbResultados.ReadOnly = true;
            this.tbResultados.Size = new System.Drawing.Size(526, 114);
            this.tbResultados.TabIndex = 1;
            // 
            // btCerrar
            // 
            this.btCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCerrar.Location = new System.Drawing.Point(234, 152);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 39);
            this.btCerrar.TabIndex = 2;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            // 
            // fResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 203);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.tbResultados);
            this.Controls.Add(this.label1);
            this.Name = "fResultados";
            this.Text = "Ver Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbResultados;
        private System.Windows.Forms.Button btCerrar;
    }
}