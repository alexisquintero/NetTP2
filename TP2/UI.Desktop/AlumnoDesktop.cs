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
    public partial class AlumnoDesktop : ApplicationForm
    {
        public AlumnoDesktop()
        {
            InitializeComponent();
            dtpFechaNacimiento.Value = DateTime.Today;  //Para que solo aparezca la fecha y no la hora
        }
        public Business.Entities.Personas AlumnoActual { get; set; }
        public AlumnoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }
        public AlumnoDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            AlumnoActual = new PersonasLogic().GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            txtID.Text = AlumnoActual.ID.ToString();
            txtLegajo.Text = AlumnoActual.Legajo.ToString();
            txtApellido.Text = AlumnoActual.Apellido;
            txtNombre.Text = AlumnoActual.Nombre;
            txtDireccion.Text = AlumnoActual.Direccion;
            txtEmail.Text = AlumnoActual.Email;
            txtTelefono.Text = AlumnoActual.Telefono;
            dtpFechaNacimiento.Value = AlumnoActual.FechaNacimiento;

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
                AlumnoActual = new Business.Entities.Personas();
                AlumnoActual.State = Usuario.States.New;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                AlumnoActual.Legajo = Int32.Parse(txtLegajo.Text);
                AlumnoActual.Apellido = txtApellido.Text;
                AlumnoActual.Nombre = txtNombre.Text;
                AlumnoActual.Direccion = txtDireccion.Text;
                AlumnoActual.Email = txtEmail.Text;
                AlumnoActual.Telefono = txtTelefono.Text;
                AlumnoActual.FechaNacimiento = dtpFechaNacimiento.Value;
            }
            if (Modo == ModoForm.Modificacion)
            {
                AlumnoActual.State = Business.Entities.Personas.States.Modified;
            }
            if (Modo == ModoForm.Consulta)
            {
                AlumnoActual.State = Business.Entities.Personas.States.Unmodified;
            }
            if (Modo == ModoForm.Baja)
            {
                AlumnoActual.State = Business.Entities.Personas.States.Deleted;
            }
            AlumnoActual.TipoPersona = Business.Entities.Personas.TiposPersonas.Alumno;
        }
        public override bool Validar()
        {
            bool valida = false;
            string mensaje = "";

            if (txtLegajo.Text.Trim() == "")
                mensaje += "El legajo no puede estar en blanco" + "\n";
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
            new PersonasLogic().Save(AlumnoActual);
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
