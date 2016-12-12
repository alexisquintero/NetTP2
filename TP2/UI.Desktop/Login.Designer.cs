namespace UI.Desktop
{
    partial class Login
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
            this.tlLogin = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.tlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlLogin
            // 
            this.tlLogin.ColumnCount = 2;
            this.tlLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlLogin.Controls.Add(this.lblUsuario, 0, 0);
            this.tlLogin.Controls.Add(this.lblContrasenia, 0, 1);
            this.tlLogin.Controls.Add(this.txtUsuario, 1, 0);
            this.tlLogin.Controls.Add(this.txtContrasenia, 1, 1);
            this.tlLogin.Controls.Add(this.btnIngresar, 1, 2);
            this.tlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlLogin.Location = new System.Drawing.Point(0, 0);
            this.tlLogin.Name = "tlLogin";
            this.tlLogin.RowCount = 3;
            this.tlLogin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlLogin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlLogin.Size = new System.Drawing.Size(217, 83);
            this.tlLogin.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(21, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(3, 32);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(64, 13);
            this.lblContrasenia.TabIndex = 1;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuario.Location = new System.Drawing.Point(73, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtContrasenia.Location = new System.Drawing.Point(73, 29);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenia.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(73, 55);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 83);
            this.Controls.Add(this.tlLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.tlLogin.ResumeLayout(false);
            this.tlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnIngresar;
    }
}