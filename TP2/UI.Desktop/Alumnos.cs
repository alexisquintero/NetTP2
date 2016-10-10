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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            AlumnoLogic al = new AlumnoLogic();
            dgvAlumnos.DataSource = al.GetAll();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AlumnoDesktop formAlumno = new AlumnoDesktop(ApplicationForm.ModoForm.Alta);
            formAlumno.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                int ID = ((Business.Entities.Personas)this.dgvAlumnos.SelectedRows[0].DataBoundItem).ID;

                AlumnoDesktop formAlumno = new AlumnoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formAlumno.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados", "Error", MessageBoxButtons.OK);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                int ID = ((Business.Entities.Personas)this.dgvAlumnos.SelectedRows[0].DataBoundItem).ID;

                AlumnoDesktop formAlumno = new AlumnoDesktop(ID, ApplicationForm.ModoForm.Baja);
                formAlumno.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
