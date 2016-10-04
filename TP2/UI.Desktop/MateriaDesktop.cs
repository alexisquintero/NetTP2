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
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();
        }
        public Materia MateriaActual { get; set; }
        public MateriaDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }
        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            MateriaActual = new MateriaLogic().GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            txtID.Text = MateriaActual.ID.ToString();
            txtDescripcion.Text = MateriaActual.Descripcion;
            txtHorasSemanales.Text = MateriaActual.HSSemanales.ToString();
            txtHorasTotales.Text = MateriaActual.HSTotales.ToString();

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
                MateriaActual = new Materia();
                MateriaActual.State = Materia.States.New;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                MateriaActual.Descripcion = txtDescripcion.Text;
                MateriaActual.HSSemanales = Int32.Parse(txtHorasSemanales.Text);
                MateriaActual.HSTotales = Int32.Parse(txtHorasTotales.Text);
            }
            if (Modo == ModoForm.Modificacion)
            {
                MateriaActual.State = Materia.States.Modified;
            }
            if (Modo == ModoForm.Consulta)
            {
                MateriaActual.State = Materia.States.Unmodified;
            }
            if (Modo == ModoForm.Baja)
            {
                MateriaActual.State = Materia.States.Deleted;
            }
        }
        public override bool Validar()
        {
            bool valida = false;
            string mensaje = "";

            if (txtDescripcion.Text.Trim() == "")
                mensaje += "La descripcion no puede estar en blanco" + "\n";
            if (txtHorasSemanales.Text.Trim() == "")
                mensaje += "Las horas semanales no pueden estar en blanco" + "\n";
            if (txtHorasTotales.Text.Trim() == "")
                mensaje += "Las horas totales no pueden estar en blanco" + "\n";

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
            new MateriaLogic().Save(MateriaActual);
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
