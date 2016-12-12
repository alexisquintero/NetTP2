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
    public partial class Login : ApplicationForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Business.Entities.Personas p = this.Ingresar();
            if (p != null)
            {
                Menu menu = new Menu(p);
                menu.ShowDialog();
            }          
        }
        public Business.Entities.Personas Ingresar()
        {
            Business.Entities.Personas p = new UsuarioLogic().Ingresar(txtUsuario.Text, txtContrasenia.Text);
            if (p == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return null;
            }
            return p;
        }
    }
}
