namespace TP3ej10
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblDado1 = new System.Windows.Forms.Label();
            this.lblDado2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "TIRAR DADOS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblDado1
            // 
            this.lblDado1.AutoSize = true;
            this.lblDado1.Location = new System.Drawing.Point(79, 197);
            this.lblDado1.Name = "lblDado1";
            this.lblDado1.Size = new System.Drawing.Size(46, 16);
            this.lblDado1.TabIndex = 1;
            this.lblDado1.Text = "DADO";
            // 
            // lblDado2
            // 
            this.lblDado2.AutoSize = true;
            this.lblDado2.Location = new System.Drawing.Point(262, 201);
            this.lblDado2.Name = "lblDado2";
            this.lblDado2.Size = new System.Drawing.Size(46, 16);
            this.lblDado2.TabIndex = 2;
            this.lblDado2.Text = "DADO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colCantidad,
            this.colPorcentaje});
            this.dataGridView1.Location = new System.Drawing.Point(3, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 565);
            this.dataGridView1.TabIndex = 3;
            // 
            // colNumero
            // 
            this.colNumero.Frozen = true;
            this.colNumero.HeaderText = "Numero";
            this.colNumero.MinimumWidth = 6;
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 125;
            // 
            // colCantidad
            // 
            this.colCantidad.Frozen = true;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 125;
            // 
            // colPorcentaje
            // 
            this.colPorcentaje.Frozen = true;
            this.colPorcentaje.HeaderText = "Porcentaje";
            this.colPorcentaje.MinimumWidth = 6;
            this.colPorcentaje.Name = "colPorcentaje";
            this.colPorcentaje.ReadOnly = true;
            this.colPorcentaje.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 850);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDado2);
            this.Controls.Add(this.lblDado1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDado1;
        private System.Windows.Forms.Label lblDado2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPorcentaje;
    }
}

