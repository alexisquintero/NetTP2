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
    public partial class ComisionDesktop : ApplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();
        }
        public Comision ComisionActual { get; set; }
        public ComisionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }
        public ComisionDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            ComisionActual = new ComisionLogic().GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            txtID.Text = ComisionActual.ID.ToString();
            txtDescripcion.Text = ComisionActual.Descripcion;
            txtAnioDeEspecialidad.Text = ComisionActual.AnioEspecialidad.ToString();

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
                ComisionActual = new Comision();
                ComisionActual.State = Comision.States.New;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                ComisionActual.Descripcion = txtDescripcion.Text;
                ComisionActual.AnioEspecialidad = Int32.Parse(txtAnioDeEspecialidad.Text);
            }
            if (Modo == ModoForm.Modificacion)
            {
                ComisionActual.State = Comision.States.Modified;
            }
            if (Modo == ModoForm.Consulta)
            {
                ComisionActual.State = Comision.States.Unmodified;
            }
            if (Modo == ModoForm.Baja)
            {
                ComisionActual.State = Comision.States.Deleted;
            }
        }
        public override bool Validar()
        {
            bool valida = false;
            string mensaje = "";

            if (txtDescripcion.Text.Trim() == "")
                mensaje += "La descripcion no puede estar en blanco" + "\n";
            if (txtAnioDeEspecialidad.Text.Trim() == "")
                mensaje += "El año de especialidad no puede estar en blanco" + "\n";            

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
            new ComisionLogic().Save(ComisionActual);
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
