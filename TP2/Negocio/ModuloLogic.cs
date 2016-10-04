using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ModuloLogic
    {
        ModuloAdapter ModuloData;
        public ModuloLogic()
        {
            ModuloData = new ModuloAdapter();
        }
        public List<Modulo> GetAll()
        {
            return ModuloData.GetAll();
        }
        public Modulo GetOne(int ID)
        {
            return ModuloData.GetOne(ID);
        }
        public void Save(Modulo mod)
        {
            ModuloData.Save(mod);
        }
        public void Delete(int ID)
        {
            ModuloData.Delete(ID);
        }
    }
}
