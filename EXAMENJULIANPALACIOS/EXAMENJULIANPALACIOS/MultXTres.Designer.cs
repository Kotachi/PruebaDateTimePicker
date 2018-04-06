namespace EXAMENJULIANPALACIOS
{
    partial class MultXTres
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
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.txtIngNumXTres = new System.Windows.Forms.TextBox();
            this.lbIngNumero = new System.Windows.Forms.Label();
            this.lbResultXTres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver2
            // 
            this.btnVolver2.Location = new System.Drawing.Point(313, 78);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(75, 23);
            this.btnVolver2.TabIndex = 0;
            this.btnVolver2.Text = "Volver";
            this.btnVolver2.UseVisualStyleBackColor = true;
            this.btnVolver2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIngNumXTres
            // 
            this.txtIngNumXTres.Location = new System.Drawing.Point(65, 81);
            this.txtIngNumXTres.Name = "txtIngNumXTres";
            this.txtIngNumXTres.Size = new System.Drawing.Size(100, 20);
            this.txtIngNumXTres.TabIndex = 1;
            this.txtIngNumXTres.TextChanged += new System.EventHandler(this.txtIngNumXTres_TextChanged);
            // 
            // lbIngNumero
            // 
            this.lbIngNumero.AutoSize = true;
            this.lbIngNumero.Location = new System.Drawing.Point(62, 65);
            this.lbIngNumero.Name = "lbIngNumero";
            this.lbIngNumero.Size = new System.Drawing.Size(95, 13);
            this.lbIngNumero.TabIndex = 2;
            this.lbIngNumero.Text = "Ingrese un numero";
            // 
            // lbResultXTres
            // 
            this.lbResultXTres.AutoSize = true;
            this.lbResultXTres.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbResultXTres.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultXTres.Location = new System.Drawing.Point(62, 169);
            this.lbResultXTres.Name = "lbResultXTres";
            this.lbResultXTres.Size = new System.Drawing.Size(103, 26);
            this.lbResultXTres.TabIndex = 3;
            this.lbResultXTres.Text = "Respuesta";
            // 
            // MultXTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 340);
            this.Controls.Add(this.lbResultXTres);
            this.Controls.Add(this.lbIngNumero);
            this.Controls.Add(this.txtIngNumXTres);
            this.Controls.Add(this.btnVolver2);
            this.Name = "MultXTres";
            this.Text = "MultXTres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver2;
        private System.Windows.Forms.TextBox txtIngNumXTres;
        private System.Windows.Forms.Label lbIngNumero;
        private System.Windows.Forms.Label lbResultXTres;
    }
}