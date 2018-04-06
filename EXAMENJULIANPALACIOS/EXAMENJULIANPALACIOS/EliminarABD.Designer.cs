namespace EXAMENJULIANPALACIOS
{
    partial class EliminarABD
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
            this.txtElimRut = new System.Windows.Forms.TextBox();
            this.lbElimRut = new System.Windows.Forms.Label();
            this.btnEliminarBD = new System.Windows.Forms.Button();
            this.btnCancelElim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtElimRut
            // 
            this.txtElimRut.Location = new System.Drawing.Point(154, 84);
            this.txtElimRut.Name = "txtElimRut";
            this.txtElimRut.Size = new System.Drawing.Size(100, 20);
            this.txtElimRut.TabIndex = 0;
            // 
            // lbElimRut
            // 
            this.lbElimRut.AutoSize = true;
            this.lbElimRut.Location = new System.Drawing.Point(167, 68);
            this.lbElimRut.Name = "lbElimRut";
            this.lbElimRut.Size = new System.Drawing.Size(69, 13);
            this.lbElimRut.TabIndex = 1;
            this.lbElimRut.Text = "Eliminar RUT";
            // 
            // btnEliminarBD
            // 
            this.btnEliminarBD.Location = new System.Drawing.Point(111, 177);
            this.btnEliminarBD.Name = "btnEliminarBD";
            this.btnEliminarBD.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarBD.TabIndex = 2;
            this.btnEliminarBD.Text = "Eliminar";
            this.btnEliminarBD.UseVisualStyleBackColor = true;
            this.btnEliminarBD.Click += new System.EventHandler(this.btnEliminarBD_Click);
            // 
            // btnCancelElim
            // 
            this.btnCancelElim.Location = new System.Drawing.Point(239, 177);
            this.btnCancelElim.Name = "btnCancelElim";
            this.btnCancelElim.Size = new System.Drawing.Size(75, 23);
            this.btnCancelElim.TabIndex = 3;
            this.btnCancelElim.Text = "Cancelar";
            this.btnCancelElim.UseVisualStyleBackColor = true;
            this.btnCancelElim.Click += new System.EventHandler(this.btnCancelElim_Click);
            // 
            // EliminarABD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 286);
            this.Controls.Add(this.btnCancelElim);
            this.Controls.Add(this.btnEliminarBD);
            this.Controls.Add(this.lbElimRut);
            this.Controls.Add(this.txtElimRut);
            this.Name = "EliminarABD";
            this.Text = "EliminarABD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElimRut;
        private System.Windows.Forms.Label lbElimRut;
        private System.Windows.Forms.Button btnEliminarBD;
        private System.Windows.Forms.Button btnCancelElim;
    }
}