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
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
            dgvModulos.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            ModuloLogic ml = new ModuloLogic();
            dgvModulos.DataSource = ml.GetAll();
        }

        private void Modulos_Load(object sender, EventArgs e)
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
