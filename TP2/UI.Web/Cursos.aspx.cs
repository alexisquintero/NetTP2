using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Cursos : ApplicationForm
    {
        protected new void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        CursoLogic _logic;
        private CursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new CursoLogic();
                }
                return _logic;
            }
        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }
        public Curso Entity { get; set; }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.descripcionTextBox.Text = this.Entity.Descripcion;
            this.anioCalendarioTextBox.Text = this.Entity.AnioCalendario.ToString();
            this.cupoTextBox.Text = this.Entity.Cupo.ToString();
            this.idComisionTextBox.Text = this.Entity.IDComision.ToString();
            this.idMateriaTextBox.Text = this.Entity.IDMateria.ToString();
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                this.EnableForm(true);
            }
        }
        private void EnableForm(bool enable)
        {
            this.descripcionTextBox.Enabled = enable;
            this.anioCalendarioTextBox.Enabled = enable;
            this.cupoTextBox.Enabled = enable;
            this.idMateriaTextBox.Enabled = enable;
            this.idComisionTextBox.Enabled = enable;
        }
        private void LoadEntity(Curso curso)
        {
            curso.Descripcion = this.descripcionTextBox.Text;
            curso.AnioCalendario = Int32.Parse(this.anioCalendarioTextBox.Text);
            curso.Cupo = Int32.Parse(this.cupoTextBox.Text);
            curso.IDComision = Int32.Parse(this.idComisionTextBox.Text);
            curso.IDMateria = Int32.Parse(this.idMateriaTextBox.Text);
        }
        private void SaveEntity(Curso curso)
        {
            this.Logic.Save(curso);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Curso();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Curso();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
            }
            this.formPanel.Visible = false;
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }
        private void ClearForm()
        {
            this.descripcionTextBox.Text = string.Empty;
            this.anioCalendarioTextBox.Text = string.Empty;
            this.cupoTextBox.Text = string.Empty;
            this.idMateriaTextBox.Text = string.Empty;
            this.idComisionTextBox.Text = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            this.formPanel.Visible = false;
            this.ViewState["SelectedID"] = null;
            gridView.SelectedIndex = -1;
        }
    }
}