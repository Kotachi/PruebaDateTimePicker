namespace prog2bddJulianPalacios
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
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApPat = new System.Windows.Forms.TextBox();
            this.txtApMat = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.lbNombres = new System.Windows.Forms.Label();
            this.lbApPat = new System.Windows.Forms.Label();
            this.lbApMat = new System.Windows.Forms.Label();
            this.lbRut = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbNotas = new System.Windows.Forms.Label();
            this.lbAsign = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFNac = new System.Windows.Forms.DateTimePicker();
            this.rbAgregar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.gbRadio = new System.Windows.Forms.GroupBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.pnlAgregar.SuspendLayout();
            this.gbRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.dtpFNac);
            this.pnlAgregar.Controls.Add(this.btnGuardar);
            this.pnlAgregar.Controls.Add(this.lbAsign);
            this.pnlAgregar.Controls.Add(this.lbNotas);
            this.pnlAgregar.Controls.Add(this.lbEdad);
            this.pnlAgregar.Controls.Add(this.lbRut);
            this.pnlAgregar.Controls.Add(this.lbApMat);
            this.pnlAgregar.Controls.Add(this.lbApPat);
            this.pnlAgregar.Controls.Add(this.lbNombres);
            this.pnlAgregar.Controls.Add(this.txtAsignatura);
            this.pnlAgregar.Controls.Add(this.txtNotas);
            this.pnlAgregar.Controls.Add(this.txtEdad);
            this.pnlAgregar.Controls.Add(this.txtRut);
            this.pnlAgregar.Controls.Add(this.txtApMat);
            this.pnlAgregar.Controls.Add(this.txtApPat);
            this.pnlAgregar.Controls.Add(this.txtNombre);
            this.pnlAgregar.Location = new System.Drawing.Point(71, 121);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(675, 280);
            this.pnlAgregar.TabIndex = 0;
            this.pnlAgregar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAgregar_Paint);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(42, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApPat
            // 
            this.txtApPat.Location = new System.Drawing.Point(200, 60);
            this.txtApPat.Name = "txtApPat";
            this.txtApPat.Size = new System.Drawing.Size(117, 20);
            this.txtApPat.TabIndex = 1;
            // 
            // txtApMat
            // 
            this.txtApMat.Location = new System.Drawing.Point(361, 60);
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.Size = new System.Drawing.Size(119, 20);
            this.txtApMat.TabIndex = 2;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(524, 60);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 20);
            this.txtRut.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(42, 158);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 4;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(200, 158);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(100, 20);
            this.txtNotas.TabIndex = 5;
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Location = new System.Drawing.Point(361, 158);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(100, 20);
            this.txtAsignatura.TabIndex = 6;
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Location = new System.Drawing.Point(39, 44);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(85, 13);
            this.lbNombres.TabIndex = 7;
            this.lbNombres.Text = "Ingrese nombres";
            // 
            // lbApPat
            // 
            this.lbApPat.AutoSize = true;
            this.lbApPat.Location = new System.Drawing.Point(197, 44);
            this.lbApPat.Name = "lbApPat";
            this.lbApPat.Size = new System.Drawing.Size(120, 13);
            this.lbApPat.TabIndex = 8;
            this.lbApPat.Text = "Ingrese apellido paterno";
            // 
            // lbApMat
            // 
            this.lbApMat.AutoSize = true;
            this.lbApMat.Location = new System.Drawing.Point(358, 44);
            this.lbApMat.Name = "lbApMat";
            this.lbApMat.Size = new System.Drawing.Size(122, 13);
            this.lbApMat.TabIndex = 9;
            this.lbApMat.Text = "Ingrese apellido materno";
            // 
            // lbRut
            // 
            this.lbRut.AutoSize = true;
            this.lbRut.Location = new System.Drawing.Point(521, 44);
            this.lbRut.Name = "lbRut";
            this.lbRut.Size = new System.Drawing.Size(57, 13);
            this.lbRut.TabIndex = 10;
            this.lbRut.Text = "Ingrese rut";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(39, 142);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(69, 13);
            this.lbEdad.TabIndex = 11;
            this.lbEdad.Text = "Ingrese edad";
            // 
            // lbNotas
            // 
            this.lbNotas.AutoSize = true;
            this.lbNotas.Location = new System.Drawing.Point(197, 142);
            this.lbNotas.Name = "lbNotas";
            this.lbNotas.Size = new System.Drawing.Size(66, 13);
            this.lbNotas.TabIndex = 12;
            this.lbNotas.Text = "Ingrese nota";
            // 
            // lbAsign
            // 
            this.lbAsign.AutoSize = true;
            this.lbAsign.Location = new System.Drawing.Point(358, 142);
            this.lbAsign.Name = "lbAsign";
            this.lbAsign.Size = new System.Drawing.Size(94, 13);
            this.lbAsign.TabIndex = 13;
            this.lbAsign.Text = "Ingrese asignatura";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(309, 241);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFNac
            // 
            this.dtpFNac.CustomFormat = "yyyy-MM-dd";
            this.dtpFNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFNac.Location = new System.Drawing.Point(524, 158);
            this.dtpFNac.Name = "dtpFNac";
            this.dtpFNac.Size = new System.Drawing.Size(125, 20);
            this.dtpFNac.TabIndex = 15;
            // 
            // rbAgregar
            // 
            this.rbAgregar.AutoSize = true;
            this.rbAgregar.Location = new System.Drawing.Point(22, 29);
            this.rbAgregar.Name = "rbAgregar";
            this.rbAgregar.Size = new System.Drawing.Size(62, 17);
            this.rbAgregar.TabIndex = 2;
            this.rbAgregar.TabStop = true;
            this.rbAgregar.Text = "Agregar";
            this.rbAgregar.UseVisualStyleBackColor = true;
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(144, 29);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(61, 17);
            this.rbEliminar.TabIndex = 3;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            // 
            // rbModificar
            // 
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(264, 29);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(68, 17);
            this.rbModificar.TabIndex = 4;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            // 
            // gbRadio
            // 
            this.gbRadio.Controls.Add(this.rbModificar);
            this.gbRadio.Controls.Add(this.rbEliminar);
            this.gbRadio.Controls.Add(this.rbAgregar);
            this.gbRadio.Location = new System.Drawing.Point(225, 29);
            this.gbRadio.Name = "gbRadio";
            this.gbRadio.Size = new System.Drawing.Size(343, 67);
            this.gbRadio.TabIndex = 5;
            this.gbRadio.TabStop = false;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(27, 73);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 511);
            this.Controls.Add(this.gbRadio);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.pnlAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            this.gbRadio.ResumeLayout(false);
            this.gbRadio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtApMat;
        private System.Windows.Forms.TextBox txtApPat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbAsign;
        private System.Windows.Forms.Label lbNotas;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbRut;
        private System.Windows.Forms.Label lbApMat;
        private System.Windows.Forms.Label lbApPat;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.DateTimePicker dtpFNac;
        private System.Windows.Forms.RadioButton rbAgregar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.GroupBox gbRadio;
        private System.Windows.Forms.Button btnConectar;
    }
}

