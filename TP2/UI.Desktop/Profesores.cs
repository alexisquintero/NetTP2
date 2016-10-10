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
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
            dgvProfesores.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            ProfesorLogic pl = new ProfesorLogic();
            dgvProfesores.DataSource = pl.GetAll();
        }

        private void Profesores_Load(object sender, EventArgs e)
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
            ProfesorDesktop formProfesor = new ProfesorDesktop(ApplicationForm.ModoForm.Alta);
            formProfesor.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.SelectedRows.Count > 0)
            {
                int ID = ((Business.Entities.Personas)this.dgvProfesores.SelectedRows[0].DataBoundItem).ID;

                ProfesorDesktop formProfesor = new ProfesorDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formProfesor.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados", "Error", MessageBoxButtons.OK);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.SelectedRows.Count > 0)
            {
                int ID = ((Business.Entities.Personas)this.dgvProfesores.SelectedRows[0].DataBoundItem).ID;

                ProfesorDesktop formProfesor = new ProfesorDesktop(ID, ApplicationForm.ModoForm.Baja);
                formProfesor.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
