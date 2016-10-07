namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.tlCursoDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAnioCalendario = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.tlCursoDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlCursoDesktop
            // 
            this.tlCursoDesktop.ColumnCount = 2;
            this.tlCursoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlCursoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCursoDesktop.Controls.Add(this.lblID, 0, 0);
            this.tlCursoDesktop.Controls.Add(this.lblDescripcion, 0, 1);
            this.tlCursoDesktop.Controls.Add(this.lblAnioCalendario, 0, 2);
            this.tlCursoDesktop.Controls.Add(this.lblCupo, 0, 3);
            this.tlCursoDesktop.Controls.Add(this.btnAceptar, 0, 4);
            this.tlCursoDesktop.Controls.Add(this.btnCancelar, 1, 4);
            this.tlCursoDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlCursoDesktop.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlCursoDesktop.Controls.Add(this.txtAnioCalendario, 1, 2);
            this.tlCursoDesktop.Controls.Add(this.txtCupo, 1, 3);
            this.tlCursoDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCursoDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlCursoDesktop.Name = "tlCursoDesktop";
            this.tlCursoDesktop.RowCount = 5;
            this.tlCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCursoDesktop.Size = new System.Drawing.Size(329, 132);
            this.tlCursoDesktop.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(63, 6);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 32);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(3, 58);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(81, 13);
            this.lblAnioCalendario.TabIndex = 2;
            this.lblAnioCalendario.Text = "Año calendario:";
            // 
            // lblCupo
            // 
            this.lblCupo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(49, 84);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(35, 13);
            this.lblCupo.TabIndex = 3;
            this.lblCupo.Text = "Cupo:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(9, 107);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 22);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(90, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 22);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(90, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.Location = new System.Drawing.Point(90, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtAnioCalendario
            // 
            this.txtAnioCalendario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAnioCalendario.Location = new System.Drawing.Point(90, 55);
            this.txtAnioCalendario.Name = "txtAnioCalendario";
            this.txtAnioCalendario.Size = new System.Drawing.Size(100, 20);
            this.txtAnioCalendario.TabIndex = 8;
            // 
            // txtCupo
            // 
            this.txtCupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCupo.Location = new System.Drawing.Point(90, 81);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(100, 20);
            this.txtCupo.TabIndex = 9;
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 132);
            this.Controls.Add(this.tlCursoDesktop);
            this.Name = "CursoDesktop";
            this.Text = "CursoDesktop";
            this.tlCursoDesktop.ResumeLayout(false);
            this.tlCursoDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlCursoDesktop;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAnioCalendario;
        private System.Windows.Forms.TextBox txtCupo;
    }
}