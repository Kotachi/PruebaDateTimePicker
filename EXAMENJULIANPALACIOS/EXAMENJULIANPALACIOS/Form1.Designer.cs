namespace EXAMENJULIANPALACIOS
{
    partial class Principal
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
            this.btnBaseDeDatos = new System.Windows.Forms.Button();
            this.btnMultXTres = new System.Windows.Forms.Button();
            this.btnParOImpar = new System.Windows.Forms.Button();
            this.btnTablaMult = new System.Windows.Forms.Button();
            this.btnArray = new System.Windows.Forms.Button();
            this.lbBaseDeDatos = new System.Windows.Forms.Label();
            this.lbMultXTres = new System.Windows.Forms.Label();
            this.lbParOImpar = new System.Windows.Forms.Label();
            this.lbTablaMult = new System.Windows.Forms.Label();
            this.lbArray = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaseDeDatos
            // 
            this.btnBaseDeDatos.Location = new System.Drawing.Point(94, 120);
            this.btnBaseDeDatos.Name = "btnBaseDeDatos";
            this.btnBaseDeDatos.Size = new System.Drawing.Size(103, 23);
            this.btnBaseDeDatos.TabIndex = 0;
            this.btnBaseDeDatos.Text = "Base de datos";
            this.btnBaseDeDatos.UseVisualStyleBackColor = true;
            this.btnBaseDeDatos.Click += new System.EventHandler(this.btnBaseDeDatos_Click);
            // 
            // btnMultXTres
            // 
            this.btnMultXTres.Location = new System.Drawing.Point(341, 120);
            this.btnMultXTres.Name = "btnMultXTres";
            this.btnMultXTres.Size = new System.Drawing.Size(75, 23);
            this.btnMultXTres.TabIndex = 1;
            this.btnMultXTres.Text = "x 3";
            this.btnMultXTres.UseVisualStyleBackColor = true;
            this.btnMultXTres.Click += new System.EventHandler(this.btnMultXTres_Click);
            // 
            // btnParOImpar
            // 
            this.btnParOImpar.Location = new System.Drawing.Point(588, 120);
            this.btnParOImpar.Name = "btnParOImpar";
            this.btnParOImpar.Size = new System.Drawing.Size(75, 23);
            this.btnParOImpar.TabIndex = 2;
            this.btnParOImpar.Text = "Par o impar";
            this.btnParOImpar.UseVisualStyleBackColor = true;
            this.btnParOImpar.Click += new System.EventHandler(this.btnParOImpar_Click);
            // 
            // btnTablaMult
            // 
            this.btnTablaMult.Location = new System.Drawing.Point(198, 289);
            this.btnTablaMult.Name = "btnTablaMult";
            this.btnTablaMult.Size = new System.Drawing.Size(129, 23);
            this.btnTablaMult.TabIndex = 3;
            this.btnTablaMult.Text = "Tabla de multiplicar";
            this.btnTablaMult.UseVisualStyleBackColor = true;
            this.btnTablaMult.Click += new System.EventHandler(this.btnTablaMult_Click);
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(462, 289);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(75, 23);
            this.btnArray.TabIndex = 4;
            this.btnArray.Text = "Array";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // lbBaseDeDatos
            // 
            this.lbBaseDeDatos.AutoSize = true;
            this.lbBaseDeDatos.Location = new System.Drawing.Point(76, 104);
            this.lbBaseDeDatos.Name = "lbBaseDeDatos";
            this.lbBaseDeDatos.Size = new System.Drawing.Size(135, 13);
            this.lbBaseDeDatos.TabIndex = 5;
            this.lbBaseDeDatos.Text = "Ingresar a la base de datos";
            // 
            // lbMultXTres
            // 
            this.lbMultXTres.AutoSize = true;
            this.lbMultXTres.Location = new System.Drawing.Point(338, 104);
            this.lbMultXTres.Name = "lbMultXTres";
            this.lbMultXTres.Size = new System.Drawing.Size(88, 13);
            this.lbMultXTres.TabIndex = 6;
            this.lbMultXTres.Text = "Multiplicacion x 3";
            // 
            // lbParOImpar
            // 
            this.lbParOImpar.AutoSize = true;
            this.lbParOImpar.Location = new System.Drawing.Point(543, 104);
            this.lbParOImpar.Name = "lbParOImpar";
            this.lbParOImpar.Size = new System.Drawing.Size(167, 13);
            this.lbParOImpar.TabIndex = 7;
            this.lbParOImpar.Text = "Saber si un numero es par o impar";
            // 
            // lbTablaMult
            // 
            this.lbTablaMult.AutoSize = true;
            this.lbTablaMult.Location = new System.Drawing.Point(214, 273);
            this.lbTablaMult.Name = "lbTablaMult";
            this.lbTablaMult.Size = new System.Drawing.Size(98, 13);
            this.lbTablaMult.TabIndex = 8;
            this.lbTablaMult.Text = "Tabla de multiplicar";
            // 
            // lbArray
            // 
            this.lbArray.AutoSize = true;
            this.lbArray.Location = new System.Drawing.Point(459, 273);
            this.lbArray.Name = "lbArray";
            this.lbArray.Size = new System.Drawing.Size(31, 13);
            this.lbArray.TabIndex = 9;
            this.lbArray.Text = "Array";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(663, 37);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 477);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbArray);
            this.Controls.Add(this.lbTablaMult);
            this.Controls.Add(this.lbParOImpar);
            this.Controls.Add(this.lbMultXTres);
            this.Controls.Add(this.lbBaseDeDatos);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.btnTablaMult);
            this.Controls.Add(this.btnParOImpar);
            this.Controls.Add(this.btnMultXTres);
            this.Controls.Add(this.btnBaseDeDatos);
            this.Name = "Principal";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaseDeDatos;
        private System.Windows.Forms.Button btnMultXTres;
        private System.Windows.Forms.Button btnParOImpar;
        private System.Windows.Forms.Button btnTablaMult;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Label lbBaseDeDatos;
        private System.Windows.Forms.Label lbMultXTres;
        private System.Windows.Forms.Label lbParOImpar;
        private System.Windows.Forms.Label lbTablaMult;
        private System.Windows.Forms.Label lbArray;
        private System.Windows.Forms.Button btnSalir;
    }
}

