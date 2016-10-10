using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class AlumnoLogic
    {
        PersonasAdapter AlumnosData;
        public AlumnoLogic()
        {
            AlumnosData = new PersonasAdapter();
        }
        public List<Personas> GetAll()
        {
            List<Personas> Alumnos = AlumnosData.GetAll();
            for (int i = 0; i < Alumnos.Count; i++)
            {
                if (Alumnos.ElementAt(i).TipoPersona != Personas.TiposPersonas.Alumno)
                {
                    Alumnos.RemoveAt(i); 
                }
            }
            return Alumnos;
        }
        public Personas GetOne(int ID)
        {
            return AlumnosData.GetOne(ID);
        }
        public void Save(Personas per)
        {
            AlumnosData.Save(per);
        }
        public void Delete(int ID)
        {
            AlumnosData.Delete(ID);
        }
    }
}
