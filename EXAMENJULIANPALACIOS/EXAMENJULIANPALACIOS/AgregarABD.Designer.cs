namespace EXAMENJULIANPALACIOS
{
    partial class AgregarABD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIngRut = new System.Windows.Forms.TextBox();
            this.txtIngNombre = new System.Windows.Forms.TextBox();
            this.txtIngEdad = new System.Windows.Forms.TextBox();
            this.txtIngProf1 = new System.Windows.Forms.TextBox();
            this.txtIngProf2 = new System.Windows.Forms.TextBox();
            this.txtPromEncu = new System.Windows.Forms.TextBox();
            this.lbIngRut = new System.Windows.Forms.Label();
            this.lbIngNombre = new System.Windows.Forms.Label();
            this.lbIngEdad = new System.Windows.Forms.Label();
            this.lbIngProf1 = new System.Windows.Forms.Label();
            this.lbIngProf2 = new System.Windows.Forms.Label();
            this.lbIngPromEncue = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIngRut
            // 
            this.txtIngRut.Location = new System.Drawing.Point(63, 114);
            this.txtIngRut.Name = "txtIngRut";
            this.txtIngRut.Size = new System.Drawing.Size(100, 20);
            this.txtIngRut.TabIndex = 0;
            // 
            // txtIngNombre
            // 
            this.txtIngNombre.Location = new System.Drawing.Point(212, 114);
            this.txtIngNombre.Name = "txtIngNombre";
            this.txtIngNombre.Size = new System.Drawing.Size(260, 20);
            this.txtIngNombre.TabIndex = 1;
            // 
            // txtIngEdad
            // 
            this.txtIngEdad.Location = new System.Drawing.Point(513, 114);
            this.txtIngEdad.Name = "txtIngEdad";
            this.txtIngEdad.Size = new System.Drawing.Size(69, 20);
            this.txtIngEdad.TabIndex = 2;
            // 
            // txtIngProf1
            // 
            this.txtIngProf1.Location = new System.Drawing.Point(63, 245);
            this.txtIngProf1.Name = "txtIngProf1";
            this.txtIngProf1.Size = new System.Drawing.Size(175, 20);
            this.txtIngProf1.TabIndex = 3;
            // 
            // txtIngProf2
            // 
            this.txtIngProf2.Location = new System.Drawing.Point(275, 245);
            this.txtIngProf2.Name = "txtIngProf2";
            this.txtIngProf2.Size = new System.Drawing.Size(175, 20);
            this.txtIngProf2.TabIndex = 4;
            // 
            // txtPromEncu
            // 
            this.txtPromEncu.Location = new System.Drawing.Point(482, 245);
            this.txtPromEncu.Name = "txtPromEncu";
            this.txtPromEncu.Size = new System.Drawing.Size(100, 20);
            this.txtPromEncu.TabIndex = 5;
            // 
            // lbIngRut
            // 
            this.lbIngRut.AutoSize = true;
            this.lbIngRut.Location = new System.Drawing.Point(77, 98);
            this.lbIngRut.Name = "lbIngRut";
            this.lbIngRut.Size = new System.Drawing.Size(71, 13);
            this.lbIngRut.TabIndex = 6;
            this.lbIngRut.Text = "Ingresar RUT";
            // 
            // lbIngNombre
            // 
            this.lbIngNombre.AutoSize = true;
            this.lbIngNombre.Location = new System.Drawing.Point(301, 98);
            this.lbIngNombre.Name = "lbIngNombre";
            this.lbIngNombre.Size = new System.Drawing.Size(85, 13);
            this.lbIngNombre.TabIndex = 7;
            this.lbIngNombre.Text = "Ingresar Nombre";
            // 
            // lbIngEdad
            // 
            this.lbIngEdad.AutoSize = true;
            this.lbIngEdad.Location = new System.Drawing.Point(510, 98);
            this.lbIngEdad.Name = "lbIngEdad";
            this.lbIngEdad.Size = new System.Drawing.Size(72, 13);
            this.lbIngEdad.TabIndex = 8;
            this.lbIngEdad.Text = "Ingresar edad";
            // 
            // lbIngProf1
            // 
            this.lbIngProf1.AutoSize = true;
            this.lbIngProf1.Location = new System.Drawing.Point(99, 229);
            this.lbIngProf1.Name = "lbIngProf1";
            this.lbIngProf1.Size = new System.Drawing.Size(100, 13);
            this.lbIngProf1.TabIndex = 9;
            this.lbIngProf1.Text = "Ingresar profesion 1";
            // 
            // lbIngProf2
            // 
            this.lbIngProf2.AutoSize = true;
            this.lbIngProf2.Location = new System.Drawing.Point(312, 229);
            this.lbIngProf2.Name = "lbIngProf2";
            this.lbIngProf2.Size = new System.Drawing.Size(100, 13);
            this.lbIngProf2.TabIndex = 10;
            this.lbIngProf2.Text = "Ingresar profesion 2";
            // 
            // lbIngPromEncue
            // 
            this.lbIngPromEncue.AutoSize = true;
            this.lbIngPromEncue.Location = new System.Drawing.Point(461, 229);
            this.lbIngPromEncue.Name = "lbIngPromEncue";
            this.lbIngPromEncue.Size = new System.Drawing.Size(138, 13);
            this.lbIngPromEncue.TabIndex = 11;
            this.lbIngPromEncue.Text = "Ingresar promedio encuesta";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(199, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(364, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarABD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 426);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbIngPromEncue);
            this.Controls.Add(this.lbIngProf2);
            this.Controls.Add(this.lbIngProf1);
            this.Controls.Add(this.lbIngEdad);
            this.Controls.Add(this.lbIngNombre);
            this.Controls.Add(this.lbIngRut);
            this.Controls.Add(this.txtPromEncu);
            this.Controls.Add(this.txtIngProf2);
            this.Controls.Add(this.txtIngProf1);
            this.Controls.Add(this.txtIngEdad);
            this.Controls.Add(this.txtIngNombre);
            this.Controls.Add(this.txtIngRut);
            this.Name = "AgregarABD";
            this.Text = "AgregarABD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngRut;
        private System.Windows.Forms.TextBox txtIngNombre;
        private System.Windows.Forms.TextBox txtIngEdad;
        private System.Windows.Forms.TextBox txtIngProf1;
        private System.Windows.Forms.TextBox txtIngProf2;
        private System.Windows.Forms.TextBox txtPromEncu;
        private System.Windows.Forms.Label lbIngRut;
        private System.Windows.Forms.Label lbIngNombre;
        private System.Windows.Forms.Label lbIngEdad;
        private System.Windows.Forms.Label lbIngProf1;
        private System.Windows.Forms.Label lbIngProf2;
        private System.Windows.Forms.Label lbIngPromEncue;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}