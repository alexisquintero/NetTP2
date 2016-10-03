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
    public partial class AlumnosInscripciones : Form
    {
        public AlumnosInscripciones()
        {
            InitializeComponent();
            dgvAlumnosInscripciones.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            dgvAlumnosInscripciones.DataSource = ail.GetAll();
        }

        private void AlumnosInscripciones_Load(object sender, EventArgs e)
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
    }
}
