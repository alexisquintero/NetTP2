using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        Data.Database.UsuarioAdapter UsuarioData;
        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }
        public Business.Entities.Usuario GetOne(int ID)
        {
           return UsuarioData.GetOne(ID);
        }
        public List<Usuario> GetAll()
        {
           return UsuarioData.GetAll();
        }
        public void Save(Business.Entities.Usuario Usr)
        {
            UsuarioData.Save(Usr);
        }
        public void Delete(int ID)
        {
            UsuarioData.Delete(ID);
        }
        public Business.Entities.Personas Ingresar(string usuario, string clave)
        {
            List < Usuario > usuarios = this.GetAll();
            int index = -1;
            int i = 0;
            foreach (Usuario u in usuarios)
            {
                if (u.NombreUsuario == usuario || u.Clave == clave)
                {
                    index = i; 
                }
                i++;
            }
            if (index == -1)
            {
                return null;
            }
            else
            {
                PersonasLogic pl = new PersonasLogic();
                return pl.GetOne(usuarios.ElementAt(index).idPersona);
            }         
        }
    }
}
