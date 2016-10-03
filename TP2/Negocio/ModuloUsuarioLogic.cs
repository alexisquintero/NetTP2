using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class ModuloUsuarioLogic
    {
        ModuloUsuarioAdapter ModulosUsuariosData;
        public ModuloUsuarioLogic()
        {
            ModulosUsuariosData = new ModuloUsuarioAdapter();
        }
        public List<ModuloUsuario> GetAll()
        {
            return ModulosUsuariosData.GetAll();
        }
        public ModuloUsuario GetOne(int ID)
        {
            return ModulosUsuariosData.GetOne(ID);
        }
        public void Save(ModuloUsuario mu)
        {
            ModulosUsuariosData.Save(mu);
        }
        public void Delete(int ID)
        {
            ModulosUsuariosData.Delete(ID);
        }
    }
}
