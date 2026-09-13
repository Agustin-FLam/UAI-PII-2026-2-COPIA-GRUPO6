namespace ejercicio_6_tp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.lstFibonacci = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese el numero:  ";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(183, 25);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 26);
            this.txtN.TabIndex = 1;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(136, 89);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(100, 90);
            this.calcular.TabIndex = 2;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // lstFibonacci
            // 
            this.lstFibonacci.FormattingEnabled = true;
            this.lstFibonacci.ItemHeight = 20;
            this.lstFibonacci.Location = new System.Drawing.Point(126, 223);
            this.lstFibonacci.Name = "lstFibonacci";
            this.lstFibonacci.Size = new System.Drawing.Size(120, 84);
            this.lstFibonacci.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFibonacci);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.ListBox lstFibonacci;
    }
}

