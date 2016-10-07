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
    public partial class CursoDesktop : ApplicationForm
    {
        public CursoDesktop()
        {
            InitializeComponent();
        }
        public Curso CursoActual { get; set; }
        public CursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }
        public CursoDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            CursoActual = new CursoLogic().GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            txtID.Text = CursoActual.ID.ToString();
            txtDescripcion.Text = CursoActual.Descripcion;
            txtAnioCalendario.Text = CursoActual.AnioCalendario.ToString();
            txtCupo.Text = CursoActual.Cupo.ToString();

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
                CursoActual = new Curso();
                CursoActual.State = Curso.States.New;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                CursoActual.Descripcion = txtDescripcion.Text;
                CursoActual.AnioCalendario = Int32.Parse(txtAnioCalendario.Text);
                CursoActual.Cupo = Int32.Parse(txtCupo.Text);
            }
            if (Modo == ModoForm.Modificacion)
            {
                CursoActual.State = Curso.States.Modified;
            }
            if (Modo == ModoForm.Consulta)
            {
                CursoActual.State = Curso.States.Unmodified;
            }
            if (Modo == ModoForm.Baja)
            {
                CursoActual.State = Curso.States.Deleted;
            }
        }
        public override bool Validar()
        {
            bool valida = false;
            string mensaje = "";

            if (txtDescripcion.Text.Trim() == "")
                mensaje += "La descripció no puede estar en blanco" + "\n";
            if (txtAnioCalendario.Text.Trim() == "")
                mensaje += "El año calendario no puede estar en blanco" + "\n";
            if (txtCupo.Text.Trim() == "")
                mensaje += "El cupo no puede estar en blanco" + "\n";

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
            new CursoLogic().Save(CursoActual);
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
