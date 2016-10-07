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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            CursoLogic cl = new CursoLogic();
            dgvCursos.DataSource = cl.GetAll();
        }

        private void Cursos_Load(object sender, EventArgs e)
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
            CursoDesktop formCurso= new CursoDesktop(ApplicationForm.ModoForm.Alta);
            formCurso.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                int ID = ((Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;

                CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formCurso.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados", "Error", MessageBoxButtons.OK);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                int ID = ((Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;

                CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Baja);
                formCurso.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
