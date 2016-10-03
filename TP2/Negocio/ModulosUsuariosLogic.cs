using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class ModulosUsuariosLogic
    {
        ModuloUsuarioAdapter ModulosUsuariosData;
        public ModulosUsuariosLogic()
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
    }
}
