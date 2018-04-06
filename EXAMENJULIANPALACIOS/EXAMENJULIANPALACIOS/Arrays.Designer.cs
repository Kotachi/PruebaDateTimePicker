namespace EXAMENJULIANPALACIOS
{
    partial class Arrays
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
            this.txtIngNum5 = new System.Windows.Forms.TextBox();
            this.lbIngNum5 = new System.Windows.Forms.Label();
            this.lbSuma = new System.Windows.Forms.Label();
            this.lbMayor = new System.Windows.Forms.Label();
            this.lbMenor = new System.Windows.Forms.Label();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.btnVolver5 = new System.Windows.Forms.Button();
            this.btnCalcular5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIngNum5
            // 
            this.txtIngNum5.Location = new System.Drawing.Point(80, 76);
            this.txtIngNum5.Name = "txtIngNum5";
            this.txtIngNum5.Size = new System.Drawing.Size(100, 20);
            this.txtIngNum5.TabIndex = 0;
            this.txtIngNum5.TextChanged += new System.EventHandler(this.txtIngNum5_TextChanged);
            // 
            // lbIngNum5
            // 
            this.lbIngNum5.AutoSize = true;
            this.lbIngNum5.Location = new System.Drawing.Point(77, 60);
            this.lbIngNum5.Name = "lbIngNum5";
            this.lbIngNum5.Size = new System.Drawing.Size(95, 13);
            this.lbIngNum5.TabIndex = 1;
            this.lbIngNum5.Text = "Ingrese un numero";
            // 
            // lbSuma
            // 
            this.lbSuma.AutoSize = true;
            this.lbSuma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSuma.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuma.Location = new System.Drawing.Point(168, 134);
            this.lbSuma.Name = "lbSuma";
            this.lbSuma.Size = new System.Drawing.Size(168, 28);
            this.lbSuma.TabIndex = 2;
            this.lbSuma.Text = "La suma total es: ";
            // 
            // lbMayor
            // 
            this.lbMayor.AutoSize = true;
            this.lbMayor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMayor.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMayor.Location = new System.Drawing.Point(168, 157);
            this.lbMayor.Name = "lbMayor";
            this.lbMayor.Size = new System.Drawing.Size(199, 28);
            this.lbMayor.TabIndex = 3;
            this.lbMayor.Text = "El numero mayor es:";
            // 
            // lbMenor
            // 
            this.lbMenor.AutoSize = true;
            this.lbMenor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMenor.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenor.Location = new System.Drawing.Point(168, 184);
            this.lbMenor.Name = "lbMenor";
            this.lbMenor.Size = new System.Drawing.Size(200, 28);
            this.lbMenor.TabIndex = 4;
            this.lbMenor.Text = "El numero menor es:";
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPromedio.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPromedio.Location = new System.Drawing.Point(168, 210);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(153, 28);
            this.lbPromedio.TabIndex = 5;
            this.lbPromedio.Text = "El promedio es:";
            // 
            // btnVolver5
            // 
            this.btnVolver5.Location = new System.Drawing.Point(421, 73);
            this.btnVolver5.Name = "btnVolver5";
            this.btnVolver5.Size = new System.Drawing.Size(75, 23);
            this.btnVolver5.TabIndex = 6;
            this.btnVolver5.Text = "Volver";
            this.btnVolver5.UseVisualStyleBackColor = true;
            this.btnVolver5.Click += new System.EventHandler(this.btnVolver5_Click);
            // 
            // btnCalcular5
            // 
            this.btnCalcular5.Location = new System.Drawing.Point(261, 76);
            this.btnCalcular5.Name = "btnCalcular5";
            this.btnCalcular5.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular5.TabIndex = 7;
            this.btnCalcular5.Text = "Calcular";
            this.btnCalcular5.UseVisualStyleBackColor = true;
            this.btnCalcular5.Click += new System.EventHandler(this.btnCalcular5_Click);
            // 
            // Arrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 284);
            this.Controls.Add(this.btnCalcular5);
            this.Controls.Add(this.btnVolver5);
            this.Controls.Add(this.lbPromedio);
            this.Controls.Add(this.lbMenor);
            this.Controls.Add(this.lbMayor);
            this.Controls.Add(this.lbSuma);
            this.Controls.Add(this.lbIngNum5);
            this.Controls.Add(this.txtIngNum5);
            this.Name = "Arrays";
            this.Text = "Arrays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngNum5;
        private System.Windows.Forms.Label lbIngNum5;
        private System.Windows.Forms.Label lbSuma;
        private System.Windows.Forms.Label lbMayor;
        private System.Windows.Forms.Label lbMenor;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.Button btnVolver5;
        private System.Windows.Forms.Button btnCalcular5;
    }
}