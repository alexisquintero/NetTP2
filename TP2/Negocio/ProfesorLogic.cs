using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ProfesorLogic
    {
        PersonasAdapter ProfesoresData;
        public ProfesorLogic()
        {
            ProfesoresData = new PersonasAdapter();
        }
        public List<Personas> GetAll()
        {
            List<Personas> Profesores = ProfesoresData.GetAll();
            for (int i = 0; i < Profesores.Count; i++)
            {
                if (Profesores.ElementAt(i).TipoPersona != Personas.TiposPersonas.Docente)
                {
                    Profesores.RemoveAt(i);
                }
            }
            return Profesores;
        }
        public Personas GetOne(int ID)
        {
            return ProfesoresData.GetOne(ID);
        }
        public void Save(Personas per)
        {
            ProfesoresData.Save(per);
        }
        public void Delete(int ID)
        {
            ProfesoresData.Delete(ID);
        }
    }
}
