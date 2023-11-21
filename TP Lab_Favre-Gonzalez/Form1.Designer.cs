namespace TP_Lab_Favre_Gonzalez
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumRepuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMarcaFiltro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtNumRepuesto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Repuestos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(407, 104);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 40);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(407, 30);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 40);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(151, 104);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(60, 21);
            this.cmbOrigen.TabIndex = 11;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(151, 71);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(60, 21);
            this.cmbMarca.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(151, 192);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(151, 149);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 8;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtNumRepuesto
            // 
            this.txtNumRepuesto.Location = new System.Drawing.Point(151, 33);
            this.txtNumRepuesto.Name = "txtNumRepuesto";
            this.txtNumRepuesto.Size = new System.Drawing.Size(100, 20);
            this.txtNumRepuesto.TabIndex = 7;
            this.txtNumRepuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumRepuesto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero Repuesto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTodos);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.optImportado);
            this.groupBox2.Controls.Add(this.optNacional);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbMarcaFiltro);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(56, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta de Repuestos";
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(151, 132);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(78, 25);
            this.btnTodos.TabIndex = 16;
            this.btnTodos.Text = "&Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(9, 132);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 25);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(130, 86);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 14;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(57, 86);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 13;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Origen";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbMarcaFiltro
            // 
            this.cmbMarcaFiltro.FormattingEnabled = true;
            this.cmbMarcaFiltro.Location = new System.Drawing.Point(57, 33);
            this.cmbMarcaFiltro.Name = "cmbMarcaFiltro";
            this.cmbMarcaFiltro.Size = new System.Drawing.Size(60, 21);
            this.cmbMarcaFiltro.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Marca";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(257, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(449, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Marca";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Origen";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Descripcion";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumRepuesto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmbMarcaFiltro;
        private System.Windows.Forms.Button btnTodos;
    }
}

