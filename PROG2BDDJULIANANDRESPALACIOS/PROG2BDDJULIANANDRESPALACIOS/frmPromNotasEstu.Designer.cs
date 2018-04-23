namespace PROG2BDDJULIANANDRESPALACIOS
{
    partial class frmPromNotasEstu
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
            this.txtIngAsignatura = new System.Windows.Forms.TextBox();
            this.lbIngRut = new System.Windows.Forms.Label();
            this.lbIngAsigna = new System.Windows.Forms.Label();
            this.btnPromNotaEst = new System.Windows.Forms.Button();
            this.dgvPromNotasEstu = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAyudaProm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromNotasEstu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIngRut
            // 
            this.txtIngRut.Location = new System.Drawing.Point(311, 114);
            this.txtIngRut.MaxLength = 10;
            this.txtIngRut.Name = "txtIngRut";
            this.txtIngRut.Size = new System.Drawing.Size(100, 20);
            this.txtIngRut.TabIndex = 0;
            // 
            // txtIngAsignatura
            // 
            this.txtIngAsignatura.Location = new System.Drawing.Point(435, 114);
            this.txtIngAsignatura.Name = "txtIngAsignatura";
            this.txtIngAsignatura.Size = new System.Drawing.Size(100, 20);
            this.txtIngAsignatura.TabIndex = 1;
            // 
            // lbIngRut
            // 
            this.lbIngRut.AutoSize = true;
            this.lbIngRut.Location = new System.Drawing.Point(308, 98);
            this.lbIngRut.Name = "lbIngRut";
            this.lbIngRut.Size = new System.Drawing.Size(62, 13);
            this.lbIngRut.TabIndex = 2;
            this.lbIngRut.Text = "Ingrese Rut";
            // 
            // lbIngAsigna
            // 
            this.lbIngAsigna.AutoSize = true;
            this.lbIngAsigna.Location = new System.Drawing.Point(432, 98);
            this.lbIngAsigna.Name = "lbIngAsigna";
            this.lbIngAsigna.Size = new System.Drawing.Size(95, 13);
            this.lbIngAsigna.TabIndex = 3;
            this.lbIngAsigna.Text = "Ingrese Asignatura";
            // 
            // btnPromNotaEst
            // 
            this.btnPromNotaEst.Location = new System.Drawing.Point(568, 111);
            this.btnPromNotaEst.Name = "btnPromNotaEst";
            this.btnPromNotaEst.Size = new System.Drawing.Size(75, 23);
            this.btnPromNotaEst.TabIndex = 4;
            this.btnPromNotaEst.Text = "Promedio";
            this.btnPromNotaEst.UseVisualStyleBackColor = true;
            this.btnPromNotaEst.Click += new System.EventHandler(this.btnPromNotaEst_Click);
            this.btnPromNotaEst.MouseEnter += new System.EventHandler(this.btnPromNotaEst_MouseEnter);
            this.btnPromNotaEst.MouseLeave += new System.EventHandler(this.btnPromNotaEst_MouseLeave);
            // 
            // dgvPromNotasEstu
            // 
            this.dgvPromNotasEstu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromNotasEstu.Location = new System.Drawing.Point(38, 193);
            this.dgvPromNotasEstu.Name = "dgvPromNotasEstu";
            this.dgvPromNotasEstu.Size = new System.Drawing.Size(673, 150);
            this.dgvPromNotasEstu.TabIndex = 5;
            this.dgvPromNotasEstu.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::PROG2BDDJULIANANDRESPALACIOS.Properties.Resources.logo_los_leonesEDIT2;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbAyudaProm
            // 
            this.lbAyudaProm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAyudaProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAyudaProm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAyudaProm.Location = new System.Drawing.Point(478, 9);
            this.lbAyudaProm.Name = "lbAyudaProm";
            this.lbAyudaProm.Size = new System.Drawing.Size(233, 70);
            this.lbAyudaProm.TabIndex = 13;
            this.lbAyudaProm.Text = "Para ver el promedio de notas por asignatura, rellene los campos y pulse \"Promedi" +
    "o\".";
            this.lbAyudaProm.Visible = false;
            // 
            // frmPromNotasEstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 386);
            this.Controls.Add(this.lbAyudaProm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPromNotasEstu);
            this.Controls.Add(this.btnPromNotaEst);
            this.Controls.Add(this.lbIngAsigna);
            this.Controls.Add(this.lbIngRut);
            this.Controls.Add(this.txtIngAsignatura);
            this.Controls.Add(this.txtIngRut);
            this.Name = "frmPromNotasEstu";
            this.Text = "Promedio Notas Estudiante";
            this.Shown += new System.EventHandler(this.frmPromNotasEstu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromNotasEstu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngRut;
        private System.Windows.Forms.TextBox txtIngAsignatura;
        private System.Windows.Forms.Label lbIngRut;
        private System.Windows.Forms.Label lbIngAsigna;
        private System.Windows.Forms.Button btnPromNotaEst;
        private System.Windows.Forms.DataGridView dgvPromNotasEstu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAyudaProm;
    }
}