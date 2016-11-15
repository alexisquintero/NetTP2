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
    public partial class Inscripcion : ApplicationForm
    {
        private bool flagComision = false;
        private bool flagMateria = false;
        public Inscripcion()
        {
            InitializeComponent();
            this.CargaComisiones();
            CargaMaterias();
            CargaComisiones();
        }
        private void CargaMaterias()
        {
            cbMateria.DataSource = new InscripcionLogic().getMaterias(UI.Desktop.Menu.persona.IDPlan);
            cbMateria.DisplayMember = "Descripcion";
            cbMateria.ValueMember = "ID";
            flagMateria = false;
        }
        private void CargaComisiones()
        {
            cbComision.DataSource = new InscripcionLogic().getComisiones(UI.Desktop.Menu.persona.IDPlan);
            cbComision.DisplayMember = "Descripcion";
            cbComision.ValueMember = "ID";
            flagComision = false;
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            flagMateria = true;
            cargaCursos();               
        }

        private void cbComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            flagComision = true;
            cargaCursos();        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AlumnoInscripcion ai = new AlumnoInscripcion();
            ai.IDCurso = (int)cbCurso.SelectedValue;
            ai.IDAlumno = UI.Desktop.Menu.persona.ID;
            ai.State = BusinessEntity.States.New;
            ai.Condicion = "";
            new InscripcionLogic().creaInscripcion(ai);
            MessageBox.Show("Inscripción creada");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargaCursos()
        {
            if (flagComision && flagMateria)
            {
                cbCurso.DataSource = new InscripcionLogic().getCursos((int)cbMateria.SelectedValue, (int)cbComision.SelectedValue);
                cbCurso.DisplayMember = "Descripcion";
                cbCurso.ValueMember = "ID";
            }
        }
    }
}
