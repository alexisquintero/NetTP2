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
        public Business.Entities.Especialidad EspecialidadActual;
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
            EspecialidadLogic el = new EspecialidadLogic();
            EspecialidadActual = el.GetOne(ID);
            this.MapearADatos();
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
        public virtual void MapearADatos()
        {

        }
        public virtual void GuardarCambios()
        {

        }
        public virtual bool Validar()
        {
            return false;
        }
    }
}
