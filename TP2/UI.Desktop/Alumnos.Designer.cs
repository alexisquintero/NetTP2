﻿namespace UI.Desktop
{
    partial class Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));
            this.tcAlumnos = new System.Windows.Forms.ToolStripContainer();
            this.tlAlumnos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsAlumnos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcAlumnos.ContentPanel.SuspendLayout();
            this.tcAlumnos.TopToolStripPanel.SuspendLayout();
            this.tcAlumnos.SuspendLayout();
            this.tlAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.tsAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAlumnos
            // 
            // 
            // tcAlumnos.ContentPanel
            // 
            this.tcAlumnos.ContentPanel.Controls.Add(this.tlAlumnos);
            this.tcAlumnos.ContentPanel.Size = new System.Drawing.Size(914, 386);
            this.tcAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAlumnos.Location = new System.Drawing.Point(0, 0);
            this.tcAlumnos.Name = "tcAlumnos";
            this.tcAlumnos.Size = new System.Drawing.Size(914, 411);
            this.tcAlumnos.TabIndex = 0;
            this.tcAlumnos.Text = "toolStripContainer1";
            // 
            // tcAlumnos.TopToolStripPanel
            // 
            this.tcAlumnos.TopToolStripPanel.Controls.Add(this.tsAlumnos);
            // 
            // tlAlumnos
            // 
            this.tlAlumnos.ColumnCount = 2;
            this.tlAlumnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAlumnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlAlumnos.Controls.Add(this.dgvAlumnos, 0, 0);
            this.tlAlumnos.Controls.Add(this.btnActualizar, 0, 1);
            this.tlAlumnos.Controls.Add(this.btnSalir, 1, 1);
            this.tlAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlAlumnos.Location = new System.Drawing.Point(0, 0);
            this.tlAlumnos.Name = "tlAlumnos";
            this.tlAlumnos.RowCount = 2;
            this.tlAlumnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAlumnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAlumnos.Size = new System.Drawing.Size(914, 386);
            this.tlAlumnos.TabIndex = 0;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.legajo,
            this.apellido,
            this.nombre,
            this.direccion,
            this.email,
            this.telefono,
            this.fechaNacimiento,
            this.idPlan});
            this.tlAlumnos.SetColumnSpan(this.dgvAlumnos, 2);
            this.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnos.Location = new System.Drawing.Point(3, 3);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.Size = new System.Drawing.Size(908, 351);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(755, 360);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(836, 360);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsAlumnos
            // 
            this.tsAlumnos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsAlumnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsAlumnos.Location = new System.Drawing.Point(3, 0);
            this.tsAlumnos.Name = "tsAlumnos";
            this.tsAlumnos.Size = new System.Drawing.Size(81, 25);
            this.tsAlumnos.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // legajo
            // 
            this.legajo.DataPropertyName = "Legajo";
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "Apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "Direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // idPlan
            // 
            this.idPlan.DataPropertyName = "IDPlan";
            this.idPlan.HeaderText = "ID Plan";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 411);
            this.Controls.Add(this.tcAlumnos);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.tcAlumnos.ContentPanel.ResumeLayout(false);
            this.tcAlumnos.TopToolStripPanel.ResumeLayout(false);
            this.tcAlumnos.TopToolStripPanel.PerformLayout();
            this.tcAlumnos.ResumeLayout(false);
            this.tcAlumnos.PerformLayout();
            this.tlAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.tsAlumnos.ResumeLayout(false);
            this.tsAlumnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcAlumnos;
        private System.Windows.Forms.ToolStrip tsAlumnos;
        private System.Windows.Forms.TableLayoutPanel tlAlumnos;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
    }
}