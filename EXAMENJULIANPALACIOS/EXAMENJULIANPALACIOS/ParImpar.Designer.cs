namespace EXAMENJULIANPALACIOS
{
    partial class ParImpar
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
            this.btnVolver3 = new System.Windows.Forms.Button();
            this.txtIngNumParImpar = new System.Windows.Forms.TextBox();
            this.lbIngNum = new System.Windows.Forms.Label();
            this.lbResultParImpar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver3
            // 
            this.btnVolver3.Location = new System.Drawing.Point(320, 72);
            this.btnVolver3.Name = "btnVolver3";
            this.btnVolver3.Size = new System.Drawing.Size(75, 23);
            this.btnVolver3.TabIndex = 0;
            this.btnVolver3.Text = "Volver";
            this.btnVolver3.UseVisualStyleBackColor = true;
            this.btnVolver3.Click += new System.EventHandler(this.btnVolver3_Click);
            // 
            // txtIngNumParImpar
            // 
            this.txtIngNumParImpar.Location = new System.Drawing.Point(42, 75);
            this.txtIngNumParImpar.Name = "txtIngNumParImpar";
            this.txtIngNumParImpar.Size = new System.Drawing.Size(100, 20);
            this.txtIngNumParImpar.TabIndex = 1;
            this.txtIngNumParImpar.TextChanged += new System.EventHandler(this.txtIngNumParImpar_TextChanged);
            // 
            // lbIngNum
            // 
            this.lbIngNum.AutoSize = true;
            this.lbIngNum.Location = new System.Drawing.Point(39, 59);
            this.lbIngNum.Name = "lbIngNum";
            this.lbIngNum.Size = new System.Drawing.Size(128, 13);
            this.lbIngNum.TabIndex = 2;
            this.lbIngNum.Text = "Ingrese un numero entero";
            // 
            // lbResultParImpar
            // 
            this.lbResultParImpar.AutoSize = true;
            this.lbResultParImpar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbResultParImpar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultParImpar.Location = new System.Drawing.Point(165, 181);
            this.lbResultParImpar.Name = "lbResultParImpar";
            this.lbResultParImpar.Size = new System.Drawing.Size(112, 28);
            this.lbResultParImpar.TabIndex = 3;
            this.lbResultParImpar.Text = "Respuesta";
            // 
            // ParImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 274);
            this.Controls.Add(this.lbResultParImpar);
            this.Controls.Add(this.lbIngNum);
            this.Controls.Add(this.txtIngNumParImpar);
            this.Controls.Add(this.btnVolver3);
            this.Name = "ParImpar";
            this.Text = "ParImpar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver3;
        private System.Windows.Forms.TextBox txtIngNumParImpar;
        private System.Windows.Forms.Label lbIngNum;
        private System.Windows.Forms.Label lbResultParImpar;
    }
}