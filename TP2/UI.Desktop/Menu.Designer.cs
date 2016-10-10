namespace UI.Desktop
{
    partial class Menu
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
            this.tcMenu = new System.Windows.Forms.ToolStripContainer();
            this.tlMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnAlumnoInscripcion = new System.Windows.Forms.Button();
            this.btnComision = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.btnDocenteCurso = new System.Windows.Forms.Button();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.btnMateria = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnModuloUsuario = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnPlan = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.tcMenu.ContentPanel.SuspendLayout();
            this.tcMenu.SuspendLayout();
            this.tlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMenu
            // 
            // 
            // tcMenu.ContentPanel
            // 
            this.tcMenu.ContentPanel.Controls.Add(this.tlMenu);
            this.tcMenu.ContentPanel.Size = new System.Drawing.Size(369, 258);
            this.tcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMenu.Location = new System.Drawing.Point(0, 0);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.Size = new System.Drawing.Size(369, 283);
            this.tcMenu.TabIndex = 0;
            this.tcMenu.Text = "toolStripContainer1";
            // 
            // tlMenu
            // 
            this.tlMenu.ColumnCount = 2;
            this.tlMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMenu.Controls.Add(this.btnAlumnoInscripcion, 0, 0);
            this.tlMenu.Controls.Add(this.btnComision, 1, 0);
            this.tlMenu.Controls.Add(this.btnCurso, 0, 1);
            this.tlMenu.Controls.Add(this.btnDocenteCurso, 1, 1);
            this.tlMenu.Controls.Add(this.btnEspecialidad, 0, 2);
            this.tlMenu.Controls.Add(this.btnMateria, 1, 2);
            this.tlMenu.Controls.Add(this.btnModulo, 0, 3);
            this.tlMenu.Controls.Add(this.btnModuloUsuario, 1, 3);
            this.tlMenu.Controls.Add(this.btnPersona, 0, 4);
            this.tlMenu.Controls.Add(this.btnPlan, 1, 4);
            this.tlMenu.Controls.Add(this.btnUsuario, 0, 5);
            this.tlMenu.Controls.Add(this.btnSalir, 1, 6);
            this.tlMenu.Controls.Add(this.btnAlumno, 1, 5);
            this.tlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMenu.Location = new System.Drawing.Point(0, 0);
            this.tlMenu.Name = "tlMenu";
            this.tlMenu.RowCount = 7;
            this.tlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMenu.Size = new System.Drawing.Size(369, 258);
            this.tlMenu.TabIndex = 0;
            // 
            // btnAlumnoInscripcion
            // 
            this.btnAlumnoInscripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlumnoInscripcion.Location = new System.Drawing.Point(54, 3);
            this.btnAlumnoInscripcion.Name = "btnAlumnoInscripcion";
            this.btnAlumnoInscripcion.Size = new System.Drawing.Size(75, 23);
            this.btnAlumnoInscripcion.TabIndex = 0;
            this.btnAlumnoInscripcion.Text = "AlumnoInscripcion";
            this.btnAlumnoInscripcion.UseVisualStyleBackColor = true;
            this.btnAlumnoInscripcion.Click += new System.EventHandler(this.btnAlumnoInscripcion_Click);
            // 
            // btnComision
            // 
            this.btnComision.Location = new System.Drawing.Point(187, 3);
            this.btnComision.Name = "btnComision";
            this.btnComision.Size = new System.Drawing.Size(75, 23);
            this.btnComision.TabIndex = 1;
            this.btnComision.Text = "Comision";
            this.btnComision.UseVisualStyleBackColor = true;
            this.btnComision.Click += new System.EventHandler(this.btnComision_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCurso.Location = new System.Drawing.Point(54, 32);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(75, 23);
            this.btnCurso.TabIndex = 2;
            this.btnCurso.Text = "Curso";
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // btnDocenteCurso
            // 
            this.btnDocenteCurso.Location = new System.Drawing.Point(187, 32);
            this.btnDocenteCurso.Name = "btnDocenteCurso";
            this.btnDocenteCurso.Size = new System.Drawing.Size(75, 23);
            this.btnDocenteCurso.TabIndex = 3;
            this.btnDocenteCurso.Text = "DocenteCurso";
            this.btnDocenteCurso.UseVisualStyleBackColor = true;
            this.btnDocenteCurso.Click += new System.EventHandler(this.btnDocenteCurso_Click);
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEspecialidad.Location = new System.Drawing.Point(54, 61);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Size = new System.Drawing.Size(75, 23);
            this.btnEspecialidad.TabIndex = 4;
            this.btnEspecialidad.Text = "Especialidad";
            this.btnEspecialidad.UseVisualStyleBackColor = true;
            this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.Location = new System.Drawing.Point(187, 61);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(75, 23);
            this.btnMateria.TabIndex = 5;
            this.btnMateria.Text = "Materia";
            this.btnMateria.UseVisualStyleBackColor = true;
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModulo.Location = new System.Drawing.Point(54, 90);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(75, 23);
            this.btnModulo.TabIndex = 6;
            this.btnModulo.Text = "Modulo";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnModuloUsuario
            // 
            this.btnModuloUsuario.Location = new System.Drawing.Point(187, 90);
            this.btnModuloUsuario.Name = "btnModuloUsuario";
            this.btnModuloUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnModuloUsuario.TabIndex = 7;
            this.btnModuloUsuario.Text = "ModuloUsuario";
            this.btnModuloUsuario.UseVisualStyleBackColor = true;
            this.btnModuloUsuario.Click += new System.EventHandler(this.btnModuloUsuario_Click);
            // 
            // btnPersona
            // 
            this.btnPersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPersona.Location = new System.Drawing.Point(54, 119);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(75, 23);
            this.btnPersona.TabIndex = 8;
            this.btnPersona.Text = "Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.Location = new System.Drawing.Point(187, 119);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(75, 23);
            this.btnPlan.TabIndex = 9;
            this.btnPlan.Text = "Plan";
            this.btnPlan.UseVisualStyleBackColor = true;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuario.Location = new System.Drawing.Point(54, 148);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnUsuario.TabIndex = 10;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(291, 177);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(187, 148);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnAlumno.TabIndex = 12;
            this.btnAlumno.Text = "Alumno";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 283);
            this.Controls.Add(this.tcMenu);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.tcMenu.ContentPanel.ResumeLayout(false);
            this.tcMenu.ResumeLayout(false);
            this.tcMenu.PerformLayout();
            this.tlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcMenu;
        private System.Windows.Forms.TableLayoutPanel tlMenu;
        private System.Windows.Forms.Button btnAlumnoInscripcion;
        private System.Windows.Forms.Button btnComision;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.Button btnDocenteCurso;
        private System.Windows.Forms.Button btnEspecialidad;
        private System.Windows.Forms.Button btnMateria;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnModuloUsuario;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAlumno;
    }
}