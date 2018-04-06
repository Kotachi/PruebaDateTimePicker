namespace EXAMENJULIANPALACIOS
{
    partial class PrincipalBD
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
            this.components = new System.ComponentModel.Container();
            this.mnBaseDatos = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            this.rutProfesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesion1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesion2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedioEncuestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFESORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lEONESEXAMENDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lEONESEXAMENDataSet = new EXAMENJULIANPALACIOS.LEONESEXAMENDataSet();
            this.pROFESORESTableAdapter = new EXAMENJULIANPALACIOS.LEONESEXAMENDataSetTableAdapters.PROFESORESTableAdapter();
            this.mnBaseDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESEXAMENDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESEXAMENDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mnBaseDatos
            // 
            this.mnBaseDatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.volverToolStripMenuItem,
            this.actualizarToolStripMenuItem});
            this.mnBaseDatos.Location = new System.Drawing.Point(0, 0);
            this.mnBaseDatos.Name = "mnBaseDatos";
            this.mnBaseDatos.Size = new System.Drawing.Size(753, 24);
            this.mnBaseDatos.TabIndex = 0;
            this.mnBaseDatos.Text = "Menu BD";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.volverToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.volverToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.AutoGenerateColumns = false;
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutProfesorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.profesion1DataGridViewTextBoxColumn,
            this.profesion2DataGridViewTextBoxColumn,
            this.promedioEncuestaDataGridViewTextBoxColumn});
            this.dgvMostrarDatos.DataSource = this.pROFESORESBindingSource;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(36, 65);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.Size = new System.Drawing.Size(678, 322);
            this.dgvMostrarDatos.TabIndex = 1;
            // 
            // rutProfesorDataGridViewTextBoxColumn
            // 
            this.rutProfesorDataGridViewTextBoxColumn.DataPropertyName = "RutProfesor";
            this.rutProfesorDataGridViewTextBoxColumn.HeaderText = "RutProfesor";
            this.rutProfesorDataGridViewTextBoxColumn.Name = "rutProfesorDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // profesion1DataGridViewTextBoxColumn
            // 
            this.profesion1DataGridViewTextBoxColumn.DataPropertyName = "Profesion1";
            this.profesion1DataGridViewTextBoxColumn.HeaderText = "Profesion1";
            this.profesion1DataGridViewTextBoxColumn.Name = "profesion1DataGridViewTextBoxColumn";
            // 
            // profesion2DataGridViewTextBoxColumn
            // 
            this.profesion2DataGridViewTextBoxColumn.DataPropertyName = "Profesion2";
            this.profesion2DataGridViewTextBoxColumn.HeaderText = "Profesion2";
            this.profesion2DataGridViewTextBoxColumn.Name = "profesion2DataGridViewTextBoxColumn";
            // 
            // promedioEncuestaDataGridViewTextBoxColumn
            // 
            this.promedioEncuestaDataGridViewTextBoxColumn.DataPropertyName = "PromedioEncuesta";
            this.promedioEncuestaDataGridViewTextBoxColumn.HeaderText = "PromedioEncuesta";
            this.promedioEncuestaDataGridViewTextBoxColumn.Name = "promedioEncuestaDataGridViewTextBoxColumn";
            // 
            // pROFESORESBindingSource
            // 
            this.pROFESORESBindingSource.DataMember = "PROFESORES";
            this.pROFESORESBindingSource.DataSource = this.lEONESEXAMENDataSetBindingSource;
            // 
            // lEONESEXAMENDataSetBindingSource
            // 
            this.lEONESEXAMENDataSetBindingSource.DataSource = this.lEONESEXAMENDataSet;
            this.lEONESEXAMENDataSetBindingSource.Position = 0;
            // 
            // lEONESEXAMENDataSet
            // 
            this.lEONESEXAMENDataSet.DataSetName = "LEONESEXAMENDataSet";
            this.lEONESEXAMENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROFESORESTableAdapter
            // 
            this.pROFESORESTableAdapter.ClearBeforeFill = true;
            // 
            // PrincipalBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 472);
            this.Controls.Add(this.dgvMostrarDatos);
            this.Controls.Add(this.mnBaseDatos);
            this.MainMenuStrip = this.mnBaseDatos;
            this.Name = "PrincipalBD";
            this.Text = "PrincipalBD";
            this.Activated += new System.EventHandler(this.PrincipalBD_Activated);
            this.Deactivate += new System.EventHandler(this.PrincipalBD_Deactivate);
            this.Load += new System.EventHandler(this.PrincipalBD_Load);
            this.Leave += new System.EventHandler(this.PrincipalBD_Leave);
            this.mnBaseDatos.ResumeLayout(false);
            this.mnBaseDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESEXAMENDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEONESEXAMENDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnBaseDatos;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.BindingSource lEONESEXAMENDataSetBindingSource;
        private LEONESEXAMENDataSet lEONESEXAMENDataSet;
        private System.Windows.Forms.BindingSource pROFESORESBindingSource;
        private LEONESEXAMENDataSetTableAdapters.PROFESORESTableAdapter pROFESORESTableAdapter;
        public System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutProfesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesion1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesion2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedioEncuestaDataGridViewTextBoxColumn;
    }
}