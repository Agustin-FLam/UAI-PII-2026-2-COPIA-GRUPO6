namespace tp03_ej03
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtAcargar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCargados = new System.Windows.Forms.TextBox();
            this.btnCarga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(38, 81);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(129, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Ingrese los números aquí:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(172, 326);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(90, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "El Resultado es : ";
            // 
            // txtAcargar
            // 
            this.txtAcargar.AcceptsTab = true;
            this.txtAcargar.Location = new System.Drawing.Point(187, 78);
            this.txtAcargar.Name = "txtAcargar";
            this.txtAcargar.Size = new System.Drawing.Size(69, 20);
            this.txtAcargar.TabIndex = 2;
            this.txtAcargar.TextChanged += new System.EventHandler(this.txtAcargar_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCargados
            // 
            this.txtCargados.Location = new System.Drawing.Point(175, 139);
            this.txtCargados.Multiline = true;
            this.txtCargados.Name = "txtCargados";
            this.txtCargados.Size = new System.Drawing.Size(94, 160);
            this.txtCargados.TabIndex = 4;
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(286, 102);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(79, 26);
            this.btnCarga.TabIndex = 5;
            this.btnCarga.Text = "Cargar";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.txtCargados);
            this.Controls.Add(this.txtAcargar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtAcargar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtCargados;
        private System.Windows.Forms.Button btnCarga;
    }
}

