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
    public partial class EspecialidadDesktop : ApplicationForm
    {
        public Especialidad EspecialidadActual { get; set; }
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }
        public EspecialidadDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;           
        }
        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            EspecialidadActual = new EspecialidadLogic().GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;

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
            if(Modo == ModoForm.Alta)
            {
                EspecialidadActual = new Especialidad();
                EspecialidadActual.State = Especialidad.States.New;
            }
            if(Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                EspecialidadActual.Descripcion = txtDescripcion.Text;
            }
            if (Modo == ModoForm.Modificacion)
            {
                EspecialidadActual.State = Especialidad.States.Modified;
            }
            if (Modo == ModoForm.Consulta)
            {
                EspecialidadActual.State = Especialidad.States.Unmodified;
            }
            if (Modo == ModoForm.Baja)
            {
                EspecialidadActual.State = Especialidad.States.Deleted;
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            new EspecialidadLogic().Save(EspecialidadActual);
        }
        public override bool Validar()
        {
            bool valida = false;
            string mensaje = "";
            if(txtDescripcion.Text.Trim() == "")
            {
                mensaje += "La descripción no puede esta en blanco" + "\n";
            }
            if (!string.IsNullOrEmpty(mensaje))
            {
                this.Notificar(mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                valida = true;
            }
            return valida;
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
