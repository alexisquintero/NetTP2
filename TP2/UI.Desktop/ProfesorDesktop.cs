using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class ProfesorDesktop : ApplicationForm
    {
        public ProfesorDesktop()
        {
            InitializeComponent();
            dtpFechaNacimiento.Value = DateTime.Today;
        }
        public Business.Entities.Personas ProfesorActual { get; set; }
        public ProfesorDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }
        public ProfesorDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            ProfesorActual = new ProfesorLogic().GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            txtID.Text = ProfesorActual.ID.ToString();
            txtApellido.Text = ProfesorActual.Apellido;
            txtNombre.Text = ProfesorActual.Nombre;
            txtDireccion.Text = ProfesorActual.Direccion;
            txtEmail.Text = ProfesorActual.Email;
            txtTelefono.Text = ProfesorActual.Telefono;
            dtpFechaNacimiento.Value = ProfesorActual.FechaNacimiento;

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
                ProfesorActual = new Business.Entities.Personas();
                ProfesorActual.State = Usuario.States.New;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                ProfesorActual.Apellido = txtApellido.Text;
                ProfesorActual.Nombre = txtNombre.Text;
                ProfesorActual.Direccion = txtDireccion.Text;
                ProfesorActual.Email = txtEmail.Text;
                ProfesorActual.Telefono = txtTelefono.Text;
                ProfesorActual.FechaNacimiento = dtpFechaNacimiento.Value;
            }
            if (Modo == ModoForm.Modificacion)
            {
                ProfesorActual.State = Business.Entities.Personas.States.Modified;
            }
            if (Modo == ModoForm.Consulta)
            {
                ProfesorActual.State = Business.Entities.Personas.States.Unmodified;
            }
            if (Modo == ModoForm.Baja)
            {
                ProfesorActual.State = Business.Entities.Personas.States.Deleted;
            }                      
        }
        public override bool Validar()
        {
            bool valida = false;
            string mensaje = "";

            if (txtNombre.Text.Trim() == "")
                mensaje += "El nombre no puede estar en blanco" + "\n";
            if (txtApellido.Text.Trim() == "")
                mensaje += "El apellido no puede estar en blanco" + "\n";
            if (txtDireccion.Text.Trim() == "")
                mensaje += "La dirección no puede estar en blanco" + "\n";
            if (txtEmail.Text.Trim() == "")
                mensaje += "El email no puede estar en blanco" + "\n";
            if (txtTelefono.Text.Trim() == "")
                mensaje += "El teléfono no puede estar en blanco" + "\n";
            if (dtpFechaNacimiento.Value == DateTime.Today)
                mensaje += "La fecha de nacimiento no puede ser hoy" + "\n";
            if (dtpFechaNacimiento.Value > DateTime.Today)
                mensaje += "La fecha de nacimiento no puede ser mayor a hoy" + "\n";

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
        public override void GuardarCambios()
        {
            MapearADatos();
            new PersonasLogic().Save(ProfesorActual);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
