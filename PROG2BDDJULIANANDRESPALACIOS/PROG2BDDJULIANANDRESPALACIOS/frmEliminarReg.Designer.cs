namespace PROG2BDDJULIANANDRESPALACIOS
{
    partial class frmEliminarReg
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
            this.txtElimReg = new System.Windows.Forms.TextBox();
            this.lbElimReg = new System.Windows.Forms.Label();
            this.btnElimReg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAyudaElim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtElimReg
            // 
            this.txtElimReg.Location = new System.Drawing.Point(327, 111);
            this.txtElimReg.Name = "txtElimReg";
            this.txtElimReg.Size = new System.Drawing.Size(100, 20);
            this.txtElimReg.TabIndex = 0;
            // 
            // lbElimReg
            // 
            this.lbElimReg.AutoSize = true;
            this.lbElimReg.Location = new System.Drawing.Point(347, 95);
            this.lbElimReg.Name = "lbElimReg";
            this.lbElimReg.Size = new System.Drawing.Size(59, 13);
            this.lbElimReg.TabIndex = 1;
            this.lbElimReg.Text = "Ingresar ID";
            // 
            // btnElimReg
            // 
            this.btnElimReg.Location = new System.Drawing.Point(339, 164);
            this.btnElimReg.Name = "btnElimReg";
            this.btnElimReg.Size = new System.Drawing.Size(75, 23);
            this.btnElimReg.TabIndex = 2;
            this.btnElimReg.Text = "Eliminar";
            this.btnElimReg.UseVisualStyleBackColor = true;
            this.btnElimReg.Click += new System.EventHandler(this.btnElimReg_Click);
            this.btnElimReg.MouseEnter += new System.EventHandler(this.btnElimReg_MouseEnter);
            this.btnElimReg.MouseLeave += new System.EventHandler(this.btnElimReg_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::PROG2BDDJULIANANDRESPALACIOS.Properties.Resources.logo_los_leonesEDIT2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbAyudaElim
            // 
            this.lbAyudaElim.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAyudaElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAyudaElim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAyudaElim.Location = new System.Drawing.Point(306, 9);
            this.lbAyudaElim.Name = "lbAyudaElim";
            this.lbAyudaElim.Size = new System.Drawing.Size(144, 65);
            this.lbAyudaElim.TabIndex = 14;
            this.lbAyudaElim.Text = "Para eliminar un dato ingrese el ID del registro y presione \"Eliminar\".";
            this.lbAyudaElim.Visible = false;
            // 
            // frmEliminarReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 260);
            this.Controls.Add(this.lbAyudaElim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnElimReg);
            this.Controls.Add(this.lbElimReg);
            this.Controls.Add(this.txtElimReg);
            this.Name = "frmEliminarReg";
            this.Text = "Eliminar Registros";
            this.Shown += new System.EventHandler(this.frmEliminarReg_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElimReg;
        private System.Windows.Forms.Label lbElimReg;
        private System.Windows.Forms.Button btnElimReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAyudaElim;
    }
}