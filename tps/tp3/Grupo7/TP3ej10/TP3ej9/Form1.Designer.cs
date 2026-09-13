namespace TP3ej9
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listInicial = new System.Windows.Forms.ListBox();
            this.listFinal = new System.Windows.Forms.ListBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colValorInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEscalaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEscalaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribí la cantidad a transformar";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(271, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 24);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escala inicial";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Escala final";
            // 
            // listInicial
            // 
            this.listInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInicial.FormattingEnabled = true;
            this.listInicial.ItemHeight = 18;
            this.listInicial.Items.AddRange(new object[] {
            "Celsius",
            "Kelvin",
            "Farenheit",
            "Rankine",
            "Kelvin"});
            this.listInicial.Location = new System.Drawing.Point(48, 149);
            this.listInicial.Name = "listInicial";
            this.listInicial.Size = new System.Drawing.Size(102, 184);
            this.listInicial.TabIndex = 4;
            // 
            // listFinal
            // 
            this.listFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFinal.FormattingEnabled = true;
            this.listFinal.ItemHeight = 18;
            this.listFinal.Items.AddRange(new object[] {
            "Celsius",
            "Kelvin",
            "Farenheit",
            "Rankine",
            "Kelvin"});
            this.listFinal.Location = new System.Drawing.Point(271, 149);
            this.listFinal.Name = "listFinal";
            this.listFinal.Size = new System.Drawing.Size(99, 184);
            this.listFinal.TabIndex = 5;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(150, 396);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(120, 31);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colValorInicial,
            this.colEscalaInicial,
            this.colEscalaFinal,
            this.colResultado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(459, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 682);
            this.dataGridView1.TabIndex = 7;
            // 
            // colValorInicial
            // 
            this.colValorInicial.Frozen = true;
            this.colValorInicial.HeaderText = "Valor Inicial";
            this.colValorInicial.MinimumWidth = 6;
            this.colValorInicial.Name = "colValorInicial";
            this.colValorInicial.ReadOnly = true;
            this.colValorInicial.Width = 125;
            // 
            // colEscalaInicial
            // 
            this.colEscalaInicial.Frozen = true;
            this.colEscalaInicial.HeaderText = "Escala Inicial";
            this.colEscalaInicial.MinimumWidth = 6;
            this.colEscalaInicial.Name = "colEscalaInicial";
            this.colEscalaInicial.ReadOnly = true;
            this.colEscalaInicial.Width = 125;
            // 
            // colEscalaFinal
            // 
            this.colEscalaFinal.Frozen = true;
            this.colEscalaFinal.HeaderText = "Escala final";
            this.colEscalaFinal.MinimumWidth = 6;
            this.colEscalaFinal.Name = "colEscalaFinal";
            this.colEscalaFinal.ReadOnly = true;
            this.colEscalaFinal.Width = 125;
            // 
            // colResultado
            // 
            this.colResultado.Frozen = true;
            this.colResultado.HeaderText = "Resultado";
            this.colResultado.MinimumWidth = 6;
            this.colResultado.Name = "colResultado";
            this.colResultado.ReadOnly = true;
            this.colResultado.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 722);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.listFinal);
            this.Controls.Add(this.listInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listInicial;
        private System.Windows.Forms.ListBox listFinal;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEscalaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEscalaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultado;
    }
}

