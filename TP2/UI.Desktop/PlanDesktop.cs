using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
        }
        public Plan PlanActual { get; set; }
        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }
        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            PlanActual = new PlanLogic().GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            txtID.Text = PlanActual.ID.ToString();
            txtDescripcion.Text = PlanActual.Descripcion;

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
                PlanActual = new Plan();
                PlanActual.State = Usuario.States.New;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                PlanActual.Descripcion = txtDescripcion.Text;
            }
            if (Modo == ModoForm.Modificacion)
            {
                PlanActual.State = Usuario.States.Modified;
            }
            if (Modo == ModoForm.Consulta)
            {
                PlanActual.State = Usuario.States.Unmodified;
            }
            if (Modo == ModoForm.Baja)
            {
                PlanActual.State = Usuario.States.Deleted;
            }
        }
        public override bool Validar()
        {
            bool valida = false;
            string mensaje = "";

            if (txtDescripcion.Text.Trim() == "")
                mensaje += "La descripcion no puede estar en blanco" + "\n";            

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
            new PlanLogic().Save(PlanActual);
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
