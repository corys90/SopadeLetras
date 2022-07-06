namespace SopaDeLetras
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.nUDNoColumnas = new System.Windows.Forms.NumericUpDown();
            this.nUDNoFilas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSopaLetras = new System.Windows.Forms.DataGridView();
            this.btnRestablece = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNoColumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNoFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSopaLetras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.nUDNoColumnas);
            this.groupBox1.Controls.Add(this.nUDNoFilas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamaño de la sopa de letras";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(274, 20);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(156, 45);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Crear cuadro de letras";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // nUDNoColumnas
            // 
            this.nUDNoColumnas.Location = new System.Drawing.Point(156, 45);
            this.nUDNoColumnas.Name = "nUDNoColumnas";
            this.nUDNoColumnas.Size = new System.Drawing.Size(66, 20);
            this.nUDNoColumnas.TabIndex = 5;
            // 
            // nUDNoFilas
            // 
            this.nUDNoFilas.Location = new System.Drawing.Point(32, 45);
            this.nUDNoFilas.Name = "nUDNoFilas";
            this.nUDNoFilas.Size = new System.Drawing.Size(66, 20);
            this.nUDNoFilas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nro de columnas :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro de Filas :";
            // 
            // dgvSopaLetras
            // 
            this.dgvSopaLetras.AllowUserToAddRows = false;
            this.dgvSopaLetras.AllowUserToDeleteRows = false;
            this.dgvSopaLetras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSopaLetras.Location = new System.Drawing.Point(12, 140);
            this.dgvSopaLetras.Name = "dgvSopaLetras";
            this.dgvSopaLetras.Size = new System.Drawing.Size(436, 302);
            this.dgvSopaLetras.TabIndex = 1;
            this.dgvSopaLetras.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSopaLetras_CellValueChanged);
            // 
            // btnRestablece
            // 
            this.btnRestablece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablece.Location = new System.Drawing.Point(12, 449);
            this.btnRestablece.Name = "btnRestablece";
            this.btnRestablece.Size = new System.Drawing.Size(271, 30);
            this.btnRestablece.TabIndex = 7;
            this.btnRestablece.Text = "Restablece sopa de letras";
            this.btnRestablece.UseVisualStyleBackColor = true;
            this.btnRestablece.Click += new System.EventHandler(this.btnRestablece_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Palabra :";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(286, 99);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(156, 30);
            this.btnBusqueda.TabIndex = 9;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(96, 105);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(174, 20);
            this.txtPalabra.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 481);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRestablece);
            this.Controls.Add(this.dgvSopaLetras);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sopa de Letras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNoColumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNoFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSopaLetras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.NumericUpDown nUDNoColumnas;
        private System.Windows.Forms.NumericUpDown nUDNoFilas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSopaLetras;
        private System.Windows.Forms.Button btnRestablece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtPalabra;
    }
}

