namespace Ej1Guia3._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upModelo = new System.Windows.Forms.NumericUpDown();
            this.tbValorFabricacion = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTasaDepre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.upAñoACalcular = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rdAnual = new System.Windows.Forms.RadioButton();
            this.rdLineal = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upModelo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upAñoACalcular)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upModelo);
            this.groupBox1.Controls.Add(this.tbValorFabricacion);
            this.groupBox1.Controls.Add(this.tbMarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vehiculo";
            // 
            // upModelo
            // 
            this.upModelo.Location = new System.Drawing.Point(148, 41);
            this.upModelo.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.upModelo.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.upModelo.Name = "upModelo";
            this.upModelo.Size = new System.Drawing.Size(100, 20);
            this.upModelo.TabIndex = 1;
            this.upModelo.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // tbValorFabricacion
            // 
            this.tbValorFabricacion.Location = new System.Drawing.Point(148, 67);
            this.tbValorFabricacion.Name = "tbValorFabricacion";
            this.tbValorFabricacion.Size = new System.Drawing.Size(100, 20);
            this.tbValorFabricacion.TabIndex = 5;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(148, 15);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de fabricación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (Año):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCalcular);
            this.groupBox2.Controls.Add(this.tbVidaUtil);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbTasaDepre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.upAñoACalcular);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rdAnual);
            this.groupBox2.Controls.Add(this.rdLineal);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculo de depresiación";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(92, 129);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 30);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(148, 103);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tbVidaUtil.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vida util (años):";
            // 
            // tbTasaDepre
            // 
            this.tbTasaDepre.Location = new System.Drawing.Point(148, 77);
            this.tbTasaDepre.Name = "tbTasaDepre";
            this.tbTasaDepre.Size = new System.Drawing.Size(100, 20);
            this.tbTasaDepre.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tasa de depresiación:";
            // 
            // upAñoACalcular
            // 
            this.upAñoACalcular.Location = new System.Drawing.Point(148, 51);
            this.upAñoACalcular.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.upAñoACalcular.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.upAñoACalcular.Name = "upAñoACalcular";
            this.upAñoACalcular.Size = new System.Drawing.Size(100, 20);
            this.upAñoACalcular.TabIndex = 3;
            this.upAñoACalcular.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Año a calcular:";
            // 
            // rdAnual
            // 
            this.rdAnual.AutoSize = true;
            this.rdAnual.Location = new System.Drawing.Point(150, 19);
            this.rdAnual.Name = "rdAnual";
            this.rdAnual.Size = new System.Drawing.Size(52, 17);
            this.rdAnual.TabIndex = 1;
            this.rdAnual.TabStop = true;
            this.rdAnual.Text = "Anual";
            this.rdAnual.UseVisualStyleBackColor = true;
            // 
            // rdLineal
            // 
            this.rdLineal.AutoSize = true;
            this.rdLineal.Location = new System.Drawing.Point(6, 19);
            this.rdLineal.Name = "rdLineal";
            this.rdLineal.Size = new System.Drawing.Size(53, 17);
            this.rdLineal.TabIndex = 0;
            this.rdLineal.TabStop = true;
            this.rdLineal.Text = "Lineal";
            this.rdLineal.UseVisualStyleBackColor = true;
            this.rdLineal.CheckedChanged += new System.EventHandler(this.rdLineal_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upModelo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upAñoACalcular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown upModelo;
        private System.Windows.Forms.TextBox tbValorFabricacion;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown upAñoACalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdAnual;
        private System.Windows.Forms.RadioButton rdLineal;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTasaDepre;
    }
}

