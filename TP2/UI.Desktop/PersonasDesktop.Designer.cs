namespace UI.Desktop
{
    partial class PersonasDesktop
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
            this.tlPersonasDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.cbTipoPersona = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlPersonasDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPersonasDesktop
            // 
            this.tlPersonasDesktop.ColumnCount = 4;
            this.tlPersonasDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPersonasDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPersonasDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPersonasDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPersonasDesktop.Controls.Add(this.lblApellido, 0, 0);
            this.tlPersonasDesktop.Controls.Add(this.lblNombre, 2, 0);
            this.tlPersonasDesktop.Controls.Add(this.lblDireccion, 0, 1);
            this.tlPersonasDesktop.Controls.Add(this.lblEmail, 2, 1);
            this.tlPersonasDesktop.Controls.Add(this.lblFechaNacimiento, 0, 2);
            this.tlPersonasDesktop.Controls.Add(this.lblPlan, 2, 2);
            this.tlPersonasDesktop.Controls.Add(this.lblLegajo, 0, 3);
            this.tlPersonasDesktop.Controls.Add(this.lblTelefono, 2, 3);
            this.tlPersonasDesktop.Controls.Add(this.lblTipoPersona, 0, 4);
            this.tlPersonasDesktop.Controls.Add(this.txtApellido, 1, 0);
            this.tlPersonasDesktop.Controls.Add(this.txtNombre, 3, 0);
            this.tlPersonasDesktop.Controls.Add(this.txtDireccion, 1, 1);
            this.tlPersonasDesktop.Controls.Add(this.txtEmail, 3, 1);
            this.tlPersonasDesktop.Controls.Add(this.txtLegajo, 1, 3);
            this.tlPersonasDesktop.Controls.Add(this.txtTelefono, 3, 3);
            this.tlPersonasDesktop.Controls.Add(this.cbPlan, 3, 2);
            this.tlPersonasDesktop.Controls.Add(this.cbTipoPersona, 1, 4);
            this.tlPersonasDesktop.Controls.Add(this.dtpFechaNacimiento, 1, 2);
            this.tlPersonasDesktop.Controls.Add(this.btnAceptar, 2, 5);
            this.tlPersonasDesktop.Controls.Add(this.btnCancelar, 3, 5);
            this.tlPersonasDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPersonasDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlPersonasDesktop.Name = "tlPersonasDesktop";
            this.tlPersonasDesktop.RowCount = 6;
            this.tlPersonasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPersonasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPersonasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPersonasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPersonasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPersonasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPersonasDesktop.Size = new System.Drawing.Size(613, 165);
            this.tlPersonasDesktop.TabIndex = 0;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(65, 6);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(354, 6);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "nombre:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(57, 32);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(364, 32);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(3, 59);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            this.lblFechaNacimiento.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(368, 59);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(31, 13);
            this.lblPlan.TabIndex = 5;
            this.lblPlan.Text = "Plan:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(70, 85);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 13);
            this.lblLegajo.TabIndex = 6;
            this.lblLegajo.Text = "Legajo:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(347, 85);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Location = new System.Drawing.Point(39, 112);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(73, 13);
            this.lblTipoPersona.TabIndex = 8;
            this.lblTipoPersona.Text = "Tipo Persona:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(118, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(405, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(118, 29);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(405, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(118, 82);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 13;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(405, 82);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // cbPlan
            // 
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(405, 55);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(121, 21);
            this.cbPlan.TabIndex = 15;
            // 
            // cbTipoPersona
            // 
            this.cbTipoPersona.FormattingEnabled = true;
            this.cbTipoPersona.Location = new System.Drawing.Point(118, 108);
            this.cbTipoPersona.Name = "cbTipoPersona";
            this.cbTipoPersona.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPersona.TabIndex = 16;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(118, 55);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 17;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(324, 135);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(405, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PersonasDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 165);
            this.Controls.Add(this.tlPersonasDesktop);
            this.Name = "PersonasDesktop";
            this.Text = "PersonasDesktop";
            this.tlPersonasDesktop.ResumeLayout(false);
            this.tlPersonasDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPersonasDesktop;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.ComboBox cbTipoPersona;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}