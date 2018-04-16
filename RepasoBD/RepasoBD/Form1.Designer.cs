namespace RepasoBD
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtAgrNombre = new System.Windows.Forms.TextBox();
            this.txtAgrDescr = new System.Windows.Forms.TextBox();
            this.lbAgregarNombres = new System.Windows.Forms.Label();
            this.lbAgregarDescr = new System.Windows.Forms.Label();
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtElimDatos = new System.Windows.Forms.TextBox();
            this.lbEliminarDatos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(169, 101);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtAgrNombre
            // 
            this.txtAgrNombre.Location = new System.Drawing.Point(215, 41);
            this.txtAgrNombre.Name = "txtAgrNombre";
            this.txtAgrNombre.Size = new System.Drawing.Size(100, 20);
            this.txtAgrNombre.TabIndex = 1;
            // 
            // txtAgrDescr
            // 
            this.txtAgrDescr.Location = new System.Drawing.Point(362, 41);
            this.txtAgrDescr.Name = "txtAgrDescr";
            this.txtAgrDescr.Size = new System.Drawing.Size(100, 20);
            this.txtAgrDescr.TabIndex = 2;
            // 
            // lbAgregarNombres
            // 
            this.lbAgregarNombres.AutoSize = true;
            this.lbAgregarNombres.Location = new System.Drawing.Point(212, 25);
            this.lbAgregarNombres.Name = "lbAgregarNombres";
            this.lbAgregarNombres.Size = new System.Drawing.Size(89, 13);
            this.lbAgregarNombres.TabIndex = 3;
            this.lbAgregarNombres.Text = "Agregar Nombres";
            // 
            // lbAgregarDescr
            // 
            this.lbAgregarDescr.AutoSize = true;
            this.lbAgregarDescr.Location = new System.Drawing.Point(359, 25);
            this.lbAgregarDescr.Name = "lbAgregarDescr";
            this.lbAgregarDescr.Size = new System.Drawing.Size(103, 13);
            this.lbAgregarDescr.TabIndex = 4;
            this.lbAgregarDescr.Text = "Agregar Descripcion";
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(169, 161);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.Size = new System.Drawing.Size(240, 150);
            this.dgvMostrarDatos.TabIndex = 5;
            this.dgvMostrarDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(334, 101);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtElimDatos
            // 
            this.txtElimDatos.Location = new System.Drawing.Point(77, 41);
            this.txtElimDatos.Name = "txtElimDatos";
            this.txtElimDatos.Size = new System.Drawing.Size(100, 20);
            this.txtElimDatos.TabIndex = 7;
            this.txtElimDatos.MouseEnter += new System.EventHandler(this.txtElimDatos_MouseEnter);
            this.txtElimDatos.MouseLeave += new System.EventHandler(this.txtElimDatos_MouseLeave);
            // 
            // lbEliminarDatos
            // 
            this.lbEliminarDatos.AutoSize = true;
            this.lbEliminarDatos.Location = new System.Drawing.Point(74, 25);
            this.lbEliminarDatos.Name = "lbEliminarDatos";
            this.lbEliminarDatos.Size = new System.Drawing.Size(18, 13);
            this.lbEliminarDatos.TabIndex = 8;
            this.lbEliminarDatos.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 388);
            this.Controls.Add(this.lbEliminarDatos);
            this.Controls.Add(this.txtElimDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvMostrarDatos);
            this.Controls.Add(this.lbAgregarDescr);
            this.Controls.Add(this.lbAgregarNombres);
            this.Controls.Add(this.txtAgrDescr);
            this.Controls.Add(this.txtAgrNombre);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtAgrNombre;
        private System.Windows.Forms.TextBox txtAgrDescr;
        private System.Windows.Forms.Label lbAgregarNombres;
        private System.Windows.Forms.Label lbAgregarDescr;
        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtElimDatos;
        private System.Windows.Forms.Label lbEliminarDatos;
    }
}

