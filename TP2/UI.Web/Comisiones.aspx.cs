using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
using Util;

namespace UI.Web
{
    public partial class Comisiones : ApplicationForm
    {
        protected new void Page_Load(object sender, EventArgs e)
        {
            this.controlaLogin();
            this.controlaPermisos();
            this.LoadGrid();
        }
        ComisionLogic _logic;
        private ComisionLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new ComisionLogic();
                }
                return _logic;
            }
        }
        public Comision Entity { get; set; }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.descripcionTextBox.Text = this.Entity.Descripcion;
            this.anioEspecialidadTextBox.Text = this.Entity.AnioEspecialidad.ToString();
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
            this.descripcionTextBox.Enabled = enable;
            this.anioEspecialidadTextBox.Enabled = enable;
            this.idPlanTextBox.Enabled = enable;
        }
        private void LoadEntity(Comision comision)
        {
            comision.Descripcion = this.descripcionTextBox.Text;
            comision.AnioEspecialidad = Int32.Parse(this.anioEspecialidadTextBox.Text);
            comision.IDPlan = Int32.Parse(this.idPlanTextBox.Text);
        }
        private void SaveEntity(Comision comision)
        {
            this.Logic.Save(comision);
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
                    this.Entity = new Comision();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Comision();
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
            this.anioEspecialidadTextBox.Text = string.Empty;
            this.idPlanTextBox.Text = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            this.formPanel.Visible = false;
            this.ViewState["SelectedID"] = null;
            gridView.SelectedIndex = -1;
        }
        private new void controlaPermisos()
        {
            Personas p = (Personas)Session["p"];
            if (!ControlAccesoWeb.controlComisiones(p.TipoPersona))
            {
                Server.Transfer("~/PermisosInsuficientes.aspx", true);
            }
        }
    }    
}