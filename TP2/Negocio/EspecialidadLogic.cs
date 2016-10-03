using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace Business.Logic
{
    public class EspecialidadLogic
    {
        EspecialidadAdapter EspecialidadData;
        public EspecialidadLogic()
        {
            EspecialidadData = new EspecialidadAdapter();
        }
        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }

        public Especialidad GetOne(int ID)
        {
            return EspecialidadData.GetOne(ID);
        }
        public void Save(Especialidad esp)
        {
            EspecialidadData.Save(esp);
        }
        public void Delete(int ID)
        {
            EspecialidadData.Delete(ID);
        }
    }
}
