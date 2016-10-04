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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
            this.dgvEspecialidad.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            this.dgvEspecialidad.DataSource = el.GetAll();
        }

        private void Especialidad_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
                EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
                formEspecialidad.ShowDialog();
                this.Listar(); 
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if(dgvEspecialidad.SelectedRows.Count > 0)
            {
                int ID = ((Especialidad)dgvEspecialidad.SelectedRows[0].DataBoundItem).ID;

                EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formEspecialidad.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados", "Error", MessageBoxButtons.OK);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidad.SelectedRows.Count > 0)
            {
                int ID = ((Especialidad)dgvEspecialidad.SelectedRows[0].DataBoundItem).ID;

                EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Baja);
                formEspecialidad.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
