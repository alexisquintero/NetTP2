using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public Usuario UsuarioActual { get; set; }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
            }
            if (Modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";
            }
        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                UsuarioActual = new Usuario();
                UsuarioActual.State = Usuario.States.New;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.Email = this.txtEmail.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
            }
            if (Modo == ModoForm.Modificacion)
            {
                UsuarioActual.State = Usuario.States.Modified;
            }
            if (Modo == ModoForm.Consulta)
            {
                UsuarioActual.State = Usuario.States.Unmodified;
            }
            if (Modo == ModoForm.Baja)
            {
                UsuarioActual.State = Usuario.States.Deleted;
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            new UsuarioLogic().Save(UsuarioActual);
        }
        public override bool Validar()
        {
            bool valida = false;
            string mensaje = "";

            if (txtNombre.Text.Trim() == "")
                mensaje += "El nombre no puede estar en blanco" + "\n";
            if (txtApellido.Text.Trim() == "")
                mensaje += "El apellido no puede estar en blanco" + "\n";
            if (txtClave.Text.Length < 8)
                mensaje += "La clave debe contener al menos 8 caracteres" + "\n";
            if (txtUsuario.Text.Trim() == "")
                mensaje += "El usuario no puede estar en blanco" + "\n";
            if (txtEmail.Text.Trim() == "")
                mensaje += "El email no puede estar en blanco" + "\n";
            if (txtClave.Text.Trim() == "")
                mensaje += "La clave no puede estar en blanco" + "\n";
            if (txtConfirmarClave.Text.Trim() == "")
                mensaje += "Confirmar clave no puede estar en blanco" + "\n";
            if (txtClave.Text.Trim() != txtConfirmarClave.Text.Trim())
                mensaje += "Las claves no coinciden" + "\n";

            if (!String.IsNullOrEmpty(mensaje))
            {
                this.Notificar(mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                valida = true;
            }
            return valida;

        }
        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }
        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;           
            UsuarioActual = new UsuarioLogic().GetOne(ID);
            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
