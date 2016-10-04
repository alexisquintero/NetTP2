namespace UI.Desktop
{
    partial class ModulosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModulosUsuarios));
            this.tcModulosUsuarios = new System.Windows.Forms.ToolStripContainer();
            this.tlModulosUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.dgvModulosUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmodulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permiteAlta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permiteBaja = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permiteConsulta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permiteModificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsModulosUsuarios = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcModulosUsuarios.ContentPanel.SuspendLayout();
            this.tcModulosUsuarios.TopToolStripPanel.SuspendLayout();
            this.tcModulosUsuarios.SuspendLayout();
            this.tlModulosUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulosUsuarios)).BeginInit();
            this.tsModulosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcModulosUsuarios
            // 
            // 
            // tcModulosUsuarios.ContentPanel
            // 
            this.tcModulosUsuarios.ContentPanel.Controls.Add(this.tlModulosUsuarios);
            this.tcModulosUsuarios.ContentPanel.Size = new System.Drawing.Size(580, 412);
            this.tcModulosUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcModulosUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tcModulosUsuarios.Name = "tcModulosUsuarios";
            this.tcModulosUsuarios.Size = new System.Drawing.Size(580, 437);
            this.tcModulosUsuarios.TabIndex = 0;
            this.tcModulosUsuarios.Text = "toolStripContainer1";
            // 
            // tcModulosUsuarios.TopToolStripPanel
            // 
            this.tcModulosUsuarios.TopToolStripPanel.Controls.Add(this.tsModulosUsuarios);
            // 
            // tlModulosUsuarios
            // 
            this.tlModulosUsuarios.ColumnCount = 2;
            this.tlModulosUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlModulosUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlModulosUsuarios.Controls.Add(this.dgvModulosUsuarios, 0, 0);
            this.tlModulosUsuarios.Controls.Add(this.btnActualizar, 0, 1);
            this.tlModulosUsuarios.Controls.Add(this.btnSalir, 1, 1);
            this.tlModulosUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlModulosUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlModulosUsuarios.Name = "tlModulosUsuarios";
            this.tlModulosUsuarios.RowCount = 2;
            this.tlModulosUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlModulosUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlModulosUsuarios.Size = new System.Drawing.Size(580, 412);
            this.tlModulosUsuarios.TabIndex = 0;
            // 
            // dgvModulosUsuarios
            // 
            this.dgvModulosUsuarios.AllowUserToAddRows = false;
            this.dgvModulosUsuarios.AllowUserToDeleteRows = false;
            this.dgvModulosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulosUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idmodulo,
            this.idusuario,
            this.permiteAlta,
            this.permiteBaja,
            this.permiteConsulta,
            this.permiteModificacion});
            this.tlModulosUsuarios.SetColumnSpan(this.dgvModulosUsuarios, 2);
            this.dgvModulosUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModulosUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvModulosUsuarios.MultiSelect = false;
            this.dgvModulosUsuarios.Name = "dgvModulosUsuarios";
            this.dgvModulosUsuarios.ReadOnly = true;
            this.dgvModulosUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModulosUsuarios.Size = new System.Drawing.Size(574, 377);
            this.dgvModulosUsuarios.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // idmodulo
            // 
            this.idmodulo.DataPropertyName = "IDModulo";
            this.idmodulo.HeaderText = "ID Modulo";
            this.idmodulo.Name = "idmodulo";
            this.idmodulo.ReadOnly = true;
            // 
            // idusuario
            // 
            this.idusuario.DataPropertyName = "IDUsuario";
            this.idusuario.HeaderText = "ID Usuario";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            // 
            // permiteAlta
            // 
            this.permiteAlta.DataPropertyName = "permiteAlta";
            this.permiteAlta.HeaderText = "Permite Alta";
            this.permiteAlta.Name = "permiteAlta";
            this.permiteAlta.ReadOnly = true;
            // 
            // permiteBaja
            // 
            this.permiteBaja.DataPropertyName = "permiteBaja";
            this.permiteBaja.HeaderText = "Permite Baja";
            this.permiteBaja.Name = "permiteBaja";
            this.permiteBaja.ReadOnly = true;
            // 
            // permiteConsulta
            // 
            this.permiteConsulta.DataPropertyName = "permiteConsulta";
            this.permiteConsulta.HeaderText = "Permite Consulta";
            this.permiteConsulta.Name = "permiteConsulta";
            this.permiteConsulta.ReadOnly = true;
            // 
            // permiteModificacion
            // 
            this.permiteModificacion.DataPropertyName = "permiteModificacion";
            this.permiteModificacion.HeaderText = "Permite Modificacion";
            this.permiteModificacion.Name = "permiteModificacion";
            this.permiteModificacion.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(421, 386);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(502, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsModulosUsuarios
            // 
            this.tsModulosUsuarios.Dock = System.Windows.Forms.DockStyle.None;
            this.tsModulosUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsModulosUsuarios.Location = new System.Drawing.Point(3, 0);
            this.tsModulosUsuarios.Name = "tsModulosUsuarios";
            this.tsModulosUsuarios.Size = new System.Drawing.Size(81, 25);
            this.tsModulosUsuarios.TabIndex = 0;
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
            // ModulosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 437);
            this.Controls.Add(this.tcModulosUsuarios);
            this.Name = "ModulosUsuarios";
            this.Text = "ModulosUsuarios";
            this.Load += new System.EventHandler(this.ModulosUsuarios_Load);
            this.tcModulosUsuarios.ContentPanel.ResumeLayout(false);
            this.tcModulosUsuarios.TopToolStripPanel.ResumeLayout(false);
            this.tcModulosUsuarios.TopToolStripPanel.PerformLayout();
            this.tcModulosUsuarios.ResumeLayout(false);
            this.tcModulosUsuarios.PerformLayout();
            this.tlModulosUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulosUsuarios)).EndInit();
            this.tsModulosUsuarios.ResumeLayout(false);
            this.tsModulosUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcModulosUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlModulosUsuarios;
        private System.Windows.Forms.DataGridView dgvModulosUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsModulosUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permiteAlta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permiteBaja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permiteConsulta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permiteModificacion;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}