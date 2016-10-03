namespace UI.Desktop
{
    partial class AlumnosInscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnosInscripciones));
            this.tcAlumnosInscripciones = new System.Windows.Forms.ToolStripContainer();
            this.tsAlumnosInscripciones = new System.Windows.Forms.ToolStrip();
            this.tlAlumnosInscripciones = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAlumnosInscripciones = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcAlumnosInscripciones.ContentPanel.SuspendLayout();
            this.tcAlumnosInscripciones.TopToolStripPanel.SuspendLayout();
            this.tcAlumnosInscripciones.SuspendLayout();
            this.tsAlumnosInscripciones.SuspendLayout();
            this.tlAlumnosInscripciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAlumnosInscripciones
            // 
            // 
            // tcAlumnosInscripciones.ContentPanel
            // 
            this.tcAlumnosInscripciones.ContentPanel.Controls.Add(this.tlAlumnosInscripciones);
            this.tcAlumnosInscripciones.ContentPanel.Size = new System.Drawing.Size(556, 404);
            this.tcAlumnosInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAlumnosInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tcAlumnosInscripciones.Name = "tcAlumnosInscripciones";
            this.tcAlumnosInscripciones.Size = new System.Drawing.Size(556, 429);
            this.tcAlumnosInscripciones.TabIndex = 0;
            this.tcAlumnosInscripciones.Text = "toolStripContainer1";
            // 
            // tcAlumnosInscripciones.TopToolStripPanel
            // 
            this.tcAlumnosInscripciones.TopToolStripPanel.Controls.Add(this.tsAlumnosInscripciones);
            // 
            // tsAlumnosInscripciones
            // 
            this.tsAlumnosInscripciones.Dock = System.Windows.Forms.DockStyle.None;
            this.tsAlumnosInscripciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsAlumnosInscripciones.Location = new System.Drawing.Point(3, 0);
            this.tsAlumnosInscripciones.Name = "tsAlumnosInscripciones";
            this.tsAlumnosInscripciones.Size = new System.Drawing.Size(112, 25);
            this.tsAlumnosInscripciones.TabIndex = 0;
            // 
            // tlAlumnosInscripciones
            // 
            this.tlAlumnosInscripciones.ColumnCount = 2;
            this.tlAlumnosInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAlumnosInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlAlumnosInscripciones.Controls.Add(this.dgvAlumnosInscripciones, 0, 0);
            this.tlAlumnosInscripciones.Controls.Add(this.btnActualizar, 0, 1);
            this.tlAlumnosInscripciones.Controls.Add(this.btnSalir, 1, 1);
            this.tlAlumnosInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlAlumnosInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tlAlumnosInscripciones.Name = "tlAlumnosInscripciones";
            this.tlAlumnosInscripciones.RowCount = 2;
            this.tlAlumnosInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAlumnosInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAlumnosInscripciones.Size = new System.Drawing.Size(556, 404);
            this.tlAlumnosInscripciones.TabIndex = 0;
            // 
            // dgvAlumnosInscripciones
            // 
            this.dgvAlumnosInscripciones.AllowUserToAddRows = false;
            this.dgvAlumnosInscripciones.AllowUserToDeleteRows = false;
            this.dgvAlumnosInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.condicion,
            this.idAlumno,
            this.idCurso,
            this.nota});
            this.tlAlumnosInscripciones.SetColumnSpan(this.dgvAlumnosInscripciones, 2);
            this.dgvAlumnosInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnosInscripciones.Location = new System.Drawing.Point(3, 3);
            this.dgvAlumnosInscripciones.Name = "dgvAlumnosInscripciones";
            this.dgvAlumnosInscripciones.ReadOnly = true;
            this.dgvAlumnosInscripciones.Size = new System.Drawing.Size(550, 369);
            this.dgvAlumnosInscripciones.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(397, 378);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(478, 378);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // condicion
            // 
            this.condicion.DataPropertyName = "Condicion";
            this.condicion.HeaderText = "Condicion";
            this.condicion.Name = "condicion";
            this.condicion.ReadOnly = true;
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "IDAlumno";
            this.idAlumno.HeaderText = "ID Alumno";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            // 
            // idCurso
            // 
            this.idCurso.DataPropertyName = "IDCurso";
            this.idCurso.HeaderText = "ID Curso";
            this.idCurso.Name = "idCurso";
            this.idCurso.ReadOnly = true;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "Nota";
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // AlumnosInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 429);
            this.Controls.Add(this.tcAlumnosInscripciones);
            this.Name = "AlumnosInscripciones";
            this.Text = "AlumnosInscripciones";
            this.Load += new System.EventHandler(this.AlumnosInscripciones_Load);
            this.tcAlumnosInscripciones.ContentPanel.ResumeLayout(false);
            this.tcAlumnosInscripciones.TopToolStripPanel.ResumeLayout(false);
            this.tcAlumnosInscripciones.TopToolStripPanel.PerformLayout();
            this.tcAlumnosInscripciones.ResumeLayout(false);
            this.tcAlumnosInscripciones.PerformLayout();
            this.tsAlumnosInscripciones.ResumeLayout(false);
            this.tsAlumnosInscripciones.PerformLayout();
            this.tlAlumnosInscripciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosInscripciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcAlumnosInscripciones;
        private System.Windows.Forms.TableLayoutPanel tlAlumnosInscripciones;
        private System.Windows.Forms.DataGridView dgvAlumnosInscripciones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsAlumnosInscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}