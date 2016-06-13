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

    }
}
