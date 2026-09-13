namespace ejercicio_7_tp3
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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIntereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTasa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "monto: ";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(81, 9);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 26);
            this.txtMonto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "tasa nominal anual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "dias: ";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(58, 114);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 26);
            this.txtDias.TabIndex = 4;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(209, 152);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(100, 90);
            this.calcular.TabIndex = 5;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonto,
            this.colTasa,
            this.colDias,
            this.colIntereses});
            this.dgvResultado.Location = new System.Drawing.Point(34, 248);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowHeadersWidth = 62;
            this.dgvResultado.RowTemplate.Height = 28;
            this.dgvResultado.Size = new System.Drawing.Size(704, 150);
            this.dgvResultado.TabIndex = 6;
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "monto";
            this.colMonto.MinimumWidth = 8;
            this.colMonto.Name = "colMonto";
            this.colMonto.Width = 150;
            // 
            // colTasa
            // 
            this.colTasa.HeaderText = "tasa";
            this.colTasa.MinimumWidth = 8;
            this.colTasa.Name = "colTasa";
            this.colTasa.Width = 150;
            // 
            // colDias
            // 
            this.colDias.HeaderText = "dias";
            this.colDias.MinimumWidth = 8;
            this.colDias.Name = "colDias";
            this.colDias.Width = 150;
            // 
            // colIntereses
            // 
            this.colIntereses.HeaderText = "intereses";
            this.colIntereses.MinimumWidth = 8;
            this.colIntereses.Name = "colIntereses";
            this.colIntereses.Width = 150;
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(164, 70);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(100, 26);
            this.txtTasa.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntereses;
        private System.Windows.Forms.TextBox txtTasa;
    }
}

