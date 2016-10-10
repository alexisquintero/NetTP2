using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }      
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAlumnoInscripcion_Click(object sender, EventArgs e)
        {
            AlumnosInscripciones alumnosInscripciones = new AlumnosInscripciones();
            alumnosInscripciones.ShowDialog();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            Cursos cursos = new Cursos();
            cursos.ShowDialog();
        }
        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidades especialidad = new Especialidades();
            especialidad.ShowDialog();
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos();
            modulos.ShowDialog();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Personas personas = new Personas();
            personas.ShowDialog();
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
        }

        private void btnComision_Click(object sender, EventArgs e)
        {
            Comisiones comisiones = new Comisiones();
            comisiones.ShowDialog();
        }

        private void btnDocenteCurso_Click(object sender, EventArgs e)
        {
            DocentesCursos docentesCursos = new DocentesCursos();
            docentesCursos.ShowDialog();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            Materias materias = new Materias();
            materias.ShowDialog();
        }

        private void btnModuloUsuario_Click(object sender, EventArgs e)
        {
            ModulosUsuarios modulosUsuarios = new ModulosUsuarios();
            modulosUsuarios.ShowDialog();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            Planes planes = new Planes();
            planes.ShowDialog();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Alumnos alumnos = new Alumnos();
            alumnos.ShowDialog();
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            Profesores profesores = new Profesores();
            profesores.ShowDialog();
        }
    }
}
