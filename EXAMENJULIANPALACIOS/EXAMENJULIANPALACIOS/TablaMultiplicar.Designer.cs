namespace EXAMENJULIANPALACIOS
{
    partial class TablaMultiplicar
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
            this.txtIngNum4 = new System.Windows.Forms.TextBox();
            this.txtResultado4 = new System.Windows.Forms.TextBox();
            this.lbIngNum4 = new System.Windows.Forms.Label();
            this.btnVolver4 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIngNum4
            // 
            this.txtIngNum4.Location = new System.Drawing.Point(63, 98);
            this.txtIngNum4.Name = "txtIngNum4";
            this.txtIngNum4.Size = new System.Drawing.Size(100, 20);
            this.txtIngNum4.TabIndex = 0;
            this.txtIngNum4.TextChanged += new System.EventHandler(this.txtIngNum4_TextChanged);
            // 
            // txtResultado4
            // 
            this.txtResultado4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtResultado4.Location = new System.Drawing.Point(205, 154);
            this.txtResultado4.Multiline = true;
            this.txtResultado4.Name = "txtResultado4";
            this.txtResultado4.Size = new System.Drawing.Size(193, 161);
            this.txtResultado4.TabIndex = 1;
            this.txtResultado4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbIngNum4
            // 
            this.lbIngNum4.AutoSize = true;
            this.lbIngNum4.Location = new System.Drawing.Point(60, 82);
            this.lbIngNum4.Name = "lbIngNum4";
            this.lbIngNum4.Size = new System.Drawing.Size(83, 13);
            this.lbIngNum4.TabIndex = 2;
            this.lbIngNum4.Text = "Ingresar numero";
            // 
            // btnVolver4
            // 
            this.btnVolver4.Location = new System.Drawing.Point(443, 98);
            this.btnVolver4.Name = "btnVolver4";
            this.btnVolver4.Size = new System.Drawing.Size(75, 23);
            this.btnVolver4.TabIndex = 3;
            this.btnVolver4.Text = "Volver";
            this.btnVolver4.UseVisualStyleBackColor = true;
            this.btnVolver4.Click += new System.EventHandler(this.btnVolver4_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(260, 96);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // TablaMultiplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 401);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnVolver4);
            this.Controls.Add(this.lbIngNum4);
            this.Controls.Add(this.txtResultado4);
            this.Controls.Add(this.txtIngNum4);
            this.Name = "TablaMultiplicar";
            this.Text = "TablaMultiplicar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngNum4;
        private System.Windows.Forms.TextBox txtResultado4;
        private System.Windows.Forms.Label lbIngNum4;
        private System.Windows.Forms.Button btnVolver4;
        private System.Windows.Forms.Button btnCalcular;
    }
}