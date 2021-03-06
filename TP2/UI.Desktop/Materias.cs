﻿using System;
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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            dgvMaterias.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            dgvMaterias.DataSource = ml.GetAll();
        }

        private void Materias_Load(object sender, EventArgs e)
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
            MateriaDesktop formMateria = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            formMateria.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                int ID = ((Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;

                MateriaDesktop formMateria = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formMateria.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados", "Error", MessageBoxButtons.OK);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                int ID = ((Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;

                MateriaDesktop formMateria = new MateriaDesktop(ID, ApplicationForm.ModoForm.Baja);
                formMateria.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
