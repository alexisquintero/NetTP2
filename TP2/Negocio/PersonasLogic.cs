using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class PersonasLogic
    {
        PersonasAdapter PersonasData;
        public PersonasLogic()
        {
            PersonasData = new PersonasAdapter();
        }
        public List<Personas> GetAll()
        {
            return PersonasData.GetAll();
        }
        public Personas GetOne(int ID)
        {
            return PersonasData.GetOne(ID);
        }
        public void Save(Personas per)
        {
            PersonasData.Save(per);
        }
        public void Delete(int ID)
        {
            PersonasData.Delete(ID);
        }
    }
}
