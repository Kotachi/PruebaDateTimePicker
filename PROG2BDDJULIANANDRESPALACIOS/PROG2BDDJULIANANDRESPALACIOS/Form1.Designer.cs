namespace PROG2BDDJULIANANDRESPALACIOS
{
    partial class frmPrincipal
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
            this.btnAgregarReg = new System.Windows.Forms.Button();
            this.btnEliminarReg = new System.Windows.Forms.Button();
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            this.btnCerrarPpal = new System.Windows.Forms.Button();
            this.btnMenorEdad = new System.Windows.Forms.Button();
            this.btnPromEdad = new System.Windows.Forms.Button();
            this.btnPromNotas = new System.Windows.Forms.Button();
            this.lbRutMenorEdad = new System.Windows.Forms.Label();
            this.lbMenorEdad = new System.Windows.Forms.Label();
            this.lbTitMenorEdad = new System.Windows.Forms.Label();
            this.lbPromEdad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarReg
            // 
            this.btnAgregarReg.Location = new System.Drawing.Point(345, 38);
            this.btnAgregarReg.Name = "btnAgregarReg";
            this.btnAgregarReg.Size = new System.Drawing.Size(101, 23);
            this.btnAgregarReg.TabIndex = 0;
            this.btnAgregarReg.Text = "Agregar Registro";
            this.btnAgregarReg.UseVisualStyleBackColor = true;
            this.btnAgregarReg.Click += new System.EventHandler(this.btnAgregarReg_Click);
            // 
            // btnEliminarReg
            // 
            this.btnEliminarReg.Location = new System.Drawing.Point(483, 38);
            this.btnEliminarReg.Name = "btnEliminarReg";
            this.btnEliminarReg.Size = new System.Drawing.Size(108, 23);
            this.btnEliminarReg.TabIndex = 1;
            this.btnEliminarReg.Text = "Eliminar Registro";
            this.btnEliminarReg.UseVisualStyleBackColor = true;
            this.btnEliminarReg.Click += new System.EventHandler(this.btnEliminarReg_Click);
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMostrarDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(25, 170);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.ReadOnly = true;
            this.dgvMostrarDatos.Size = new System.Drawing.Size(742, 220);
            this.dgvMostrarDatos.TabIndex = 2;
            // 
            // btnCerrarPpal
            // 
            this.btnCerrarPpal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCerrarPpal.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPpal.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarPpal.Location = new System.Drawing.Point(748, 12);
            this.btnCerrarPpal.Name = "btnCerrarPpal";
            this.btnCerrarPpal.Size = new System.Drawing.Size(33, 28);
            this.btnCerrarPpal.TabIndex = 3;
            this.btnCerrarPpal.Text = "X";
            this.btnCerrarPpal.UseVisualStyleBackColor = false;
            this.btnCerrarPpal.Click += new System.EventHandler(this.btnCerrarPpal_Click);
            // 
            // btnMenorEdad
            // 
            this.btnMenorEdad.Location = new System.Drawing.Point(344, 116);
            this.btnMenorEdad.Name = "btnMenorEdad";
            this.btnMenorEdad.Size = new System.Drawing.Size(75, 23);
            this.btnMenorEdad.TabIndex = 4;
            this.btnMenorEdad.Text = "Menor Edad";
            this.btnMenorEdad.UseVisualStyleBackColor = true;
            this.btnMenorEdad.Click += new System.EventHandler(this.btnMenorEdad_Click);
            // 
            // btnPromEdad
            // 
            this.btnPromEdad.Location = new System.Drawing.Point(446, 116);
            this.btnPromEdad.Name = "btnPromEdad";
            this.btnPromEdad.Size = new System.Drawing.Size(113, 23);
            this.btnPromEdad.TabIndex = 5;
            this.btnPromEdad.Text = "Promedio Edad";
            this.btnPromEdad.UseVisualStyleBackColor = true;
            this.btnPromEdad.Click += new System.EventHandler(this.btnPromEdad_Click);
            // 
            // btnPromNotas
            // 
            this.btnPromNotas.Location = new System.Drawing.Point(586, 116);
            this.btnPromNotas.Name = "btnPromNotas";
            this.btnPromNotas.Size = new System.Drawing.Size(117, 23);
            this.btnPromNotas.TabIndex = 6;
            this.btnPromNotas.Text = "Promedio Notas";
            this.btnPromNotas.UseVisualStyleBackColor = true;
            this.btnPromNotas.Click += new System.EventHandler(this.btnPromNotas_Click);
            // 
            // lbRutMenorEdad
            // 
            this.lbRutMenorEdad.AutoSize = true;
            this.lbRutMenorEdad.BackColor = System.Drawing.Color.AliceBlue;
            this.lbRutMenorEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRutMenorEdad.Location = new System.Drawing.Point(159, 447);
            this.lbRutMenorEdad.Name = "lbRutMenorEdad";
            this.lbRutMenorEdad.Size = new System.Drawing.Size(0, 18);
            this.lbRutMenorEdad.TabIndex = 7;
            // 
            // lbMenorEdad
            // 
            this.lbMenorEdad.AutoSize = true;
            this.lbMenorEdad.BackColor = System.Drawing.Color.AliceBlue;
            this.lbMenorEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenorEdad.Location = new System.Drawing.Point(254, 447);
            this.lbMenorEdad.Name = "lbMenorEdad";
            this.lbMenorEdad.Size = new System.Drawing.Size(0, 18);
            this.lbMenorEdad.TabIndex = 8;
            // 
            // lbTitMenorEdad
            // 
            this.lbTitMenorEdad.AutoSize = true;
            this.lbTitMenorEdad.BackColor = System.Drawing.Color.AliceBlue;
            this.lbTitMenorEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitMenorEdad.Location = new System.Drawing.Point(158, 410);
            this.lbTitMenorEdad.Name = "lbTitMenorEdad";
            this.lbTitMenorEdad.Size = new System.Drawing.Size(96, 20);
            this.lbTitMenorEdad.TabIndex = 9;
            this.lbTitMenorEdad.Text = "Menor Edad";
            this.lbTitMenorEdad.Visible = false;
            // 
            // lbPromEdad
            // 
            this.lbPromEdad.AutoSize = true;
            this.lbPromEdad.BackColor = System.Drawing.Color.AliceBlue;
            this.lbPromEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPromEdad.Location = new System.Drawing.Point(480, 410);
            this.lbPromEdad.Name = "lbPromEdad";
            this.lbPromEdad.Size = new System.Drawing.Size(184, 20);
            this.lbPromEdad.TabIndex = 10;
            this.lbPromEdad.Text = "El promedio de edad es: ";
            this.lbPromEdad.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROG2BDDJULIANANDRESPALACIOS.Properties.Resources.logo_los_leonesEDIT2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 535);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPromEdad);
            this.Controls.Add(this.lbTitMenorEdad);
            this.Controls.Add(this.lbMenorEdad);
            this.Controls.Add(this.lbRutMenorEdad);
            this.Controls.Add(this.btnPromNotas);
            this.Controls.Add(this.btnPromEdad);
            this.Controls.Add(this.btnMenorEdad);
            this.Controls.Add(this.btnCerrarPpal);
            this.Controls.Add(this.dgvMostrarDatos);
            this.Controls.Add(this.btnEliminarReg);
            this.Controls.Add(this.btnAgregarReg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Enter += new System.EventHandler(this.frmPrincipal_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarReg;
        private System.Windows.Forms.Button btnEliminarReg;
        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Button btnCerrarPpal;
        private System.Windows.Forms.Button btnMenorEdad;
        private System.Windows.Forms.Button btnPromEdad;
        private System.Windows.Forms.Button btnPromNotas;
        private System.Windows.Forms.Label lbRutMenorEdad;
        private System.Windows.Forms.Label lbMenorEdad;
        private System.Windows.Forms.Label lbTitMenorEdad;
        private System.Windows.Forms.Label lbPromEdad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

