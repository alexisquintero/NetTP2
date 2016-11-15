namespace UI.Desktop
{
    partial class Inscripcion
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
            this.tlpInscripcion = new System.Windows.Forms.TableLayoutPanel();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cbComision = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.tlpInscripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpInscripcion
            // 
            this.tlpInscripcion.ColumnCount = 4;
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInscripcion.Controls.Add(this.cbMateria, 3, 0);
            this.tlpInscripcion.Controls.Add(this.lblComision, 0, 0);
            this.tlpInscripcion.Controls.Add(this.lblMateria, 2, 0);
            this.tlpInscripcion.Controls.Add(this.cbComision, 1, 0);
            this.tlpInscripcion.Controls.Add(this.lblCurso, 0, 1);
            this.tlpInscripcion.Controls.Add(this.cbCurso, 1, 1);
            this.tlpInscripcion.Controls.Add(this.btnAceptar, 2, 2);
            this.tlpInscripcion.Controls.Add(this.btnCancelar, 3, 2);
            this.tlpInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInscripcion.Location = new System.Drawing.Point(0, 0);
            this.tlpInscripcion.Name = "tlpInscripcion";
            this.tlpInscripcion.RowCount = 3;
            this.tlpInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInscripcion.Size = new System.Drawing.Size(398, 82);
            this.tlpInscripcion.TabIndex = 0;
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(269, 3);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(121, 21);
            this.cbMateria.TabIndex = 0;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // lblComision
            // 
            this.lblComision.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(3, 7);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(52, 13);
            this.lblComision.TabIndex = 3;
            this.lblComision.Text = "Comisión:";
            // 
            // lblMateria
            // 
            this.lblMateria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(218, 7);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(45, 13);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia:";
            // 
            // cbComision
            // 
            this.cbComision.FormattingEnabled = true;
            this.cbComision.Location = new System.Drawing.Point(61, 3);
            this.cbComision.Name = "cbComision";
            this.cbComision.Size = new System.Drawing.Size(121, 21);
            this.cbComision.TabIndex = 1;
            this.cbComision.SelectedIndexChanged += new System.EventHandler(this.cbComision_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(188, 57);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 22);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(269, 57);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 22);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(18, 34);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 6;
            this.lblCurso.Text = "Curso:";
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(61, 30);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(121, 21);
            this.cbCurso.TabIndex = 7;
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 82);
            this.Controls.Add(this.tlpInscripcion);
            this.Name = "Inscripcion";
            this.Text = "Inscripcion";
            this.tlpInscripcion.ResumeLayout(false);
            this.tlpInscripcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpInscripcion;
        private System.Windows.Forms.ComboBox cbComision;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cbCurso;
    }
}