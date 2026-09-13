namespace Acumulacion
{
    partial class ListaNumeros
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
            this.txtListaNumeros = new System.Windows.Forms.TextBox();
            this.tbnAgregar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtListaNumeros
            // 
            this.txtListaNumeros.BackColor = System.Drawing.Color.White;
            this.txtListaNumeros.Location = new System.Drawing.Point(147, 33);
            this.txtListaNumeros.Multiline = true;
            this.txtListaNumeros.Name = "txtListaNumeros";
            this.txtListaNumeros.ReadOnly = true;
            this.txtListaNumeros.Size = new System.Drawing.Size(99, 111);
            this.txtListaNumeros.TabIndex = 0;
            // 
            // tbnAgregar
            // 
            this.tbnAgregar.Location = new System.Drawing.Point(165, 163);
            this.tbnAgregar.Name = "tbnAgregar";
            this.tbnAgregar.Size = new System.Drawing.Size(60, 32);
            this.tbnAgregar.TabIndex = 1;
            this.tbnAgregar.Text = "Agregar";
            this.tbnAgregar.UseVisualStyleBackColor = true;
            this.tbnAgregar.Click += new System.EventHandler(this.Suma_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(69, 33);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(61, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(263, 36);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(42, 13);
            this.lblMostrar.TabIndex = 4;
            this.lblMostrar.Text = "Mostrar";
            this.lblMostrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListaNumeros
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(383, 298);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.tbnAgregar);
            this.Controls.Add(this.txtListaNumeros);
            this.Name = "ListaNumeros";
            this.Text = "ListaNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtListaNumeros;
        private System.Windows.Forms.Button tbnAgregar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblMostrar;
    }
}

