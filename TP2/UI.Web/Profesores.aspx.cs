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
    public partial class Profesores : ApplicationForm
    {
        protected new void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        ProfesorLogic _logic;
        private ProfesorLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new ProfesorLogic();
                }
                return _logic;
            }
        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }
        public Personas Entity { get; set; }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.direccionTextBox.Text = this.Entity.Direccion;
            this.emailTextBox.Text = this.Entity.Email;
            this.telefonoTextBox.Text = this.Entity.Telefono;
            this.fechaNacimientoCalendar.SelectedDate = this.Entity.FechaNacimiento;
            this.fechaNacimientoCalendar.VisibleDate = this.Entity.FechaNacimiento;
            this.idPlanTextBox.Text = this.Entity.IDPlan.ToString();
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
            this.apellidoTextBox.Enabled = enable;
            this.nombreTextBox.Enabled = enable;
            this.direccionTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.telefonoTextBox.Enabled = enable;
            this.fechaNacimientoCalendar.Enabled = enable;
            this.idPlanTextBox.Enabled = enable;
        }
        private void LoadEntity(Personas profesor)
        {
            profesor.Apellido = this.apellidoTextBox.Text;
            profesor.Nombre = this.nombreTextBox.Text;
            profesor.Direccion = this.direccionTextBox.Text;
            profesor.Email = this.emailTextBox.Text;
            profesor.Telefono = this.telefonoTextBox.Text;
            profesor.FechaNacimiento = this.fechaNacimientoCalendar.SelectedDate;
            profesor.IDPlan = Int32.Parse(this.idPlanTextBox.Text);
            profesor.TipoPersona = Personas.TiposPersonas.Docente;
            profesor.Legajo = 0;
        }
        private void SaveEntity(Personas profesor)
        {
            this.Logic.Save(profesor);
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
                    this.Entity = new Personas();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Personas();
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
            this.apellidoTextBox.Text = string.Empty;
            this.nombreTextBox.Text = string.Empty;
            this.direccionTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.telefonoTextBox.Text = string.Empty;
            this.fechaNacimientoCalendar.SelectedDate = DateTime.Today;
            this.fechaNacimientoCalendar.VisibleDate = DateTime.Today;
            this.idPlanTextBox.Text = string.Empty;
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