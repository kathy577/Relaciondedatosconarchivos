namespace Practica5Mayo
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblT = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.IdClienteColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClienteMayor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(159, 276);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(93, 31);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(23, 370);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(82, 13);
            this.lblT.TabIndex = 3;
            this.lblT.Text = "Total de Ventas";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Location = new System.Drawing.Point(137, 370);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(0, 13);
            this.lblTotalVentas.TabIndex = 4;
            this.lblTotalVentas.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClienteColumna,
            this.ImporteColumna});
            this.dgvResultados.Location = new System.Drawing.Point(12, 12);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(283, 258);
            this.dgvResultados.TabIndex = 5;
            this.dgvResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellContentClick);
            // 
            // IdClienteColumna
            // 
            this.IdClienteColumna.HeaderText = "Cliente";
            this.IdClienteColumna.Name = "IdClienteColumna";
            // 
            // ImporteColumna
            // 
            this.ImporteColumna.HeaderText = "Importe";
            this.ImporteColumna.Name = "ImporteColumna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cliente con Mayor compra";
            // 
            // lblClienteMayor
            // 
            this.lblClienteMayor.AutoSize = true;
            this.lblClienteMayor.Location = new System.Drawing.Point(189, 410);
            this.lblClienteMayor.Name = "lblClienteMayor";
            this.lblClienteMayor.Size = new System.Drawing.Size(0, 13);
            this.lblClienteMayor.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.lblClienteMayor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClienteMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClienteColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteColumna;
    }
}

